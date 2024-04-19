<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change
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
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.txtconfirmpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.txtgmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblcorrect = New System.Windows.Forms.Label()
        Me.lblcorrectconfirm = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnewpass
        '
        Me.txtnewpass.Location = New System.Drawing.Point(308, 106)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.Size = New System.Drawing.Size(233, 22)
        Me.txtnewpass.TabIndex = 0
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Location = New System.Drawing.Point(308, 162)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.Size = New System.Drawing.Size(233, 22)
        Me.txtconfirmpass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Confirm Password"
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(333, 224)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'txtgmail
        '
        Me.txtgmail.Location = New System.Drawing.Point(308, 59)
        Me.txtgmail.Name = "txtgmail"
        Me.txtgmail.Size = New System.Drawing.Size(233, 22)
        Me.txtgmail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "User Gmail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(305, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password dont match to newPassword"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(305, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password must contain number and letters"
        Me.Label5.Visible = False
        '
        'lblcorrect
        '
        Me.lblcorrect.AutoSize = True
        Me.lblcorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrect.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblcorrect.Location = New System.Drawing.Point(547, 105)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(32, 42)
        Me.lblcorrect.TabIndex = 9
        Me.lblcorrect.Text = "*"
        Me.lblcorrect.Visible = False
        '
        'lblcorrectconfirm
        '
        Me.lblcorrectconfirm.AutoSize = True
        Me.lblcorrectconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrectconfirm.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblcorrectconfirm.Location = New System.Drawing.Point(547, 165)
        Me.lblcorrectconfirm.Name = "lblcorrectconfirm"
        Me.lblcorrectconfirm.Size = New System.Drawing.Size(32, 42)
        Me.lblcorrectconfirm.TabIndex = 10
        Me.lblcorrectconfirm.Text = "*"
        Me.lblcorrectconfirm.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 563)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblcorrectconfirm)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtgmail)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.txtnewpass)
        Me.Name = "change"
        Me.Text = "change_Pass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnewpass As TextBox
    Friend WithEvents txtconfirmpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents txtgmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcorrect As Label
    Friend WithEvents lblcorrectconfirm As Label
    Friend WithEvents Button1 As Button
End Class
