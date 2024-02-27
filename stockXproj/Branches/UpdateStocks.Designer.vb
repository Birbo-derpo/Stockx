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
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Amount = New System.Windows.Forms.TextBox()
        Me.txtterm = New System.Windows.Forms.Label()
        Me.Cmb_Term = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_SIN = New System.Windows.Forms.TextBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Type = New System.Windows.Forms.ComboBox()
        Me.Cmb_Stat = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_Fname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_Lname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Motor
        '
        Me.Motor.AutoSize = True
        Me.Motor.Location = New System.Drawing.Point(292, 48)
        Me.Motor.Name = "Motor"
        Me.Motor.Size = New System.Drawing.Size(0, 16)
        Me.Motor.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 478)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 19)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "FRAME NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 19)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "ENGINE NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 19)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "MOTORCYCLE PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 19)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "MOTORCYCLE COLOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "MOTORCYCLE MODEL"
        '
        'Txt_FrameNumber
        '
        Me.Txt_FrameNumber.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_FrameNumber.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FrameNumber.Location = New System.Drawing.Point(220, 476)
        Me.Txt_FrameNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_FrameNumber.Name = "Txt_FrameNumber"
        Me.Txt_FrameNumber.ReadOnly = True
        Me.Txt_FrameNumber.Size = New System.Drawing.Size(372, 27)
        Me.Txt_FrameNumber.TabIndex = 55
        '
        'Txt_EngineNumber
        '
        Me.Txt_EngineNumber.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_EngineNumber.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_EngineNumber.Location = New System.Drawing.Point(220, 429)
        Me.Txt_EngineNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_EngineNumber.Name = "Txt_EngineNumber"
        Me.Txt_EngineNumber.ReadOnly = True
        Me.Txt_EngineNumber.Size = New System.Drawing.Size(372, 27)
        Me.Txt_EngineNumber.TabIndex = 54
        '
        'Txt_Price
        '
        Me.Txt_Price.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Price.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Price.Location = New System.Drawing.Point(220, 382)
        Me.Txt_Price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Price.Name = "Txt_Price"
        Me.Txt_Price.ReadOnly = True
        Me.Txt_Price.Size = New System.Drawing.Size(372, 27)
        Me.Txt_Price.TabIndex = 53
        '
        'Txt_Color
        '
        Me.Txt_Color.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Color.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Color.Location = New System.Drawing.Point(220, 336)
        Me.Txt_Color.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Color.Name = "Txt_Color"
        Me.Txt_Color.ReadOnly = True
        Me.Txt_Color.Size = New System.Drawing.Size(372, 27)
        Me.Txt_Color.TabIndex = 52
        '
        'Txt_Model
        '
        Me.Txt_Model.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Model.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Model.Location = New System.Drawing.Point(220, 295)
        Me.Txt_Model.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Model.Name = "Txt_Model"
        Me.Txt_Model.ReadOnly = True
        Me.Txt_Model.Size = New System.Drawing.Size(372, 27)
        Me.Txt_Model.TabIndex = 51
        '
        'dt
        '
        Me.dt.Location = New System.Drawing.Point(901, 359)
        Me.dt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(319, 22)
        Me.dt.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(782, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "DATE TIME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(755, 394)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "UNIT AMOUNT"
        '
        'Txt_Amount
        '
        Me.Txt_Amount.Location = New System.Drawing.Point(901, 390)
        Me.Txt_Amount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Amount.Name = "Txt_Amount"
        Me.Txt_Amount.Size = New System.Drawing.Size(319, 22)
        Me.Txt_Amount.TabIndex = 66
        '
        'txtterm
        '
        Me.txtterm.AutoSize = True
        Me.txtterm.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtterm.ForeColor = System.Drawing.Color.Gray
        Me.txtterm.Location = New System.Drawing.Point(703, 456)
        Me.txtterm.Name = "txtterm"
        Me.txtterm.Size = New System.Drawing.Size(174, 19)
        Me.txtterm.TabIndex = 69
        Me.txtterm.Text = "TERMS OF PAYMENT"
        '
        'Cmb_Term
        '
        Me.Cmb_Term.Enabled = False
        Me.Cmb_Term.ForeColor = System.Drawing.Color.Gray
        Me.Cmb_Term.FormattingEnabled = True
        Me.Cmb_Term.Items.AddRange(New Object() {"12 Months", "24 Months", "36 Months"})
        Me.Cmb_Term.Location = New System.Drawing.Point(901, 450)
        Me.Cmb_Term.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Term.Name = "Cmb_Term"
        Me.Cmb_Term.Size = New System.Drawing.Size(319, 24)
        Me.Cmb_Term.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 19)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "SALES INVOICE NO."
        '
        'Txt_SIN
        '
        Me.Txt_SIN.Location = New System.Drawing.Point(220, 229)
        Me.Txt_SIN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_SIN.Name = "Txt_SIN"
        Me.Txt_SIN.Size = New System.Drawing.Size(372, 22)
        Me.Txt_SIN.TabIndex = 73
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Update.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Update.Location = New System.Drawing.Point(543, 550)
        Me.Btn_Update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(143, 48)
        Me.Btn_Update.TabIndex = 75
        Me.Btn_Update.Text = "UPDATE"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(718, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 19)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "TYPE OF PAYMENT"
        '
        'Cmb_Type
        '
        Me.Cmb_Type.FormattingEnabled = True
        Me.Cmb_Type.Items.AddRange(New Object() {"Cash On Delivery", "Cash Onsite", "Installment Plan"})
        Me.Cmb_Type.Location = New System.Drawing.Point(901, 419)
        Me.Cmb_Type.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Type.Name = "Cmb_Type"
        Me.Cmb_Type.Size = New System.Drawing.Size(319, 24)
        Me.Cmb_Type.TabIndex = 77
        '
        'Cmb_Stat
        '
        Me.Cmb_Stat.FormattingEnabled = True
        Me.Cmb_Stat.Items.AddRange(New Object() {"Release", "Deposit", "Repossess"})
        Me.Cmb_Stat.Location = New System.Drawing.Point(901, 483)
        Me.Cmb_Stat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Stat.Name = "Cmb_Stat"
        Me.Cmb_Stat.Size = New System.Drawing.Size(319, 24)
        Me.Cmb_Stat.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(762, 488)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 19)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "UNIT STATUS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(769, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 19)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "FIRST NAME"
        '
        'Txt_Fname
        '
        Me.Txt_Fname.Location = New System.Drawing.Point(901, 295)
        Me.Txt_Fname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Fname.Name = "Txt_Fname"
        Me.Txt_Fname.Size = New System.Drawing.Size(319, 22)
        Me.Txt_Fname.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(774, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 19)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "LAST NAME"
        '
        'Txt_Lname
        '
        Me.Txt_Lname.Location = New System.Drawing.Point(901, 327)
        Me.Txt_Lname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Lname.Name = "Txt_Lname"
        Me.Txt_Lname.Size = New System.Drawing.Size(319, 22)
        Me.Txt_Lname.TabIndex = 80
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stockXproj.My.Resources.Resources.Add_a_subheading__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 193)
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'UpdateStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 635)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_Lname)
        Me.Controls.Add(Me.Cmb_Stat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Cmb_Type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txt_SIN)
        Me.Controls.Add(Me.Cmb_Term)
        Me.Controls.Add(Me.txtterm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_Amount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txt_Fname)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UpdateStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateStocks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Amount As TextBox
    Friend WithEvents txtterm As Label
    Friend WithEvents Cmb_Term As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txt_SIN As TextBox
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Type As ComboBox
    Friend WithEvents Cmb_Stat As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_Fname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_Lname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
