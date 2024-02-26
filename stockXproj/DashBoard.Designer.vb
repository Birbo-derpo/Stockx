<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblBajada = New System.Windows.Forms.Label()
        Me.lblTagum = New System.Windows.Forms.Label()
        Me.lblGensan = New System.Windows.Forms.Label()
        Me.lblDavao = New System.Windows.Forms.Label()
        Me.lblKidapawan = New System.Windows.Forms.Label()
        Me.lblDigos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 47)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "MAIN OFFICE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(505, 47)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 55)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "BRANCHES"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(814, 47)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 55)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CUSTOMERS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(189, 175)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(84, 16)
        Me.lblMain.TabIndex = 5
        Me.lblMain.Text = "Main Branch:"
        '
        'lblBajada
        '
        Me.lblBajada.AutoSize = True
        Me.lblBajada.Location = New System.Drawing.Point(189, 224)
        Me.lblBajada.Name = "lblBajada"
        Me.lblBajada.Size = New System.Drawing.Size(99, 16)
        Me.lblBajada.TabIndex = 6
        Me.lblBajada.Text = "Bajada Branch:"
        '
        'lblTagum
        '
        Me.lblTagum.AutoSize = True
        Me.lblTagum.Location = New System.Drawing.Point(189, 274)
        Me.lblTagum.Name = "lblTagum"
        Me.lblTagum.Size = New System.Drawing.Size(98, 16)
        Me.lblTagum.TabIndex = 8
        Me.lblTagum.Text = "Tagum Branch:"
        '
        'lblGensan
        '
        Me.lblGensan.AutoSize = True
        Me.lblGensan.Location = New System.Drawing.Point(184, 359)
        Me.lblGensan.Name = "lblGensan"
        Me.lblGensan.Size = New System.Drawing.Size(148, 16)
        Me.lblGensan.TabIndex = 9
        Me.lblGensan.Text = "General Santos Branch:"
        '
        'lblDavao
        '
        Me.lblDavao.AutoSize = True
        Me.lblDavao.Location = New System.Drawing.Point(187, 316)
        Me.lblDavao.Name = "lblDavao"
        Me.lblDavao.Size = New System.Drawing.Size(96, 16)
        Me.lblDavao.TabIndex = 10
        Me.lblDavao.Text = "Davao Branch:"
        '
        'lblKidapawan
        '
        Me.lblKidapawan.AutoSize = True
        Me.lblKidapawan.Location = New System.Drawing.Point(189, 398)
        Me.lblKidapawan.Name = "lblKidapawan"
        Me.lblKidapawan.Size = New System.Drawing.Size(125, 16)
        Me.lblKidapawan.TabIndex = 11
        Me.lblKidapawan.Text = "Kidapawan  Branch:"
        '
        'lblDigos
        '
        Me.lblDigos.AutoSize = True
        Me.lblDigos.Location = New System.Drawing.Point(194, 437)
        Me.lblDigos.Name = "lblDigos"
        Me.lblDigos.Size = New System.Drawing.Size(94, 16)
        Me.lblDigos.TabIndex = 12
        Me.lblDigos.Text = "Digos  Branch:"
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 554)
        Me.Controls.Add(Me.lblDigos)
        Me.Controls.Add(Me.lblKidapawan)
        Me.Controls.Add(Me.lblDavao)
        Me.Controls.Add(Me.lblGensan)
        Me.Controls.Add(Me.lblTagum)
        Me.Controls.Add(Me.lblBajada)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DashBoard"
        Me.Text = "DashBoard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblMain As Label
    Friend WithEvents lblBajada As Label
    Friend WithEvents lblTagum As Label
    Friend WithEvents lblGensan As Label
    Friend WithEvents lblDavao As Label
    Friend WithEvents lblKidapawan As Label
    Friend WithEvents lblDigos As Label
End Class
