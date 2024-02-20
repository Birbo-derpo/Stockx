<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Deposited
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Grd_StockDeposit = New System.Windows.Forms.DataGridView()
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
        CType(Me.Grd_StockDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1053, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Branches"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.ComboBox1.Location = New System.Drawing.Point(1134, 77)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 51
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.Location = New System.Drawing.Point(1033, 519)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(162, 23)
        Me.Btn_Dashboard.TabIndex = 50
        Me.Btn_Dashboard.Text = "Back to DashBoard"
        Me.Btn_Dashboard.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 177)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 62)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "All Units"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Location = New System.Drawing.Point(231, 81)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(114, 20)
        Me.chkAuto.TabIndex = 48
        Me.chkAuto.Text = "AutoComplete"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(449, 27)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 47
        Me.btnSearch.Text = "search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(231, 27)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(212, 22)
        Me.txtSearch.TabIndex = 46
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(231, 53)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(121, 24)
        Me.cmbSearchType.TabIndex = 45
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(853, 507)
        Me.Btn_Update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(143, 46)
        Me.Btn_Update.TabIndex = 44
        Me.Btn_Update.Text = "Released"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.Location = New System.Drawing.Point(45, 243)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(143, 62)
        Me.Btn_AllStock.TabIndex = 43
        Me.Btn_AllStock.Text = "All Available Stock"
        Me.Btn_AllStock.UseVisualStyleBackColor = True
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.Location = New System.Drawing.Point(45, 375)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Deposited.TabIndex = 42
        Me.Btn_Deposited.Text = "Deposited"
        Me.Btn_Deposited.UseVisualStyleBackColor = True
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.Location = New System.Drawing.Point(45, 441)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Repossess.TabIndex = 41
        Me.Btn_Repossess.TabStop = False
        Me.Btn_Repossess.Text = "Repossess"
        Me.Btn_Repossess.UseVisualStyleBackColor = True
        '
        'Btn_Released
        '
        Me.Btn_Released.Location = New System.Drawing.Point(45, 309)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Released.TabIndex = 40
        Me.Btn_Released.Text = "Released "
        Me.Btn_Released.UseVisualStyleBackColor = True
        '
        'Grd_StockDeposit
        '
        Me.Grd_StockDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_StockDeposit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column9, Me.Column4, Me.Column5, Me.Column8})
        Me.Grd_StockDeposit.Location = New System.Drawing.Point(194, 105)
        Me.Grd_StockDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Grd_StockDeposit.Name = "Grd_StockDeposit"
        Me.Grd_StockDeposit.RowHeadersWidth = 51
        Me.Grd_StockDeposit.RowTemplate.Height = 24
        Me.Grd_StockDeposit.Size = New System.Drawing.Size(1091, 377)
        Me.Grd_StockDeposit.TabIndex = 39
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
        Me.Column2.HeaderText = "Date Diposited"
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
        'Deposited
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 576)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_AllStock)
        Me.Controls.Add(Me.Btn_Deposited)
        Me.Controls.Add(Me.Btn_Repossess)
        Me.Controls.Add(Me.Btn_Released)
        Me.Controls.Add(Me.Grd_StockDeposit)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Deposited"
        Me.Text = "Diposited"
        CType(Me.Grd_StockDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Grd_StockDeposit As DataGridView
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
