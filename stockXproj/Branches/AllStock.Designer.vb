<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllStock
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
        Me.Lbl_Branch = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Grd_Stock = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_AddCust = New System.Windows.Forms.Button()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.cmb_branch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Grd_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Branch
        '
        Me.Lbl_Branch.AutoSize = True
        Me.Lbl_Branch.Location = New System.Drawing.Point(11, 9)
        Me.Lbl_Branch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Branch.Name = "Lbl_Branch"
        Me.Lbl_Branch.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_Branch.TabIndex = 16
        Me.Lbl_Branch.Text = "X BRANCH"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 134)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 50)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "All Units"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Location = New System.Drawing.Point(208, 56)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(92, 17)
        Me.chkAuto.TabIndex = 32
        Me.chkAuto.Text = "AutoComplete"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.Location = New System.Drawing.Point(372, 12)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(56, 19)
        Me.Btn_Search.TabIndex = 31
        Me.Btn_Search.Text = "search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(208, 12)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(160, 20)
        Me.txtSearch.TabIndex = 30
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(208, 33)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(92, 21)
        Me.cmbSearchType.TabIndex = 29
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.Location = New System.Drawing.Point(69, 188)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(107, 50)
        Me.Btn_AllStock.TabIndex = 26
        Me.Btn_AllStock.Text = "All Available Stock"
        Me.Btn_AllStock.UseVisualStyleBackColor = True
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.Location = New System.Drawing.Point(69, 295)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Deposited.TabIndex = 25
        Me.Btn_Deposited.Text = "Deposited"
        Me.Btn_Deposited.UseVisualStyleBackColor = True
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.Location = New System.Drawing.Point(69, 349)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Repossess.TabIndex = 24
        Me.Btn_Repossess.TabStop = False
        Me.Btn_Repossess.Text = "Repossess"
        Me.Btn_Repossess.UseVisualStyleBackColor = True
        '
        'Btn_Released
        '
        Me.Btn_Released.Location = New System.Drawing.Point(69, 241)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Released.TabIndex = 23
        Me.Btn_Released.Text = "Released "
        Me.Btn_Released.UseVisualStyleBackColor = True
        '
        'Grd_Stock
        '
        Me.Grd_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column9, Me.Column4, Me.Column5, Me.Column8})
        Me.Grd_Stock.Location = New System.Drawing.Point(181, 76)
        Me.Grd_Stock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Grd_Stock.Name = "Grd_Stock"
        Me.Grd_Stock.RowHeadersWidth = 51
        Me.Grd_Stock.RowTemplate.Height = 24
        Me.Grd_Stock.Size = New System.Drawing.Size(787, 306)
        Me.Grd_Stock.TabIndex = 22
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
        Me.Column2.HeaderText = "Date Arrived"
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
        'Btn_AddCust
        '
        Me.Btn_AddCust.Location = New System.Drawing.Point(675, 402)
        Me.Btn_AddCust.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AddCust.Name = "Btn_AddCust"
        Me.Btn_AddCust.Size = New System.Drawing.Size(107, 37)
        Me.Btn_AddCust.TabIndex = 27
        Me.Btn_AddCust.Text = "Add Customer"
        Me.Btn_AddCust.UseVisualStyleBackColor = True
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.Location = New System.Drawing.Point(810, 412)
        Me.Btn_Dashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(122, 19)
        Me.Btn_Dashboard.TabIndex = 36
        Me.Btn_Dashboard.Text = "Back to DashBoard"
        Me.Btn_Dashboard.UseVisualStyleBackColor = True
        '
        'cmb_branch
        '
        Me.cmb_branch.AutoCompleteCustomSource.AddRange(New String() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.FormattingEnabled = True
        Me.cmb_branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.Location = New System.Drawing.Point(878, 54)
        Me.cmb_branch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_branch.Name = "cmb_branch"
        Me.cmb_branch.Size = New System.Drawing.Size(92, 21)
        Me.cmb_branch.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(825, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Branches"
        '
        'AllStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 448)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_branch)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.Btn_AddCust)
        Me.Controls.Add(Me.Btn_AllStock)
        Me.Controls.Add(Me.Btn_Deposited)
        Me.Controls.Add(Me.Btn_Repossess)
        Me.Controls.Add(Me.Btn_Released)
        Me.Controls.Add(Me.Grd_Stock)
        Me.Controls.Add(Me.Lbl_Branch)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AllStock"
        Me.Text = "AllStock"
        CType(Me.Grd_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Branch As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Btn_AddCust As Button
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Grd_Stock As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents cmb_branch As ComboBox
    Friend WithEvents Label1 As Label
End Class
