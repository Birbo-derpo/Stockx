<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMotorcycle
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFrameNumber = New System.Windows.Forms.TextBox()
        Me.txtEngineNumber = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(450, 388)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 50
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "FRAME NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ENGINE NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "MOTORCYCLE PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "MOTORCYCLE COLOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "DATE&TIME"
        '
        'dt
        '
        Me.dt.Location = New System.Drawing.Point(325, 85)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(200, 22)
        Me.dt.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "MOTORCYCLE MODEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "INVOICE NUMBER"
        '
        'txtFrameNumber
        '
        Me.txtFrameNumber.Location = New System.Drawing.Point(325, 303)
        Me.txtFrameNumber.Name = "txtFrameNumber"
        Me.txtFrameNumber.Size = New System.Drawing.Size(318, 22)
        Me.txtFrameNumber.TabIndex = 41
        '
        'txtEngineNumber
        '
        Me.txtEngineNumber.Location = New System.Drawing.Point(325, 262)
        Me.txtEngineNumber.Name = "txtEngineNumber"
        Me.txtEngineNumber.Size = New System.Drawing.Size(318, 22)
        Me.txtEngineNumber.TabIndex = 40
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(325, 215)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(318, 22)
        Me.txtPrice.TabIndex = 39
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(325, 170)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(318, 22)
        Me.txtColor.TabIndex = 38
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(325, 128)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(318, 22)
        Me.txtModel.TabIndex = 37
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(325, 40)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(318, 22)
        Me.txtInvoiceNumber.TabIndex = 36
        '
        'addMotorcycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 450)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFrameNumber)
        Me.Controls.Add(Me.txtEngineNumber)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Name = "addMotorcycle"
        Me.Text = "addMotorcycle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFrameNumber As TextBox
    Friend WithEvents txtEngineNumber As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtInvoiceNumber As TextBox
End Class
