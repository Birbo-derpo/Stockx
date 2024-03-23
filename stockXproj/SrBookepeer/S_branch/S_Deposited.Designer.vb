<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_Deposited
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_Deposited))
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_AllUnits = New System.Windows.Forms.Button()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Grd_StockDeposit = New System.Windows.Forms.DataGridView()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Chk_Auto = New System.Windows.Forms.CheckBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Cmb_SearchType = New System.Windows.Forms.ComboBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        CType(Me.Grd_StockDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "FRAME NO."
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Btn_AllUnits
        '
        Me.Btn_AllUnits.BackColor = System.Drawing.Color.Snow
        Me.Btn_AllUnits.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_AllUnits.FlatAppearance.BorderSize = 2
        Me.Btn_AllUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AllUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_AllUnits.Location = New System.Drawing.Point(15, 102)
        Me.Btn_AllUnits.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AllUnits.Name = "Btn_AllUnits"
        Me.Btn_AllUnits.Size = New System.Drawing.Size(166, 50)
        Me.Btn_AllUnits.TabIndex = 49
        Me.Btn_AllUnits.Text = "ALL UNITS"
        Me.Btn_AllUnits.UseVisualStyleBackColor = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ENGINE NO."
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "COLOR"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "PRICE"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MODEL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DATE DEPOSITED"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "MT NO."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column7
        '
        Me.Column7.HeaderText = "BRANCH"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "SELECT"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Grd_StockDeposit
        '
        Me.Grd_StockDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_StockDeposit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column9, Me.Column4, Me.Column5, Me.Column8})
        Me.Grd_StockDeposit.Location = New System.Drawing.Point(184, 255)
        Me.Grd_StockDeposit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Grd_StockDeposit.Name = "Grd_StockDeposit"
        Me.Grd_StockDeposit.RowHeadersWidth = 51
        Me.Grd_StockDeposit.RowTemplate.Height = 24
        Me.Grd_StockDeposit.Size = New System.Drawing.Size(1297, 472)
        Me.Grd_StockDeposit.TabIndex = 71
        '
        'Btn_Released
        '
        Me.Btn_Released.BackColor = System.Drawing.Color.Snow
        Me.Btn_Released.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Released.FlatAppearance.BorderSize = 2
        Me.Btn_Released.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Released.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Released.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Released.Location = New System.Drawing.Point(15, 209)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(166, 50)
        Me.Btn_Released.TabIndex = 40
        Me.Btn_Released.Text = "RELEASED UNITS"
        Me.Btn_Released.UseVisualStyleBackColor = False
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.BackColor = System.Drawing.Color.Snow
        Me.Btn_Repossess.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Repossess.FlatAppearance.BorderSize = 2
        Me.Btn_Repossess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Repossess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Repossess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Repossess.Location = New System.Drawing.Point(15, 317)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(166, 50)
        Me.Btn_Repossess.TabIndex = 41
        Me.Btn_Repossess.TabStop = False
        Me.Btn_Repossess.Text = "REPOSSESED UNITS"
        Me.Btn_Repossess.UseVisualStyleBackColor = False
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.BackColor = System.Drawing.Color.Snow
        Me.Btn_Deposited.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Deposited.FlatAppearance.BorderSize = 2
        Me.Btn_Deposited.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Deposited.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Deposited.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Deposited.Location = New System.Drawing.Point(15, 263)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(166, 50)
        Me.Btn_Deposited.TabIndex = 42
        Me.Btn_Deposited.Text = "DEPOSITED UNITS"
        Me.Btn_Deposited.UseVisualStyleBackColor = False
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.BackColor = System.Drawing.Color.Snow
        Me.Btn_AllStock.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_AllStock.FlatAppearance.BorderSize = 2
        Me.Btn_AllStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AllStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_AllStock.Location = New System.Drawing.Point(15, 155)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(166, 50)
        Me.Btn_AllStock.TabIndex = 43
        Me.Btn_AllStock.Text = "AVAILABLE UNITS"
        Me.Btn_AllStock.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.Btn_AllUnits)
        Me.GroupBox1.Controls.Add(Me.Btn_Released)
        Me.GroupBox1.Controls.Add(Me.Btn_Repossess)
        Me.GroupBox1.Controls.Add(Me.Btn_Deposited)
        Me.GroupBox1.Controls.Add(Me.Btn_AllStock)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(-6, 254)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(185, 472)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1072, 214)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 22)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "BRANCH:"
        '
        'Cmb_Branch
        '
        Me.Cmb_Branch.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.Cmb_Branch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Branch.FormattingEnabled = True
        Me.Cmb_Branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.Cmb_Branch.Location = New System.Drawing.Point(1174, 210)
        Me.Cmb_Branch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cmb_Branch.Name = "Cmb_Branch"
        Me.Cmb_Branch.Size = New System.Drawing.Size(272, 26)
        Me.Cmb_Branch.TabIndex = 78
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Dashboard.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Dashboard.Location = New System.Drawing.Point(182, 739)
        Me.Btn_Dashboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(119, 46)
        Me.Btn_Dashboard.TabIndex = 77
        Me.Btn_Dashboard.Text = "DASHBOARD"
        Me.Btn_Dashboard.UseVisualStyleBackColor = False
        '
        'Chk_Auto
        '
        Me.Chk_Auto.AutoSize = True
        Me.Chk_Auto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Auto.Location = New System.Drawing.Point(478, 218)
        Me.Chk_Auto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Chk_Auto.Name = "Chk_Auto"
        Me.Chk_Auto.Size = New System.Drawing.Size(132, 21)
        Me.Chk_Auto.TabIndex = 76
        Me.Chk_Auto.Text = "Auto Complete"
        Me.Chk_Auto.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Search.Location = New System.Drawing.Point(584, 176)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(93, 34)
        Me.Btn_Search.TabIndex = 75
        Me.Btn_Search.Text = "SEARCH"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(184, 178)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(396, 29)
        Me.Txt_Search.TabIndex = 74
        '
        'Cmb_SearchType
        '
        Me.Cmb_SearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.Cmb_SearchType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_SearchType.FormattingEnabled = True
        Me.Cmb_SearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.Cmb_SearchType.Location = New System.Drawing.Point(184, 214)
        Me.Cmb_SearchType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cmb_SearchType.Name = "Cmb_SearchType"
        Me.Cmb_SearchType.Size = New System.Drawing.Size(283, 26)
        Me.Cmb_SearchType.TabIndex = 73
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Update.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Update.Location = New System.Drawing.Point(305, 739)
        Me.Btn_Update.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(119, 46)
        Me.Btn_Update.TabIndex = 72
        Me.Btn_Update.Text = "RELEASE"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 155)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(184, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1341, 154)
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(16, 188)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 58)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "DEPOSITED" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     UNITS"
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(1162, 179)
        Me.dt.Margin = New System.Windows.Forms.Padding(2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(270, 23)
        Me.dt.TabIndex = 88
        '
        'S_Deposited
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 781)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grd_StockDeposit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Branch)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.Chk_Auto)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Cmb_SearchType)
        Me.Controls.Add(Me.Btn_Update)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "S_Deposited"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grd_StockDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_AllUnits As Button
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewCheckBoxColumn
    Friend WithEvents Grd_StockDeposit As DataGridView
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Branch As ComboBox
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Chk_Auto As CheckBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Cmb_SearchType As ComboBox
    Friend WithEvents Btn_Update As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dt As DateTimePicker
End Class
