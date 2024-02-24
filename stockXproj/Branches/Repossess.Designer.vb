<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Repossess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Grd_StockRepossessed = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grd_StockRepossessed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1005, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Sort by Branch"
        '
        'Cmb_Branch
        '
        Me.Cmb_Branch.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.Cmb_Branch.FormattingEnabled = True
        Me.Cmb_Branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.Cmb_Branch.Location = New System.Drawing.Point(1109, 98)
        Me.Cmb_Branch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Branch.Name = "Cmb_Branch"
        Me.Cmb_Branch.Size = New System.Drawing.Size(121, 24)
        Me.Cmb_Branch.TabIndex = 65
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.Location = New System.Drawing.Point(1009, 542)
        Me.Btn_Dashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(163, 23)
        Me.Btn_Dashboard.TabIndex = 64
        Me.Btn_Dashboard.Text = "Back to DashBoard"
        Me.Btn_Dashboard.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 199)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 62)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "All Units"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Location = New System.Drawing.Point(207, 103)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(114, 20)
        Me.chkAuto.TabIndex = 62
        Me.chkAuto.Text = "AutoComplete"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.Location = New System.Drawing.Point(425, 49)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Search.TabIndex = 61
        Me.Btn_Search.Text = "search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(207, 49)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(212, 22)
        Me.txtSearch.TabIndex = 60
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(207, 75)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(121, 24)
        Me.cmbSearchType.TabIndex = 59
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.Location = New System.Drawing.Point(21, 265)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(143, 62)
        Me.Btn_AllStock.TabIndex = 57
        Me.Btn_AllStock.Text = "All Available Stock"
        Me.Btn_AllStock.UseVisualStyleBackColor = True
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.Location = New System.Drawing.Point(21, 398)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Deposited.TabIndex = 56
        Me.Btn_Deposited.Text = "Deposited"
        Me.Btn_Deposited.UseVisualStyleBackColor = True
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.Location = New System.Drawing.Point(21, 463)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Repossess.TabIndex = 55
        Me.Btn_Repossess.TabStop = False
        Me.Btn_Repossess.Text = "Repossess"
        Me.Btn_Repossess.UseVisualStyleBackColor = True
        '
        'Btn_Released
        '
        Me.Btn_Released.Location = New System.Drawing.Point(21, 331)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Released.TabIndex = 54
        Me.Btn_Released.Text = "Released "
        Me.Btn_Released.UseVisualStyleBackColor = True
        '
        'Grd_StockRepossessed
        '
        Me.Grd_StockRepossessed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_StockRepossessed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column9, Me.Column4, Me.Column5, Me.Column8})
        Me.Grd_StockRepossessed.Location = New System.Drawing.Point(171, 127)
        Me.Grd_StockRepossessed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Grd_StockRepossessed.Name = "Grd_StockRepossessed"
        Me.Grd_StockRepossessed.RowHeadersWidth = 51
        Me.Grd_StockRepossessed.RowTemplate.Height = 24
        Me.Grd_StockRepossessed.Size = New System.Drawing.Size(1091, 377)
        Me.Grd_StockRepossessed.TabIndex = 53
        '
        'Column10
        '
        Me.Column10.HeaderText = "Check"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Branch"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Merchandise Transfer Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Date Reposes"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Model"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Price"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Color"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Engine no."
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Frame no"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Status"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Repossess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 615)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Branch)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.Btn_AllStock)
        Me.Controls.Add(Me.Btn_Deposited)
        Me.Controls.Add(Me.Btn_Repossess)
        Me.Controls.Add(Me.Btn_Released)
        Me.Controls.Add(Me.Grd_StockRepossessed)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Repossess"
        Me.Text = "Reposes"
        CType(Me.Grd_StockRepossessed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Branch As ComboBox
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Grd_StockRepossessed As DataGridView
    Friend WithEvents Column10 As DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
