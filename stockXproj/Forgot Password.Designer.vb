<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgot_Password
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
        Me.txtGmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.btnSendCode = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtGmail
        '
        Me.txtGmail.Location = New System.Drawing.Point(234, 103)
        Me.txtGmail.Name = "txtGmail"
        Me.txtGmail.Size = New System.Drawing.Size(200, 22)
        Me.txtGmail.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Gmail"
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(234, 199)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(200, 22)
        Me.txtcode.TabIndex = 2
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(166, 205)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(40, 16)
        Me.lblCode.TabIndex = 3
        Me.lblCode.Text = "Code"
        '
        'btnSendCode
        '
        Me.btnSendCode.Location = New System.Drawing.Point(440, 102)
        Me.btnSendCode.Name = "btnSendCode"
        Me.btnSendCode.Size = New System.Drawing.Size(108, 23)
        Me.btnSendCode.TabIndex = 4
        Me.btnSendCode.Text = "Send COde"
        Me.btnSendCode.UseVisualStyleBackColor = True
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(281, 241)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(108, 23)
        Me.btnVerify.TabIndex = 5
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(234, 144)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 22)
        Me.txtPassword.TabIndex = 6
        '
        'Forgot_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 491)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnSendCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGmail)
        Me.Name = "Forgot_Password"
        Me.Text = "Forgot_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcode As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents btnSendCode As Button
    Friend WithEvents btnVerify As Button
    Friend WithEvents txtPassword As TextBox
End Class
