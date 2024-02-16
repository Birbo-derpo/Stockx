<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reserve
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
        Me.Btn_Transit = New System.Windows.Forms.Button()
        Me.Btn_AvStock = New System.Windows.Forms.Button()
        Me.Btn_Reserved = New System.Windows.Forms.Button()
        Me.Btn_AddReserve = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grd_MotorcycleReserved = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Add_MT = New System.Windows.Forms.Button()
        Me.cmb_branch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MTN = New System.Windows.Forms.TextBox()
        CType(Me.Grd_MotorcycleReserved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Transit
        '
        Me.Btn_Transit.Location = New System.Drawing.Point(28, 203)
        Me.Btn_Transit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Transit.Name = "Btn_Transit"
        Me.Btn_Transit.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Transit.TabIndex = 28
        Me.Btn_Transit.Text = "Transit"
        Me.Btn_Transit.UseVisualStyleBackColor = True
        '
        'Btn_AvStock
        '
        Me.Btn_AvStock.Location = New System.Drawing.Point(28, 115)
        Me.Btn_AvStock.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_AvStock.Name = "Btn_AvStock"
        Me.Btn_AvStock.Size = New System.Drawing.Size(107, 50)
        Me.Btn_AvStock.TabIndex = 27
        Me.Btn_AvStock.Text = "Available Stock"
        Me.Btn_AvStock.UseVisualStyleBackColor = True
        '
        'Btn_Reserved
        '
        Me.Btn_Reserved.Location = New System.Drawing.Point(28, 158)
        Me.Btn_Reserved.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Reserved.Name = "Btn_Reserved"
        Me.Btn_Reserved.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Reserved.TabIndex = 26
        Me.Btn_Reserved.Text = "Reserved"
        Me.Btn_Reserved.UseVisualStyleBackColor = True
        '
        'Btn_AddReserve
        '
        Me.Btn_AddReserve.Location = New System.Drawing.Point(744, 382)
        Me.Btn_AddReserve.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_AddReserve.Name = "Btn_AddReserve"
        Me.Btn_AddReserve.Size = New System.Drawing.Size(107, 50)
        Me.Btn_AddReserve.TabIndex = 29
        Me.Btn_AddReserve.Text = "Reserve"
        Me.Btn_AddReserve.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Display selected Branch"
        '
        'Grd_MotorcycleReserved
        '
        Me.Grd_MotorcycleReserved.AllowUserToAddRows = False
        Me.Grd_MotorcycleReserved.AllowUserToDeleteRows = False
        Me.Grd_MotorcycleReserved.AllowUserToOrderColumns = True
        Me.Grd_MotorcycleReserved.AllowUserToResizeColumns = False
        Me.Grd_MotorcycleReserved.AllowUserToResizeRows = False
        Me.Grd_MotorcycleReserved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_MotorcycleReserved.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.Grd_MotorcycleReserved.Location = New System.Drawing.Point(155, 79)
        Me.Grd_MotorcycleReserved.Margin = New System.Windows.Forms.Padding(2)
        Me.Grd_MotorcycleReserved.Name = "Grd_MotorcycleReserved"
        Me.Grd_MotorcycleReserved.RowHeadersWidth = 51
        Me.Grd_MotorcycleReserved.RowTemplate.Height = 24
        Me.Grd_MotorcycleReserved.Size = New System.Drawing.Size(658, 232)
        Me.Grd_MotorcycleReserved.TabIndex = 34
        '
        'Column10
        '
        Me.Column10.HeaderText = "To Deliver"
        Me.Column10.Name = "Column10"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Branch"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Invoice Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date& Time"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Model"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Color"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Engine Number"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Frame Number"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Status"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Btn_Add_MT
        '
        Me.Btn_Add_MT.Location = New System.Drawing.Point(593, 315)
        Me.Btn_Add_MT.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Add_MT.Name = "Btn_Add_MT"
        Me.Btn_Add_MT.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Add_MT.TabIndex = 35
        Me.Btn_Add_MT.Text = "Add MT no."
        Me.Btn_Add_MT.UseVisualStyleBackColor = True
        '
        'cmb_branch
        '
        Me.cmb_branch.FormattingEnabled = True
        Me.cmb_branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.Location = New System.Drawing.Point(155, 43)
        Me.cmb_branch.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_branch.Name = "cmb_branch"
        Me.cmb_branch.Size = New System.Drawing.Size(92, 21)
        Me.cmb_branch.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(624, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Enter MT Number"
        '
        'txt_MTN
        '
        Me.txt_MTN.Location = New System.Drawing.Point(720, 44)
        Me.txt_MTN.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_MTN.Name = "txt_MTN"
        Me.txt_MTN.Size = New System.Drawing.Size(76, 20)
        Me.txt_MTN.TabIndex = 42
        '
        'Reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 366)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_MTN)
        Me.Controls.Add(Me.cmb_branch)
        Me.Controls.Add(Me.Btn_Add_MT)
        Me.Controls.Add(Me.Grd_MotorcycleReserved)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Transit)
        Me.Controls.Add(Me.Btn_AvStock)
        Me.Controls.Add(Me.Btn_Reserved)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Reserve"
        Me.Text = "Reserve"
        CType(Me.Grd_MotorcycleReserved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Transit As Button
    Friend WithEvents Btn_AvStock As Button
    Friend WithEvents Btn_Reserved As Button
    Friend WithEvents Btn_AddReserve As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Grd_MotorcycleReserved As DataGridView
    Friend WithEvents Btn_Add_MT As Button
    Friend WithEvents cmb_branch As ComboBox
    Friend WithEvents Column10 As DataGridViewCheckBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MTN As TextBox
End Class
