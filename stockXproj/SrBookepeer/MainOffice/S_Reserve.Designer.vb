<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_Reserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_Reserve))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_AvStock = New System.Windows.Forms.Button()
        Me.Btn_Reserved = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_AllUnits = New System.Windows.Forms.Button()
        Me.Btn_Transit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MTN = New System.Windows.Forms.TextBox()
        Me.cmb_branch = New System.Windows.Forms.ComboBox()
        Me.Btn_Add_MT = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_CancelReserve = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grd_MotorcycleReserved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(29, 730)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 46)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "DASHBOARD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_AvStock
        '
        Me.Btn_AvStock.BackColor = System.Drawing.Color.Snow
        Me.Btn_AvStock.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_AvStock.FlatAppearance.BorderSize = 2
        Me.Btn_AvStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AvStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AvStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_AvStock.Location = New System.Drawing.Point(19, 107)
        Me.Btn_AvStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AvStock.Name = "Btn_AvStock"
        Me.Btn_AvStock.Size = New System.Drawing.Size(158, 50)
        Me.Btn_AvStock.TabIndex = 33
        Me.Btn_AvStock.Text = "AVAILABLE UNITS"
        Me.Btn_AvStock.UseVisualStyleBackColor = False
        '
        'Btn_Reserved
        '
        Me.Btn_Reserved.BackColor = System.Drawing.Color.Snow
        Me.Btn_Reserved.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Reserved.FlatAppearance.BorderSize = 2
        Me.Btn_Reserved.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Reserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reserved.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Reserved.Location = New System.Drawing.Point(19, 162)
        Me.Btn_Reserved.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Reserved.Name = "Btn_Reserved"
        Me.Btn_Reserved.Size = New System.Drawing.Size(158, 50)
        Me.Btn_Reserved.TabIndex = 32
        Me.Btn_Reserved.Text = "RESERVED UNITS"
        Me.Btn_Reserved.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.Btn_AllUnits)
        Me.GroupBox1.Controls.Add(Me.Btn_AvStock)
        Me.GroupBox1.Controls.Add(Me.Btn_Reserved)
        Me.GroupBox1.Controls.Add(Me.Btn_Transit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(-6, 253)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(185, 472)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'Btn_AllUnits
        '
        Me.Btn_AllUnits.BackColor = System.Drawing.Color.Snow
        Me.Btn_AllUnits.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_AllUnits.FlatAppearance.BorderSize = 2
        Me.Btn_AllUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AllUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_AllUnits.Location = New System.Drawing.Point(19, 54)
        Me.Btn_AllUnits.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AllUnits.Name = "Btn_AllUnits"
        Me.Btn_AllUnits.Size = New System.Drawing.Size(158, 50)
        Me.Btn_AllUnits.TabIndex = 97
        Me.Btn_AllUnits.Text = "ALL UNITS"
        Me.Btn_AllUnits.UseVisualStyleBackColor = False
        '
        'Btn_Transit
        '
        Me.Btn_Transit.BackColor = System.Drawing.Color.Snow
        Me.Btn_Transit.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Transit.FlatAppearance.BorderSize = 2
        Me.Btn_Transit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Transit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Transit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Transit.Location = New System.Drawing.Point(19, 216)
        Me.Btn_Transit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Transit.Name = "Btn_Transit"
        Me.Btn_Transit.Size = New System.Drawing.Size(158, 50)
        Me.Btn_Transit.TabIndex = 34
        Me.Btn_Transit.Text = "TRANSIT UNITS"
        Me.Btn_Transit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 22)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "MERCHANDISE TRANSFER NO." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_MTN
        '
        Me.txt_MTN.BackColor = System.Drawing.SystemColors.Window
        Me.txt_MTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MTN.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MTN.Location = New System.Drawing.Point(472, 171)
        Me.txt_MTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_MTN.Name = "txt_MTN"
        Me.txt_MTN.Size = New System.Drawing.Size(396, 29)
        Me.txt_MTN.TabIndex = 52
        '
        'cmb_branch
        '
        Me.cmb_branch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_branch.FormattingEnabled = True
        Me.cmb_branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.Location = New System.Drawing.Point(1179, 207)
        Me.cmb_branch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_branch.Name = "cmb_branch"
        Me.cmb_branch.Size = New System.Drawing.Size(278, 26)
        Me.cmb_branch.TabIndex = 51
        '
        'Btn_Add_MT
        '
        Me.Btn_Add_MT.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Add_MT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add_MT.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_MT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Add_MT.Location = New System.Drawing.Point(184, 730)
        Me.Btn_Add_MT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Add_MT.Name = "Btn_Add_MT"
        Me.Btn_Add_MT.Size = New System.Drawing.Size(119, 46)
        Me.Btn_Add_MT.TabIndex = 50
        Me.Btn_Add_MT.Text = "ADD MT NO." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btn_Add_MT.UseVisualStyleBackColor = False
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
        Me.Grd_MotorcycleReserved.Location = New System.Drawing.Point(184, 253)
        Me.Grd_MotorcycleReserved.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Grd_MotorcycleReserved.Name = "Grd_MotorcycleReserved"
        Me.Grd_MotorcycleReserved.RowHeadersWidth = 51
        Me.Grd_MotorcycleReserved.RowTemplate.Height = 24
        Me.Grd_MotorcycleReserved.Size = New System.Drawing.Size(1264, 472)
        Me.Grd_MotorcycleReserved.TabIndex = 49
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "FOR DELIVERY"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "BRANCH"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "INVOICE NUMBER"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DATE TIME"
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
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "COLOR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "PRICE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "ENGINE NUMBER"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "FRAME NUMBER"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1084, 210)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 22)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "BRANCH:"
        '
        'Btn_CancelReserve
        '
        Me.Btn_CancelReserve.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_CancelReserve.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelReserve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_CancelReserve.Location = New System.Drawing.Point(1332, 728)
        Me.Btn_CancelReserve.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_CancelReserve.Name = "Btn_CancelReserve"
        Me.Btn_CancelReserve.Size = New System.Drawing.Size(119, 46)
        Me.Btn_CancelReserve.TabIndex = 47
        Me.Btn_CancelReserve.Text = "RESERVE"
        Me.Btn_CancelReserve.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(10, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 62)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "RESERVED" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   UNITS"
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(1179, 177)
        Me.dt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(278, 23)
        Me.dt.TabIndex = 94
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 155)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(182, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1334, 154)
        Me.PictureBox2.TabIndex = 96
        Me.PictureBox2.TabStop = False
        '
        'S_Reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1443, 845)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_MTN)
        Me.Controls.Add(Me.cmb_branch)
        Me.Controls.Add(Me.Btn_Add_MT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_CancelReserve)
        Me.Controls.Add(Me.Grd_MotorcycleReserved)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "S_Reserve"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grd_MotorcycleReserved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_AvStock As Button
    Friend WithEvents Btn_Reserved As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Transit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MTN As TextBox
    Friend WithEvents cmb_branch As ComboBox
    Friend WithEvents Btn_Add_MT As Button
    Friend WithEvents Grd_MotorcycleReserved As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_CancelReserve As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dt As DateTimePicker
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_AllUnits As Button
End Class
