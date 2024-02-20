<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateStocks
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
        Me.Motor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_FrameNumber = New System.Windows.Forms.TextBox()
        Me.Txt_EngineNumber = New System.Windows.Forms.TextBox()
        Me.Txt_Price = New System.Windows.Forms.TextBox()
        Me.Txt_Color = New System.Windows.Forms.TextBox()
        Me.Txt_Model = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_SIN = New System.Windows.Forms.TextBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Motor
        '
        Me.Motor.AutoSize = True
        Me.Motor.Location = New System.Drawing.Point(219, 39)
        Me.Motor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Motor.Name = "Motor"
        Me.Motor.Size = New System.Drawing.Size(0, 13)
        Me.Motor.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 170)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "FRAME NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "ENGINE NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "MOTORCYCLE PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "MOTORCYCLE COLOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "MOTORCYCLE MODEL"
        '
        'Txt_FrameNumber
        '
        Me.Txt_FrameNumber.Location = New System.Drawing.Point(460, 167)
        Me.Txt_FrameNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_FrameNumber.Name = "Txt_FrameNumber"
        Me.Txt_FrameNumber.ReadOnly = True
        Me.Txt_FrameNumber.Size = New System.Drawing.Size(240, 20)
        Me.Txt_FrameNumber.TabIndex = 55
        '
        'Txt_EngineNumber
        '
        Me.Txt_EngineNumber.Location = New System.Drawing.Point(460, 129)
        Me.Txt_EngineNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_EngineNumber.Name = "Txt_EngineNumber"
        Me.Txt_EngineNumber.ReadOnly = True
        Me.Txt_EngineNumber.Size = New System.Drawing.Size(240, 20)
        Me.Txt_EngineNumber.TabIndex = 54
        '
        'Txt_Price
        '
        Me.Txt_Price.Location = New System.Drawing.Point(460, 91)
        Me.Txt_Price.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Price.Name = "Txt_Price"
        Me.Txt_Price.ReadOnly = True
        Me.Txt_Price.Size = New System.Drawing.Size(240, 20)
        Me.Txt_Price.TabIndex = 53
        '
        'Txt_Color
        '
        Me.Txt_Color.Location = New System.Drawing.Point(460, 54)
        Me.Txt_Color.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Color.Name = "Txt_Color"
        Me.Txt_Color.ReadOnly = True
        Me.Txt_Color.Size = New System.Drawing.Size(240, 20)
        Me.Txt_Color.TabIndex = 52
        '
        'Txt_Model
        '
        Me.Txt_Model.Location = New System.Drawing.Point(460, 20)
        Me.Txt_Model.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Model.Name = "Txt_Model"
        Me.Txt_Model.ReadOnly = True
        Me.Txt_Model.Size = New System.Drawing.Size(240, 20)
        Me.Txt_Model.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 245)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(460, 240)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 64
        '
        'dt
        '
        Me.dt.Location = New System.Drawing.Point(460, 274)
        Me.dt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(151, 20)
        Me.dt.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 279)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "DATE&TIME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(357, 308)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Amount"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(460, 306)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 66
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(352, 338)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Terms of Payment"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(506, 331)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(334, 209)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Sales Ivoice Number"
        '
        'Txt_SIN
        '
        Me.Txt_SIN.Location = New System.Drawing.Point(460, 209)
        Me.Txt_SIN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_SIN.Name = "Txt_SIN"
        Me.Txt_SIN.Size = New System.Drawing.Size(240, 20)
        Me.Txt_SIN.TabIndex = 73
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(758, 368)
        Me.Btn_Update.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(107, 39)
        Me.Btn_Update.TabIndex = 75
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(352, 359)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Types of Payment"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(506, 356)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox3.TabIndex = 77
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Release", "Deposit", "Repossess"})
        Me.ComboBox2.Location = New System.Drawing.Point(506, 386)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox2.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(357, 389)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Unit Status"
        '
        'UpdateStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 431)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txt_SIN)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_FrameNumber)
        Me.Controls.Add(Me.Txt_EngineNumber)
        Me.Controls.Add(Me.Txt_Price)
        Me.Controls.Add(Me.Txt_Color)
        Me.Controls.Add(Me.Txt_Model)
        Me.Controls.Add(Me.Motor)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UpdateStocks"
        Me.Text = "UpdateStocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Motor As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_FrameNumber As TextBox
    Friend WithEvents Txt_EngineNumber As TextBox
    Friend WithEvents Txt_Price As TextBox
    Friend WithEvents Txt_Color As TextBox
    Friend WithEvents Txt_Model As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txt_SIN As TextBox
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label11 As Label
End Class
