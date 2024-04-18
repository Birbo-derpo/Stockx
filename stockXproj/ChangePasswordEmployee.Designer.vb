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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcorrectconfirm
        '
        Me.lblcorrectconfirm.AutoSize = True
        Me.lblcorrectconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrectconfirm.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblcorrectconfirm.Location = New System.Drawing.Point(538, 508)
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
        Me.lblcorrect.Location = New System.Drawing.Point(538, 430)
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
        Me.Label5.Location = New System.Drawing.Point(239, 443)
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
        Me.Label4.Location = New System.Drawing.Point(239, 530)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Password dont match to newPassword"
        Me.Label4.Visible = False
        '
        'txtoldpass
        '
        Me.txtoldpass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldpass.Location = New System.Drawing.Point(209, 340)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.Size = New System.Drawing.Size(323, 30)
        Me.txtoldpass.TabIndex = 16
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Firebrick
        Me.btnChange.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnChange.Location = New System.Drawing.Point(322, 558)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(115, 41)
        Me.btnChange.TabIndex = 15
        Me.btnChange.Text = "DONE"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Confirm Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "New Password"
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpass.Location = New System.Drawing.Point(209, 497)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.Size = New System.Drawing.Size(323, 30)
        Me.txtconfirmpass.TabIndex = 12
        '
        'txtnewpass
        '
        Me.txtnewpass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpass.Location = New System.Drawing.Point(209, 410)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.Size = New System.Drawing.Size(323, 30)
        Me.txtnewpass.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 27)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Old Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stockXproj.My.Resources.Resources.Add_a_subheading__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(777, 177)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.stockXproj.My.Resources.Resources.HONDA_COLOR
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 176)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(777, 58)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Firebrick
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(227, 189)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(323, 32)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "MANAGE PASSWORD"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(202, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(369, 40)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "CHANGE PASSWORD"
        '
        'ChangePasswordEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(773, 626)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
