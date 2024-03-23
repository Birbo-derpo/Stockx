<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashBoard
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
        Me.Btn_MainOffice = New System.Windows.Forms.Button()
        Me.Btn_Branches = New System.Windows.Forms.Button()
        Me.Btn_Customers = New System.Windows.Forms.Button()
        Me.Lbl_Main = New System.Windows.Forms.Label()
        Me.Lbl_Bajada = New System.Windows.Forms.Label()
        Me.Lbl_Tagum = New System.Windows.Forms.Label()
        Me.Lbl_Gensan = New System.Windows.Forms.Label()
        Me.Lbl_Davao = New System.Windows.Forms.Label()
        Me.Lbl_Kidapawan = New System.Windows.Forms.Label()
        Me.Lbl_Digos = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblPositionn = New System.Windows.Forms.Label()
        Me.lblgmail = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnchange = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_MainOffice
        '
        Me.Btn_MainOffice.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_MainOffice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MainOffice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_MainOffice.Location = New System.Drawing.Point(604, 277)
        Me.Btn_MainOffice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_MainOffice.Name = "Btn_MainOffice"
        Me.Btn_MainOffice.Size = New System.Drawing.Size(243, 80)
        Me.Btn_MainOffice.TabIndex = 0
        Me.Btn_MainOffice.Text = "MAIN OFFICE"
        Me.Btn_MainOffice.UseVisualStyleBackColor = False
        '
        'Btn_Branches
        '
        Me.Btn_Branches.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Branches.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Branches.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Branches.Location = New System.Drawing.Point(932, 277)
        Me.Btn_Branches.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Branches.Name = "Btn_Branches"
        Me.Btn_Branches.Size = New System.Drawing.Size(243, 80)
        Me.Btn_Branches.TabIndex = 1
        Me.Btn_Branches.Text = "BRANCHES"
        Me.Btn_Branches.UseVisualStyleBackColor = False
        '
        'Btn_Customers
        '
        Me.Btn_Customers.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Customers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Customers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Customers.Location = New System.Drawing.Point(1271, 277)
        Me.Btn_Customers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Customers.Name = "Btn_Customers"
        Me.Btn_Customers.Size = New System.Drawing.Size(243, 80)
        Me.Btn_Customers.TabIndex = 2
        Me.Btn_Customers.Text = "CUSTOMERS"
        Me.Btn_Customers.UseVisualStyleBackColor = False
        '
        'Lbl_Main
        '
        Me.Lbl_Main.AutoSize = True
        Me.Lbl_Main.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Main.Location = New System.Drawing.Point(925, 505)
        Me.Lbl_Main.Name = "Lbl_Main"
        Me.Lbl_Main.Size = New System.Drawing.Size(247, 38)
        Me.Lbl_Main.TabIndex = 5
        Me.Lbl_Main.Text = "MAIN BRANCH"
        '
        'Lbl_Bajada
        '
        Me.Lbl_Bajada.AutoSize = True
        Me.Lbl_Bajada.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bajada.Location = New System.Drawing.Point(928, 617)
        Me.Lbl_Bajada.Name = "Lbl_Bajada"
        Me.Lbl_Bajada.Size = New System.Drawing.Size(249, 38)
        Me.Lbl_Bajada.TabIndex = 6
        Me.Lbl_Bajada.Text = "Bajada Branch: "
        '
        'Lbl_Tagum
        '
        Me.Lbl_Tagum.AutoSize = True
        Me.Lbl_Tagum.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tagum.Location = New System.Drawing.Point(592, 617)
        Me.Lbl_Tagum.Name = "Lbl_Tagum"
        Me.Lbl_Tagum.Size = New System.Drawing.Size(249, 38)
        Me.Lbl_Tagum.TabIndex = 8
        Me.Lbl_Tagum.Text = "Tagum Branch: "
        '
        'Lbl_Gensan
        '
        Me.Lbl_Gensan.AutoSize = True
        Me.Lbl_Gensan.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Gensan.Location = New System.Drawing.Point(1275, 617)
        Me.Lbl_Gensan.Name = "Lbl_Gensan"
        Me.Lbl_Gensan.Size = New System.Drawing.Size(375, 38)
        Me.Lbl_Gensan.TabIndex = 9
        Me.Lbl_Gensan.Text = "General Santos Branch: "
        '
        'Lbl_Davao
        '
        Me.Lbl_Davao.AutoSize = True
        Me.Lbl_Davao.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Davao.Location = New System.Drawing.Point(592, 747)
        Me.Lbl_Davao.Name = "Lbl_Davao"
        Me.Lbl_Davao.Size = New System.Drawing.Size(243, 38)
        Me.Lbl_Davao.TabIndex = 10
        Me.Lbl_Davao.Text = "Davao Branch: "
        '
        'Lbl_Kidapawan
        '
        Me.Lbl_Kidapawan.AutoSize = True
        Me.Lbl_Kidapawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Kidapawan.Location = New System.Drawing.Point(1275, 747)
        Me.Lbl_Kidapawan.Name = "Lbl_Kidapawan"
        Me.Lbl_Kidapawan.Size = New System.Drawing.Size(318, 38)
        Me.Lbl_Kidapawan.TabIndex = 11
        Me.Lbl_Kidapawan.Text = "Kidapawan  Branch: "
        '
        'Lbl_Digos
        '
        Me.Lbl_Digos.AutoSize = True
        Me.Lbl_Digos.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Digos.Location = New System.Drawing.Point(931, 747)
        Me.Lbl_Digos.Name = "Lbl_Digos"
        Me.Lbl_Digos.Size = New System.Drawing.Size(241, 38)
        Me.Lbl_Digos.TabIndex = 12
        Me.Lbl_Digos.Text = "Digos  Branch: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stockXproj.My.Resources.Resources.Add_a_subheading__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2017, 235)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 51)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "DASHBOARD"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Firebrick
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogout.Location = New System.Drawing.Point(932, 384)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(243, 80)
        Me.btnLogout.TabIndex = 54
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblPositionn
        '
        Me.lblPositionn.AutoSize = True
        Me.lblPositionn.Location = New System.Drawing.Point(142, 537)
        Me.lblPositionn.Name = "lblPositionn"
        Me.lblPositionn.Size = New System.Drawing.Size(62, 16)
        Me.lblPositionn.TabIndex = 60
        Me.lblPositionn.Text = "Positionn"
        '
        'lblgmail
        '
        Me.lblgmail.AutoSize = True
        Me.lblgmail.Location = New System.Drawing.Point(142, 477)
        Me.lblgmail.Name = "lblgmail"
        Me.lblgmail.Size = New System.Drawing.Size(42, 16)
        Me.lblgmail.TabIndex = 59
        Me.lblgmail.Text = "Gmail"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(142, 504)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(36, 16)
        Me.lblUser.TabIndex = 58
        Me.lblUser.Text = "User"
        '
        'btnchange
        '
        Me.btnchange.BackColor = System.Drawing.Color.Firebrick
        Me.btnchange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnchange.Location = New System.Drawing.Point(1250, 384)
        Me.btnchange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(243, 80)
        Me.btnchange.TabIndex = 61
        Me.btnchange.Text = "Change Password"
        Me.btnchange.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(604, 384)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 80)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Edit Info"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 922)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.lblPositionn)
        Me.Controls.Add(Me.lblgmail)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl_Digos)
        Me.Controls.Add(Me.Lbl_Kidapawan)
        Me.Controls.Add(Me.Lbl_Davao)
        Me.Controls.Add(Me.Lbl_Gensan)
        Me.Controls.Add(Me.Lbl_Tagum)
        Me.Controls.Add(Me.Lbl_Bajada)
        Me.Controls.Add(Me.Lbl_Main)
        Me.Controls.Add(Me.Btn_Customers)
        Me.Controls.Add(Me.Btn_Branches)
        Me.Controls.Add(Me.Btn_MainOffice)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DashBoard"
        Me.Text = "DashBoard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_MainOffice As Button
    Friend WithEvents Btn_Branches As Button
    Friend WithEvents Btn_Customers As Button
    Friend WithEvents Lbl_Main As Label
    Friend WithEvents Lbl_Bajada As Label
    Friend WithEvents Lbl_Tagum As Label
    Friend WithEvents Lbl_Gensan As Label
    Friend WithEvents Lbl_Davao As Label
    Friend WithEvents Lbl_Kidapawan As Label
    Friend WithEvents Lbl_Digos As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblPositionn As Label
    Friend WithEvents lblgmail As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents btnchange As Button
    Friend WithEvents Button1 As Button
End Class
