Imports Microsoft.ML
Imports Microsoft.ML.Data
Imports MySql.Data.MySqlClient

Public Class Machine
    ' Define your data model
    Public Class SalesData
        Public Property Branch As String
        Public Property Model As String
        Public Property Color As String
        Public Property DateArrive As Date
        Public Property Motorcycles_Sold As Single
    End Class

    Public Class ForecastOutput
        <VectorType(1)>
        Public Property ForecastedMotorcycles As Single()
    End Class

    ' Store the overall accuracy as a fixed value
    Private overallAccuracy As Single? = Nothing

    ' Form load event
    Private Sub Machine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Me.CenterToScreen()

        Try
            Global_procedure.CheckDatabaseConnection()

            ' Populate ComboBox with branches
            Dim branches As List(Of String) = GetBranchesFromDatabase()
            If branches.Count = 0 Then
                MessageBox.Show("No branches found in the database.")
                Return
            End If

            Cmb_Branch.Items.Clear()
            Cmb_Branch.Items.AddRange(branches.ToArray())
            Cmb_Branch.SelectedIndex = 0 ' Default to "All"

            ' Calculate overall accuracy only once
            If overallAccuracy Is Nothing Then
                CalculateOverallAccuracy()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading branches: " & ex.Message)
        End Try
    End Sub

    ' Calculate the overall accuracy for all branches
    Private Sub CalculateOverallAccuracy()
        Try
            Global_procedure.CheckDatabaseConnection()

            Dim mlContext As New MLContext()
            Dim branches As List(Of String) = GetBranchesFromDatabase()

            If branches.Count = 0 Then
                MessageBox.Show("No branches found in the database.")
                Return
            End If

            Dim totalActual As Single = 0
            Dim totalError As Single = 0

            ' Loop through each branch and calculate forecast
            For Each branch In branches
                Dim trainingData = GetTrainingDataFromDatabase(branch)
                Dim testData = GetTestDataFromDatabase(branch)

                If trainingData.Count = 0 OrElse testData.Count = 0 Then
                    Continue For ' Skip if either training or test data is missing
                End If

                Dim dataView = mlContext.Data.LoadFromEnumerable(trainingData)

                Dim pipeline = mlContext.Forecasting.ForecastBySsa(
                    outputColumnName:="ForecastedMotorcycles",
                    inputColumnName:="Motorcycles_Sold",
                    windowSize:=2,
                    seriesLength:=12,
                    trainSize:=10,
                    horizon:=1)

                ' Train the model
                Dim mlModel = pipeline.Fit(dataView)

                Dim testDataView = mlContext.Data.LoadFromEnumerable(testData)

                ' Generate predictions
                Dim predictions = mlModel.Transform(testDataView)
                Dim forecastResults = mlContext.Data.CreateEnumerable(Of ForecastOutput)(predictions, reuseRowObject:=False).ToList()

                ' Aggregate results by Model and Color
                For i As Integer = 0 To Math.Min(forecastResults.Count, testData.Count) - 1
                    Dim actualValue As Single = testData(i).Motorcycles_Sold
                    Dim forecastedValue As Single = forecastResults(i).ForecastedMotorcycles(0)

                    totalActual += actualValue
                    totalError += Math.Abs(actualValue - forecastedValue)
                Next
            Next

            If totalActual > 0 Then
                overallAccuracy = 100 - ((totalError / totalActual) * 100)
            Else
                overallAccuracy = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error calculating overall accuracy: " & ex.Message)
        End Try
    End Sub

    ' Button click event for training and testing
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Try
            Global_procedure.CheckDatabaseConnection()

            Dim mlContext As New MLContext()
            Dim selectedBranch As String = Cmb_Branch.SelectedItem.ToString()

            Dim branches As List(Of String)
            If selectedBranch = "All" Then
                branches = GetBranchesFromDatabase()
            Else
                branches = New List(Of String) From {selectedBranch}
            End If

            If branches.Count = 0 Then
                MessageBox.Show("No branches found in the database.")
                Return
            End If

            Dim combinedForecastMessage As String = "" ' String to hold all forecast messages

            ' Loop through each branch and calculate forecast
            For Each branch In branches
                Dim trainingData = GetTrainingDataFromDatabase(branch)
                Dim testData = GetTestDataFromDatabase(branch)

                If trainingData.Count = 0 OrElse testData.Count = 0 Then
                    Continue For ' Skip if either training or test data is missing
                End If

                Dim dataView = mlContext.Data.LoadFromEnumerable(trainingData)

                Dim pipeline = mlContext.Forecasting.ForecastBySsa(
                    outputColumnName:="ForecastedMotorcycles",
                    inputColumnName:="Motorcycles_Sold",
                    windowSize:=2,
                    seriesLength:=12,
                    trainSize:=10,
                    horizon:=1)

                ' Train the model
                Dim mlModel = pipeline.Fit(dataView)

                Dim testDataView = mlContext.Data.LoadFromEnumerable(testData)

                ' Generate predictions
                Dim predictions = mlModel.Transform(testDataView)
                Dim forecastResults = mlContext.Data.CreateEnumerable(Of ForecastOutput)(predictions, reuseRowObject:=False).ToList()

                ' Aggregate results by Model and Color
                Dim aggregatedForecast As New Dictionary(Of String, Single)

                For i As Integer = 0 To Math.Min(forecastResults.Count, testData.Count) - 1
                    Dim actualValue As Single = testData(i).Motorcycles_Sold
                    Dim forecastedValue As Single = forecastResults(i).ForecastedMotorcycles(0)

                    Dim modelName = testData(i).Model
                    Dim color = testData(i).Color
                    Dim key = $"{modelName}_{color}" ' Unique key for Model and Color

                    ' Aggregate forecasted values by Model and Color
                    If aggregatedForecast.ContainsKey(key) Then
                        aggregatedForecast(key) += forecastedValue
                    Else
                        aggregatedForecast(key) = forecastedValue
                    End If
                Next

                ' Generate forecast message for this branch
                Dim forecastMessage As String = $"Forecast for Branch: {branch}{vbCrLf}"

                For Each entry In aggregatedForecast
                    Dim parts = entry.Key.Split("_"c)
                    Dim modelName = parts(0)
                    Dim color = parts(1)
                    Dim forecastedQuantity = Math.Round(entry.Value)

                    forecastMessage &= $"    Model: {modelName}, Color: {color}, Motorcycles Needed for next: {forecastedQuantity}{vbCrLf}"
                Next

                ' Append the current branch forecast to the combined message
                combinedForecastMessage &= forecastMessage & vbCrLf
            Next

            ' Display the combined message in the RichTextBox
            RichTextBox1.Clear()
            RichTextBox1.Text = combinedForecastMessage
            RichTextBox1.ScrollToCaret()

            ' Display the fixed overall accuracy in Label2
            If overallAccuracy.HasValue Then
                Label2.Text = $"Overall Accuracy for All Branches: {overallAccuracy.Value:F2}%"
            Else
                Label2.Text = "Unable to calculate overall accuracy."
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Fetch the list of branches from the database
    Private Function GetBranchesFromDatabase() As List(Of String)
        Dim branches As New List(Of String)

        Try
            Dim query As String = "SELECT DISTINCT Brnch FROM tbl_Inventory"
            Dim cmd As New MySqlCommand(query, con_stockX)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                branches.Add(reader("Brnch").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Fetching Branches: " & ex.Message)
        End Try

        Return branches
    End Function

    ' Fetch training data for a specific branch from the database
    Private Function GetTrainingDataFromDatabase(branch As String) As List(Of SalesData)
        Dim trainingData As New List(Of SalesData)

        Try
            Dim query As String = "SELECT Model, Color, Datearrive, COUNT(*) AS Motorcycles_Sold " &
                                  "FROM tbl_Inventory " &
                                  "WHERE Stat = 'Released' AND Datearrive >= CURDATE() - INTERVAL 6 MONTH AND Brnch = @branch " &
                                  "GROUP BY Model, Color, YEAR(Datearrive), MONTH(Datearrive)"

            Dim cmd As New MySqlCommand(query, con_stockX)
            cmd.Parameters.AddWithValue("@branch", branch)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                trainingData.Add(New SalesData With {
                    .Branch = branch,
                    .Model = reader("Model").ToString(),
                    .Color = reader("Color").ToString(),
                    .DateArrive = Convert.ToDateTime(reader("Datearrive")),
                    .Motorcycles_Sold = Convert.ToSingle(reader("Motorcycles_Sold"))
                })
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Fetching Training Data for Branch " & branch & ": " & ex.Message)
        End Try

        Return trainingData
    End Function

    ' Fetch test data for a specific branch from the database
    Private Function GetTestDataFromDatabase(branch As String) As List(Of SalesData)
        Dim testData As New List(Of SalesData)

        Try
            Dim query As String = "SELECT Model, Color, Datearrive, COUNT(*) AS Motorcycles_Sold " &
                                  "FROM tbl_Inventory " &
                                  "WHERE Stat = 'Released' AND Datearrive >= CURDATE() - INTERVAL 6 MONTH AND Brnch = @branch " &
                                  "GROUP BY Model, Color, YEAR(Datearrive), MONTH(Datearrive)"

            Dim cmd As New MySqlCommand(query, con_stockX)
            cmd.Parameters.AddWithValue("@branch", branch)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                testData.Add(New SalesData With {
                    .Branch = branch,
                    .Model = reader("Model").ToString(),
                    .Color = reader("Color").ToString(),
                    .DateArrive = Convert.ToDateTime(reader("Datearrive")),
                    .Motorcycles_Sold = Convert.ToSingle(reader("Motorcycles_Sold"))
                })
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error Fetching Test Data for Branch " & branch & ": " & ex.Message)
        End Try

        Return testData
    End Function

    Private Sub Cmb_Branch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Branch.SelectedIndexChanged
        ' Trigger the forecast display when the branch selection changes
        Create_Click(sender, e)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Label2 click event if needed.
    End Sub
End Class