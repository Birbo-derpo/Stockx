<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePasswordEmployee
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
        Me.lblcorrectconfirm = New System.Windows.Forms.Label()
        Me.lblcorrect = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtoldpass = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtconfirmpass = New System.Windows.Forms.TextBox()
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblcorrectconfirm
        '
        Me.lblcorrectconfirm.AutoSize = True
        Me.lblcorrectconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrectconfirm.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblcorrectconfirm.Location = New System.Drawing.Point(752, 207)
        Me.lblcorrectconfirm.Name = "lblcorrectconfirm"
        Me.lblcorrectconfirm.Size = New System.Drawing.Size(32, 42)
        Me.lblcorrectconfirm.TabIndex = 21
        Me.lblcorrectconfirm.Text = "*"
        Me.lblcorrectconfirm.Visible = False
        '
        'lblcorrect
        '
        Me.lblcorrect.AutoSize = True
        Me.lblcorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrect.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblcorrect.Location = New System.Drawing.Point(752, 147)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(32, 42)
        Me.lblcorrect.TabIndex = 20
        Me.lblcorrect.Text = "*"
        Me.lblcorrect.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(510, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Password must contain number and letters"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(510, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Password dont match to newPassword"
        Me.Label4.Visible = False
        '
        'txtoldpass
        '
        Me.txtoldpass.Location = New System.Drawing.Point(513, 101)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.Size = New System.Drawing.Size(233, 22)
        Me.txtoldpass.TabIndex = 16
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(538, 266)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 15
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(363, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Confirm Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Enter New Password"
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Location = New System.Drawing.Point(513, 204)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.Size = New System.Drawing.Size(233, 22)
        Me.txtconfirmpass.TabIndex = 12
        '
        'txtnewpass
        '
        Me.txtnewpass.Location = New System.Drawing.Point(513, 148)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.Size = New System.Drawing.Size(233, 22)
        Me.txtnewpass.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Enter Old Password"
        '
        'ChangePasswordEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 497)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblcorrectconfirm)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtoldpass)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.txtnewpass)
        Me.Name = "ChangePasswordEmployee"
        Me.Text = "ChangePasswordEmployee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcorrectconfirm As Label
    Friend WithEvents lblcorrect As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtoldpass As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtconfirmpass As TextBox
    Friend WithEvents txtnewpass As TextBox
    Friend WithEvents Label3 As Label
End Class
