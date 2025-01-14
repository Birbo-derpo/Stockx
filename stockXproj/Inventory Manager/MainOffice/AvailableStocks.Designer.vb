<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AvailableStocks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvailableStocks))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_AvStock = New System.Windows.Forms.Button()
        Me.Btn_Reserved = New System.Windows.Forms.Button()
        Me.Btn_Transit = New System.Windows.Forms.Button()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chk_Auto = New System.Windows.Forms.CheckBox()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Grd_Motorcycle = New System.Windows.Forms.DataGridView()
        Me.Btn_ReservationPage = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grd_Motorcycle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Snow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(19, 176)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 62)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "AVAILABLE UNITS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Btn_AvStock)
        Me.GroupBox1.Controls.Add(Me.Btn_Reserved)
        Me.GroupBox1.Controls.Add(Me.Btn_Transit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 313)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(247, 581)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'Btn_AvStock
        '
        Me.Btn_AvStock.BackColor = System.Drawing.Color.Snow
        Me.Btn_AvStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AvStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AvStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_AvStock.Location = New System.Drawing.Point(19, 110)
        Me.Btn_AvStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AvStock.Name = "Btn_AvStock"
        Me.Btn_AvStock.Size = New System.Drawing.Size(211, 62)
        Me.Btn_AvStock.TabIndex = 33
        Me.Btn_AvStock.Text = "ALL UNITS"
        Me.Btn_AvStock.UseVisualStyleBackColor = False
        '
        'Btn_Reserved
        '
        Me.Btn_Reserved.BackColor = System.Drawing.Color.Snow
        Me.Btn_Reserved.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Reserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reserved.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Reserved.Location = New System.Drawing.Point(19, 242)
        Me.Btn_Reserved.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Reserved.Name = "Btn_Reserved"
        Me.Btn_Reserved.Size = New System.Drawing.Size(211, 62)
        Me.Btn_Reserved.TabIndex = 32
        Me.Btn_Reserved.Text = "RESERVED UNITS"
        Me.Btn_Reserved.UseVisualStyleBackColor = False
        '
        'Btn_Transit
        '
        Me.Btn_Transit.BackColor = System.Drawing.Color.Snow
        Me.Btn_Transit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Transit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Transit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Transit.Location = New System.Drawing.Point(19, 310)
        Me.Btn_Transit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Transit.Name = "Btn_Transit"
        Me.Btn_Transit.Size = New System.Drawing.Size(211, 62)
        Me.Btn_Transit.TabIndex = 34
        Me.Btn_Transit.Text = "TRANSIT UNITS"
        Me.Btn_Transit.UseVisualStyleBackColor = False
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Dashboard.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Dashboard.Location = New System.Drawing.Point(39, 898)
        Me.Btn_Dashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(159, 57)
        Me.Btn_Dashboard.TabIndex = 66
        Me.Btn_Dashboard.Text = "DASHBOARD"
        Me.Btn_Dashboard.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 80)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "AVAILABLE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    UNITS"
        '
        'Chk_Auto
        '
        Me.Chk_Auto.AutoSize = True
        Me.Chk_Auto.Font = New System.Drawing.Font("Bodoni MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Auto.Location = New System.Drawing.Point(637, 268)
        Me.Chk_Auto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chk_Auto.Name = "Chk_Auto"
        Me.Chk_Auto.Size = New System.Drawing.Size(135, 25)
        Me.Chk_Auto.TabIndex = 63
        Me.Chk_Auto.Text = "Auto Complete"
        Me.Chk_Auto.UseVisualStyleBackColor = True
        '
        'Txt_Search
        '
        Me.Txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Search.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(245, 220)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(527, 34)
        Me.Txt_Search.TabIndex = 61
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(245, 263)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(376, 31)
        Me.cmbSearchType.TabIndex = 60
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "BRANCH"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "FRAME NO"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "ENGINE NO."
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "PRICE UNITS"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "COLOR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MODEL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DATE TIME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "INVOICE NO."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(1572, 219)
        Me.dt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(359, 27)
        Me.dt.TabIndex = 70
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Search.Location = New System.Drawing.Point(778, 211)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(116, 46)
        Me.Btn_Search.TabIndex = 62
        Me.Btn_Search.Text = "SEARCH"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Book Antiqua", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(1572, 255)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(289, 40)
        Me.lblTotal.TabIndex = 56
        Me.lblTotal.Text = "TOTAL STOCKS:"
        '
        'Grd_Motorcycle
        '
        Me.Grd_Motorcycle.AllowUserToAddRows = False
        Me.Grd_Motorcycle.AllowUserToDeleteRows = False
        Me.Grd_Motorcycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_Motorcycle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.Grd_Motorcycle.Location = New System.Drawing.Point(245, 313)
        Me.Grd_Motorcycle.Margin = New System.Windows.Forms.Padding(0)
        Me.Grd_Motorcycle.Name = "Grd_Motorcycle"
        Me.Grd_Motorcycle.ReadOnly = True
        Me.Grd_Motorcycle.RowHeadersWidth = 51
        Me.Grd_Motorcycle.RowTemplate.Height = 24
        Me.Grd_Motorcycle.Size = New System.Drawing.Size(1713, 581)
        Me.Grd_Motorcycle.TabIndex = 65
        '
        'Btn_ReservationPage
        '
        Me.Btn_ReservationPage.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_ReservationPage.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ReservationPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_ReservationPage.Location = New System.Drawing.Point(1799, 896)
        Me.Btn_ReservationPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_ReservationPage.Name = "Btn_ReservationPage"
        Me.Btn_ReservationPage.Size = New System.Drawing.Size(159, 57)
        Me.Btn_ReservationPage.TabIndex = 71
        Me.Btn_ReservationPage.Text = "RESERVE"
        Me.Btn_ReservationPage.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(245, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1788, 190)
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 190)
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Firebrick
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEdit.Location = New System.Drawing.Point(410, 898)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(159, 57)
        Me.btnEdit.TabIndex = 89
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Firebrick
        Me.btndelete.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btndelete.Location = New System.Drawing.Point(575, 898)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(159, 57)
        Me.btndelete.TabIndex = 88
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(245, 898)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(159, 57)
        Me.btnAdd.TabIndex = 87
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(141, 0)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(100, 20)
        Me.CheckBox2.TabIndex = 90
        Me.CheckBox2.Text = "CHECK ALL"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'AvailableStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btn_ReservationPage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk_Auto)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Grd_Motorcycle)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AvailableStocks"
        Me.Text = "AvailableStocks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grd_Motorcycle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_AvStock As Button
    Friend WithEvents Btn_Reserved As Button
    Friend WithEvents Btn_Transit As Button
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Chk_Auto As CheckBox
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Btn_Search As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Grd_Motorcycle As DataGridView
    Friend WithEvents Btn_ReservationPage As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents CheckBox2 As CheckBox
End Class
