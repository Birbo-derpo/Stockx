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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_branch = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Lbl_Stat = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_PaymentStatus = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(740, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 23)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "FRAME NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(736, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 23)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "ENGINE NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(706, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 23)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "MOTORCYCLE PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(701, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 23)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "MOTORCYCLE COLOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(696, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 23)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "MOTORCYCLE MODEL"
        '
        'Txt_FrameNumber
        '
        Me.Txt_FrameNumber.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_FrameNumber.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FrameNumber.Location = New System.Drawing.Point(917, 470)
        Me.Txt_FrameNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_FrameNumber.Name = "Txt_FrameNumber"
        Me.Txt_FrameNumber.ReadOnly = True
        Me.Txt_FrameNumber.Size = New System.Drawing.Size(372, 28)
        Me.Txt_FrameNumber.TabIndex = 55
        '
        'Txt_EngineNumber
        '
        Me.Txt_EngineNumber.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_EngineNumber.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_EngineNumber.Location = New System.Drawing.Point(917, 435)
        Me.Txt_EngineNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_EngineNumber.Name = "Txt_EngineNumber"
        Me.Txt_EngineNumber.ReadOnly = True
        Me.Txt_EngineNumber.Size = New System.Drawing.Size(372, 28)
        Me.Txt_EngineNumber.TabIndex = 54
        '
        'Txt_Price
        '
        Me.Txt_Price.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Price.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Price.Location = New System.Drawing.Point(917, 400)
        Me.Txt_Price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Price.Name = "Txt_Price"
        Me.Txt_Price.ReadOnly = True
        Me.Txt_Price.Size = New System.Drawing.Size(372, 28)
        Me.Txt_Price.TabIndex = 53
        '
        'Txt_Color
        '
        Me.Txt_Color.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Color.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Color.Location = New System.Drawing.Point(917, 361)
        Me.Txt_Color.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Color.Name = "Txt_Color"
        Me.Txt_Color.ReadOnly = True
        Me.Txt_Color.Size = New System.Drawing.Size(372, 28)
        Me.Txt_Color.TabIndex = 52
        '
        'Txt_Model
        '
        Me.Txt_Model.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Model.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Model.Location = New System.Drawing.Point(917, 327)
        Me.Txt_Model.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Model.Name = "Txt_Model"
        Me.Txt_Model.ReadOnly = True
        Me.Txt_Model.Size = New System.Drawing.Size(372, 28)
        Me.Txt_Model.TabIndex = 51
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(917, 254)
        Me.dt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(372, 28)
        Me.dt.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(779, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 24)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "DATED ADDED:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(137, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 23)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "PAY AMOUNT"
        '
        'Txt_Amount
        '
        Me.Txt_Amount.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Amount.Location = New System.Drawing.Point(279, 398)
        Me.Txt_Amount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Amount.Name = "Txt_Amount"
        Me.Txt_Amount.Size = New System.Drawing.Size(372, 27)
        Me.Txt_Amount.TabIndex = 66
        '
        'txtterm
        '
        Me.txtterm.AutoSize = True
        Me.txtterm.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtterm.ForeColor = System.Drawing.Color.Gray
        Me.txtterm.Location = New System.Drawing.Point(70, 470)
        Me.txtterm.Name = "txtterm"
        Me.txtterm.Size = New System.Drawing.Size(203, 23)
        Me.txtterm.TabIndex = 69
        Me.txtterm.Text = "TERMS OF PAYMENT"
        '
        'Cmb_Term
        '
        Me.Cmb_Term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Term.Enabled = False
        Me.Cmb_Term.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Term.ForeColor = System.Drawing.Color.Gray
        Me.Cmb_Term.FormattingEnabled = True
        Me.Cmb_Term.Items.AddRange(New Object() {"12 Months", "24 Months", "36 Months"})
        Me.Cmb_Term.Location = New System.Drawing.Point(279, 466)
        Me.Cmb_Term.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Term.Name = "Cmb_Term"
        Me.Cmb_Term.Size = New System.Drawing.Size(372, 27)
        Me.Cmb_Term.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(56, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(217, 27)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "SALES INVOICE NO."
        '
        'Txt_SIN
        '
        Me.Txt_SIN.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SIN.Location = New System.Drawing.Point(279, 254)
        Me.Txt_SIN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_SIN.Name = "Txt_SIN"
        Me.Txt_SIN.Size = New System.Drawing.Size(372, 27)
        Me.Txt_SIN.TabIndex = 73
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Update.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Update.Location = New System.Drawing.Point(190, 588)
        Me.Btn_Update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(159, 57)
        Me.Btn_Update.TabIndex = 75
        Me.Btn_Update.Text = "UPDATE"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "TYPE OF PAYMENT"
        '
        'Cmb_Type
        '
        Me.Cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Type.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Type.FormattingEnabled = True
        Me.Cmb_Type.Items.AddRange(New Object() {"Cash On Delivery", "Cash Onsite", "Installment Plan"})
        Me.Cmb_Type.Location = New System.Drawing.Point(279, 430)
        Me.Cmb_Type.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Type.Name = "Cmb_Type"
        Me.Cmb_Type.Size = New System.Drawing.Size(372, 27)
        Me.Cmb_Type.TabIndex = 77
        '
        'Cmb_Stat
        '
        Me.Cmb_Stat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Stat.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Stat.FormattingEnabled = True
        Me.Cmb_Stat.Items.AddRange(New Object() {"Release", "Deposit"})
        Me.Cmb_Stat.Location = New System.Drawing.Point(279, 503)
        Me.Cmb_Stat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Stat.Name = "Cmb_Stat"
        Me.Cmb_Stat.Size = New System.Drawing.Size(372, 27)
        Me.Cmb_Stat.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(139, 507)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 23)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "UNIT STATUS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(146, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 23)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "FIRST NAME"
        '
        'Txt_Fname
        '
        Me.Txt_Fname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Fname.Location = New System.Drawing.Point(279, 327)
        Me.Txt_Fname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Fname.Name = "Txt_Fname"
        Me.Txt_Fname.Size = New System.Drawing.Size(372, 27)
        Me.Txt_Fname.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(154, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 23)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "LAST NAME"
        '
        'Txt_Lname
        '
        Me.Txt_Lname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Lname.Location = New System.Drawing.Point(279, 364)
        Me.Txt_Lname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Lname.Name = "Txt_Lname"
        Me.Txt_Lname.Size = New System.Drawing.Size(372, 27)
        Me.Txt_Lname.TabIndex = 80
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 38)
        Me.Label13.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(355, 588)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 57)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(3, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 38)
        Me.Label14.TabIndex = 91
        '
        'lbl_branch
        '
        Me.lbl_branch.AutoSize = True
        Me.lbl_branch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_branch.Location = New System.Drawing.Point(924, 513)
        Me.lbl_branch.Name = "lbl_branch"
        Me.lbl_branch.Size = New System.Drawing.Size(66, 24)
        Me.lbl_branch.TabIndex = 92
        Me.lbl_branch.Text = "Branch"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(837, 514)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 23)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "FROM:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(724, 545)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 23)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "CURRENT STATUS:"
        '
        'Lbl_Stat
        '
        Me.Lbl_Stat.AutoSize = True
        Me.Lbl_Stat.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Stat.Location = New System.Drawing.Point(924, 544)
        Me.Lbl_Stat.Name = "Lbl_Stat"
        Me.Lbl_Stat.Size = New System.Drawing.Size(40, 24)
        Me.Lbl_Stat.TabIndex = 95
        Me.Lbl_Stat.Text = "Stat"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(93, 541)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(180, 23)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "PAYMENT STATUS"
        '
        'txt_PaymentStatus
        '
        Me.txt_PaymentStatus.BackColor = System.Drawing.SystemColors.Window
        Me.txt_PaymentStatus.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PaymentStatus.Location = New System.Drawing.Point(279, 537)
        Me.txt_PaymentStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_PaymentStatus.Name = "txt_PaymentStatus"
        Me.txt_PaymentStatus.ReadOnly = True
        Me.txt_PaymentStatus.Size = New System.Drawing.Size(372, 27)
        Me.txt_PaymentStatus.TabIndex = 97
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(25, 588)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 57)
        Me.Button2.TabIndex = 98
        Me.Button2.Text = "ADD CUSTOMER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stockXproj.My.Resources.Resources.Add_a_subheading__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1317, 182)
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 193)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(272, 38)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "UPDATE STOCK"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Firebrick
        Me.Button3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(1130, 588)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 57)
        Me.Button3.TabIndex = 100
        Me.Button3.Text = "CLOSE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'UpdateStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1313, 672)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_PaymentStatus)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Lbl_Stat)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbl_branch)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
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
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_branch As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Lbl_Stat As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_PaymentStatus As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Button3 As Button
End Class
