<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginSrBookeeper
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
        Me.lblForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Pass_Field = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Email_Field = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.AutoSize = True
        Me.lblForgotPassword.Location = New System.Drawing.Point(313, 535)
        Me.lblForgotPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForgotPassword.Name = "lblForgotPassword"
        Me.lblForgotPassword.Size = New System.Drawing.Size(112, 16)
        Me.lblForgotPassword.TabIndex = 17
        Me.lblForgotPassword.TabStop = True
        Me.lblForgotPassword.Text = "Forgot Password."
        '
        'Btn_Login
        '
        Me.Btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Login.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.Location = New System.Drawing.Point(227, 481)
        Me.Btn_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(135, 41)
        Me.Btn_Login.TabIndex = 14
        Me.Btn_Login.Text = "Log-in"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.Location = New System.Drawing.Point(370, 481)
        Me.Btn_Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(135, 41)
        Me.Btn_Cancel.TabIndex = 15
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'Pass_Field
        '
        Me.Pass_Field.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pass_Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pass_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_Field.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Pass_Field.Location = New System.Drawing.Point(227, 437)
        Me.Pass_Field.Margin = New System.Windows.Forms.Padding(4)
        Me.Pass_Field.Name = "Pass_Field"
        Me.Pass_Field.Size = New System.Drawing.Size(278, 30)
        Me.Pass_Field.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 406)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 27)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 323)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 27)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Email"
        '
        'Email_Field
        '
        Me.Email_Field.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Email_Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Email_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Field.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Email_Field.Location = New System.Drawing.Point(227, 354)
        Me.Email_Field.Margin = New System.Windows.Forms.Padding(4)
        Me.Email_Field.Name = "Email_Field"
        Me.Email_Field.Size = New System.Drawing.Size(278, 30)
        Me.Email_Field.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 28)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "SENIOR BOOKKEEPER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 237)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 41)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "LOG IN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stockXproj.My.Resources.Resources.Add_a_subheading__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(777, 177)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'LoginSrBookeeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(773, 626)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblForgotPassword)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Pass_Field)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Email_Field)
        Me.Name = "LoginSrBookeeper"
        Me.Text = "LoginSrBookeeper"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblForgotPassword As LinkLabel
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Pass_Field As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Email_Field As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
