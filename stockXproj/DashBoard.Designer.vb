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
        Me.Lbl_Main.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Main.Location = New System.Drawing.Point(925, 505)
        Me.Lbl_Main.Name = "Lbl_Main"
        Me.Lbl_Main.Size = New System.Drawing.Size(264, 39)
        Me.Lbl_Main.TabIndex = 5
        Me.Lbl_Main.Text = "MAIN BRANCH"
        '
        'Lbl_Bajada
        '
        Me.Lbl_Bajada.AutoSize = True
        Me.Lbl_Bajada.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bajada.Location = New System.Drawing.Point(928, 617)
        Me.Lbl_Bajada.Name = "Lbl_Bajada"
        Me.Lbl_Bajada.Size = New System.Drawing.Size(281, 39)
        Me.Lbl_Bajada.TabIndex = 6
        Me.Lbl_Bajada.Text = "Bajada Branch: "
        '
        'Lbl_Tagum
        '
        Me.Lbl_Tagum.AutoSize = True
        Me.Lbl_Tagum.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tagum.Location = New System.Drawing.Point(592, 617)
        Me.Lbl_Tagum.Name = "Lbl_Tagum"
        Me.Lbl_Tagum.Size = New System.Drawing.Size(280, 39)
        Me.Lbl_Tagum.TabIndex = 8
        Me.Lbl_Tagum.Text = "Tagum Branch: "
        '
        'Lbl_Gensan
        '
        Me.Lbl_Gensan.AutoSize = True
        Me.Lbl_Gensan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Gensan.Location = New System.Drawing.Point(1274, 617)
        Me.Lbl_Gensan.Name = "Lbl_Gensan"
        Me.Lbl_Gensan.Size = New System.Drawing.Size(423, 39)
        Me.Lbl_Gensan.TabIndex = 9
        Me.Lbl_Gensan.Text = "General Santos Branch: "
        '
        'Lbl_Davao
        '
        Me.Lbl_Davao.AutoSize = True
        Me.Lbl_Davao.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Davao.Location = New System.Drawing.Point(592, 747)
        Me.Lbl_Davao.Name = "Lbl_Davao"
        Me.Lbl_Davao.Size = New System.Drawing.Size(271, 39)
        Me.Lbl_Davao.TabIndex = 10
        Me.Lbl_Davao.Text = "Davao Branch: "
        '
        'Lbl_Kidapawan
        '
        Me.Lbl_Kidapawan.AutoSize = True
        Me.Lbl_Kidapawan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Kidapawan.Location = New System.Drawing.Point(1274, 747)
        Me.Lbl_Kidapawan.Name = "Lbl_Kidapawan"
        Me.Lbl_Kidapawan.Size = New System.Drawing.Size(361, 39)
        Me.Lbl_Kidapawan.TabIndex = 11
        Me.Lbl_Kidapawan.Text = "Kidapawan  Branch: "
        '
        'Lbl_Digos
        '
        Me.Lbl_Digos.AutoSize = True
        Me.Lbl_Digos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Digos.Location = New System.Drawing.Point(930, 747)
        Me.Lbl_Digos.Name = "Lbl_Digos"
        Me.Lbl_Digos.Size = New System.Drawing.Size(270, 39)
        Me.Lbl_Digos.TabIndex = 12
        Me.Lbl_Digos.Text = "Digos  Branch: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stockXproj.My.Resources.Resources.Add_a_subheading__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2017, 236)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 52)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "DASHBOARD"
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 922)
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
End Class
