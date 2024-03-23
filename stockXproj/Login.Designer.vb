<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Email_Field = New System.Windows.Forms.TextBox()
        Me.Pass_Field = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.lblForgotPassword = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Email_Field
        '
        Me.Email_Field.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Email_Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Email_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Field.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Email_Field.Location = New System.Drawing.Point(170, 288)
        Me.Email_Field.Name = "Email_Field"
        Me.Email_Field.Size = New System.Drawing.Size(215, 26)
        Me.Email_Field.TabIndex = 0
        '
        'Pass_Field
        '
        Me.Pass_Field.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pass_Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pass_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_Field.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Pass_Field.Location = New System.Drawing.Point(170, 355)
        Me.Pass_Field.Name = "Pass_Field"
        Me.Pass_Field.Size = New System.Drawing.Size(215, 26)
        Me.Pass_Field.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stockXproj.My.Resources.Resources.Add_a_subheading__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(583, 144)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "LOG IN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Login
        '
        Me.Btn_Login.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.Location = New System.Drawing.Point(170, 391)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(101, 33)
        Me.Btn_Login.TabIndex = 4
        Me.Btn_Login.Text = "Log-in"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.Location = New System.Drawing.Point(284, 391)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(101, 33)
        Me.Btn_Cancel.TabIndex = 5
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.AutoSize = True
        Me.lblForgotPassword.Location = New System.Drawing.Point(236, 436)
        Me.lblForgotPassword.Name = "lblForgotPassword"
        Me.lblForgotPassword.Size = New System.Drawing.Size(92, 13)
        Me.lblForgotPassword.TabIndex = 9
        Me.lblForgotPassword.TabStop = True
        Me.lblForgotPassword.Text = "Forgot Password?"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(580, 509)
        Me.Controls.Add(Me.lblForgotPassword)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pass_Field)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Email_Field)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Email_Field As TextBox
    Friend WithEvents Pass_Field As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents lblForgotPassword As LinkLabel
End Class
