<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Released
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Released))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Btn_AllUnits = New System.Windows.Forms.Button()
        Me.Chk_Auto = New System.Windows.Forms.CheckBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_RepossessPage = New System.Windows.Forms.Button()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Grd_StockReleased = New System.Windows.Forms.DataGridView()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Btn_returndeposite = New System.Windows.Forms.Button()
        Me.Btn_ReturnUnit = New System.Windows.Forms.Button()
        CType(Me.Grd_StockReleased, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1086, 188)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 22)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "BRANCH:"
        '
        'Cmb_Branch
        '
        Me.Cmb_Branch.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.Cmb_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Branch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Branch.FormattingEnabled = True
        Me.Cmb_Branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.Cmb_Branch.Location = New System.Drawing.Point(1185, 188)
        Me.Cmb_Branch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cmb_Branch.Name = "Cmb_Branch"
        Me.Cmb_Branch.Size = New System.Drawing.Size(272, 26)
        Me.Cmb_Branch.TabIndex = 65
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Dashboard.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Dashboard.Location = New System.Drawing.Point(35, 648)
        Me.Btn_Dashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(119, 46)
        Me.Btn_Dashboard.TabIndex = 64
        Me.Btn_Dashboard.Text = "DASHBOARD"
        Me.Btn_Dashboard.UseVisualStyleBackColor = False
        '
        'Btn_AllUnits
        '
        Me.Btn_AllUnits.BackColor = System.Drawing.Color.Snow
        Me.Btn_AllUnits.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_AllUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AllUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_AllUnits.Location = New System.Drawing.Point(16, 46)
        Me.Btn_AllUnits.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AllUnits.Name = "Btn_AllUnits"
        Me.Btn_AllUnits.Size = New System.Drawing.Size(158, 50)
        Me.Btn_AllUnits.TabIndex = 63
        Me.Btn_AllUnits.Text = "ALL UNITS"
        Me.Btn_AllUnits.UseVisualStyleBackColor = False
        '
        'Chk_Auto
        '
        Me.Chk_Auto.AutoSize = True
        Me.Chk_Auto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Auto.Location = New System.Drawing.Point(484, 195)
        Me.Chk_Auto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Chk_Auto.Name = "Chk_Auto"
        Me.Chk_Auto.Size = New System.Drawing.Size(132, 21)
        Me.Chk_Auto.TabIndex = 62
        Me.Chk_Auto.Text = "Auto Complete"
        Me.Chk_Auto.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Search.Location = New System.Drawing.Point(674, 156)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(87, 37)
        Me.Btn_Search.TabIndex = 61
        Me.Btn_Search.Text = "SEARCH"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(190, 160)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(481, 29)
        Me.Txt_Search.TabIndex = 60
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(190, 191)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(283, 26)
        Me.cmbSearchType.TabIndex = 59
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Repossess.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Btn_Repossess.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Repossess.Location = New System.Drawing.Point(190, 648)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(119, 46)
        Me.Btn_Repossess.TabIndex = 58
        Me.Btn_Repossess.Text = "REPOSSESS"
        Me.Btn_Repossess.UseVisualStyleBackColor = False
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.BackColor = System.Drawing.Color.Snow
        Me.Btn_AllStock.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_AllStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AllStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_AllStock.Location = New System.Drawing.Point(16, 102)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(158, 50)
        Me.Btn_AllStock.TabIndex = 57
        Me.Btn_AllStock.Text = "AVAILABLE UNITS"
        Me.Btn_AllStock.UseVisualStyleBackColor = False
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.BackColor = System.Drawing.Color.Snow
        Me.Btn_Deposited.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Deposited.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Deposited.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Deposited.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Deposited.Location = New System.Drawing.Point(16, 211)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(158, 50)
        Me.Btn_Deposited.TabIndex = 56
        Me.Btn_Deposited.Text = "DEPOSITED UNITS"
        Me.Btn_Deposited.UseVisualStyleBackColor = False
        '
        'Btn_RepossessPage
        '
        Me.Btn_RepossessPage.BackColor = System.Drawing.Color.Snow
        Me.Btn_RepossessPage.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_RepossessPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_RepossessPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RepossessPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_RepossessPage.Location = New System.Drawing.Point(16, 268)
        Me.Btn_RepossessPage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_RepossessPage.Name = "Btn_RepossessPage"
        Me.Btn_RepossessPage.Size = New System.Drawing.Size(158, 50)
        Me.Btn_RepossessPage.TabIndex = 55
        Me.Btn_RepossessPage.TabStop = False
        Me.Btn_RepossessPage.Text = "REPOSSESED UNITS"
        Me.Btn_RepossessPage.UseVisualStyleBackColor = False
        '
        'Btn_Released
        '
        Me.Btn_Released.BackColor = System.Drawing.Color.Snow
        Me.Btn_Released.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Released.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Released.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Released.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Released.Location = New System.Drawing.Point(16, 157)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(158, 50)
        Me.Btn_Released.TabIndex = 54
        Me.Btn_Released.Text = "RELEASED UNITS"
        Me.Btn_Released.UseVisualStyleBackColor = False
        '
        'Grd_StockReleased
        '
        Me.Grd_StockReleased.AllowUserToAddRows = False
        Me.Grd_StockReleased.AllowUserToDeleteRows = False
        Me.Grd_StockReleased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_StockReleased.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column9, Me.Column4, Me.Column5, Me.Column8})
        Me.Grd_StockReleased.Location = New System.Drawing.Point(190, 233)
        Me.Grd_StockReleased.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Grd_StockReleased.Name = "Grd_StockReleased"
        Me.Grd_StockReleased.RowHeadersWidth = 51
        Me.Grd_StockReleased.RowTemplate.Height = 24
        Me.Grd_StockReleased.Size = New System.Drawing.Size(1266, 410)
        Me.Grd_StockReleased.TabIndex = 53
        '
        'Column10
        '
        Me.Column10.HeaderText = "CHECK"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "BRANCH"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "MERCHANDISE TRANSFER NUMBER"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DATE RELEASED"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MODEL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "PRICE"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "COLOR"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ENGINE NO."
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "FRAME NO."
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.Btn_AllUnits)
        Me.GroupBox1.Controls.Add(Me.Btn_AllStock)
        Me.GroupBox1.Controls.Add(Me.Btn_Released)
        Me.GroupBox1.Controls.Add(Me.Btn_Deposited)
        Me.GroupBox1.Controls.Add(Me.Btn_RepossessPage)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(0, 233)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(185, 410)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 162)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 31)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "RELEASED UNITS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(451, 56)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "INVENTORY LISTS"
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(1185, 81)
        Me.dt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(272, 23)
        Me.dt.TabIndex = 74
        '
        'Btn_returndeposite
        '
        Me.Btn_returndeposite.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_returndeposite.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Btn_returndeposite.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_returndeposite.Location = New System.Drawing.Point(1282, 652)
        Me.Btn_returndeposite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_returndeposite.Name = "Btn_returndeposite"
        Me.Btn_returndeposite.Size = New System.Drawing.Size(119, 46)
        Me.Btn_returndeposite.TabIndex = 75
        Me.Btn_returndeposite.Text = "UNDO RELEASE"
        Me.Btn_returndeposite.UseVisualStyleBackColor = False
        '
        'Btn_ReturnUnit
        '
        Me.Btn_ReturnUnit.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_ReturnUnit.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ReturnUnit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_ReturnUnit.Location = New System.Drawing.Point(1158, 652)
        Me.Btn_ReturnUnit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_ReturnUnit.Name = "Btn_ReturnUnit"
        Me.Btn_ReturnUnit.Size = New System.Drawing.Size(119, 46)
        Me.Btn_ReturnUnit.TabIndex = 77
        Me.Btn_ReturnUnit.Text = "RETURN UNIT"
        Me.Btn_ReturnUnit.UseVisualStyleBackColor = False
        '
        'Released
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1443, 748)
        Me.Controls.Add(Me.Btn_ReturnUnit)
        Me.Controls.Add(Me.Btn_returndeposite)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Branch)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.Chk_Auto)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.Btn_Repossess)
        Me.Controls.Add(Me.Grd_StockReleased)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Released"
        Me.Text = "Released"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grd_StockReleased, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Branch As ComboBox
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Btn_AllUnits As Button
    Friend WithEvents Chk_Auto As CheckBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_RepossessPage As Button
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Grd_StockReleased As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

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
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Btn_returndeposite As Button
    Friend WithEvents Btn_ReturnUnit As Button
End Class
