<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_Transit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_Transit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_AvStock = New System.Windows.Forms.Button()
        Me.Btn_Reserved = New System.Windows.Forms.Button()
        Me.Btn_Transit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmb_branch = New System.Windows.Forms.ComboBox()
        Me.Btn_Transfer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Grd_Motorcycle = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_ReturnUnit = New System.Windows.Forms.Button()
        Me.Btn_CancelTransit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grd_Motorcycle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 22)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "SORT BY BRANCH:"
        '
        'Btn_AvStock
        '
        Me.Btn_AvStock.BackColor = System.Drawing.Color.Snow
        Me.Btn_AvStock.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_AvStock.FlatAppearance.BorderSize = 2
        Me.Btn_AvStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AvStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AvStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_AvStock.Location = New System.Drawing.Point(14, 143)
        Me.Btn_AvStock.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Btn_Reserved.Location = New System.Drawing.Point(14, 197)
        Me.Btn_Reserved.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Reserved.Name = "Btn_Reserved"
        Me.Btn_Reserved.Size = New System.Drawing.Size(158, 50)
        Me.Btn_Reserved.TabIndex = 32
        Me.Btn_Reserved.Text = "RESERVED UNITS"
        Me.Btn_Reserved.UseVisualStyleBackColor = False
        '
        'Btn_Transit
        '
        Me.Btn_Transit.BackColor = System.Drawing.Color.Snow
        Me.Btn_Transit.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Transit.FlatAppearance.BorderSize = 2
        Me.Btn_Transit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Transit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Transit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Transit.Location = New System.Drawing.Point(14, 252)
        Me.Btn_Transit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Transit.Name = "Btn_Transit"
        Me.Btn_Transit.Size = New System.Drawing.Size(158, 50)
        Me.Btn_Transit.TabIndex = 34
        Me.Btn_Transit.Text = "TRANSIT UNITS"
        Me.Btn_Transit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Btn_AvStock)
        Me.GroupBox1.Controls.Add(Me.Btn_Reserved)
        Me.GroupBox1.Controls.Add(Me.Btn_Transit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 254)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(185, 472)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Snow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(14, 89)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 50)
        Me.Button2.TabIndex = 96
        Me.Button2.Text = "ALL UNITS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmb_branch
        '
        Me.cmb_branch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_branch.FormattingEnabled = True
        Me.cmb_branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.Location = New System.Drawing.Point(357, 176)
        Me.cmb_branch.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_branch.Name = "cmb_branch"
        Me.cmb_branch.Size = New System.Drawing.Size(396, 26)
        Me.cmb_branch.TabIndex = 56
        '
        'Btn_Transfer
        '
        Me.Btn_Transfer.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Transfer.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Transfer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Transfer.Location = New System.Drawing.Point(182, 730)
        Me.Btn_Transfer.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Transfer.Name = "Btn_Transfer"
        Me.Btn_Transfer.Size = New System.Drawing.Size(119, 46)
        Me.Btn_Transfer.TabIndex = 55
        Me.Btn_Transfer.Text = "CONFRIM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TRANSIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btn_Transfer.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(29, 730)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 46)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "DASHBOARD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Grd_Motorcycle
        '
        Me.Grd_Motorcycle.AllowUserToAddRows = False
        Me.Grd_Motorcycle.AllowUserToDeleteRows = False
        Me.Grd_Motorcycle.AllowUserToResizeColumns = False
        Me.Grd_Motorcycle.AllowUserToResizeRows = False
        Me.Grd_Motorcycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_Motorcycle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column10, Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Grd_Motorcycle.Location = New System.Drawing.Point(184, 254)
        Me.Grd_Motorcycle.Margin = New System.Windows.Forms.Padding(2)
        Me.Grd_Motorcycle.Name = "Grd_Motorcycle"
        Me.Grd_Motorcycle.RowHeadersWidth = 51
        Me.Grd_Motorcycle.RowTemplate.Height = 24
        Me.Grd_Motorcycle.Size = New System.Drawing.Size(1264, 472)
        Me.Grd_Motorcycle.TabIndex = 54
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Check_state"
        Me.Column8.HeaderText = "SELECT"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "FOR BRANCH"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 180
        '
        'Column9
        '
        Me.Column9.HeaderText = "MT NO."
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 190
        '
        'Column1
        '
        Me.Column1.HeaderText = "INVOICE NO."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 190
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATE TIME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "MODEL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 170
        '
        'Column4
        '
        Me.Column4.HeaderText = "COLOR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "PRICE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "ENGINE NO."
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 190
        '
        'Column7
        '
        Me.Column7.HeaderText = "FRAME NO."
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(23, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 62)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "TRANSIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   LISTS"
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(1179, 178)
        Me.dt.Margin = New System.Windows.Forms.Padding(2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(270, 23)
        Me.dt.TabIndex = 93
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(184, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1341, 154)
        Me.PictureBox2.TabIndex = 94
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 157)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Btn_ReturnUnit
        '
        Me.Btn_ReturnUnit.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_ReturnUnit.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ReturnUnit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_ReturnUnit.Location = New System.Drawing.Point(1207, 730)
        Me.Btn_ReturnUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_ReturnUnit.Name = "Btn_ReturnUnit"
        Me.Btn_ReturnUnit.Size = New System.Drawing.Size(119, 46)
        Me.Btn_ReturnUnit.TabIndex = 97
        Me.Btn_ReturnUnit.Text = "RETURN"
        Me.Btn_ReturnUnit.UseVisualStyleBackColor = False
        '
        'Btn_CancelTransit
        '
        Me.Btn_CancelTransit.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_CancelTransit.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelTransit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_CancelTransit.Location = New System.Drawing.Point(1330, 730)
        Me.Btn_CancelTransit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_CancelTransit.Name = "Btn_CancelTransit"
        Me.Btn_CancelTransit.Size = New System.Drawing.Size(119, 46)
        Me.Btn_CancelTransit.TabIndex = 96
        Me.Btn_CancelTransit.Text = "CANCEL TRANSIT"
        Me.Btn_CancelTransit.UseVisualStyleBackColor = False
        '
        'S_Transit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1443, 828)
        Me.Controls.Add(Me.Btn_ReturnUnit)
        Me.Controls.Add(Me.Btn_CancelTransit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmb_branch)
        Me.Controls.Add(Me.Btn_Transfer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grd_Motorcycle)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "S_Transit"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grd_Motorcycle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_AvStock As Button
    Friend WithEvents Btn_Reserved As Button
    Friend WithEvents Btn_Transit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_branch As ComboBox
    Friend WithEvents Btn_Transfer As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Grd_Motorcycle As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Column8 As DataGridViewCheckBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_ReturnUnit As Button
    Friend WithEvents Btn_CancelTransit As Button
End Class
