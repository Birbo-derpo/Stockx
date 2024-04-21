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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addMotorcycle))
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFrameNumber = New System.Windows.Forms.TextBox()
        Me.txtEngineNumber = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_AddCateg = New System.Windows.Forms.Button()
        Me.Cmb_Color = New System.Windows.Forms.ComboBox()
        Me.Cmb_Model = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Add.FlatAppearance.BorderSize = 2
        Me.Btn_Add.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Add.Location = New System.Drawing.Point(411, 439)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(124, 42)
        Me.Btn_Add.TabIndex = 50
        Me.Btn_Add.Text = "SAVE"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(237, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "FRAME NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(229, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ENGINE NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(197, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 17)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "MOTORCYCLE PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "MOTORCYCLE COLOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "MOTORCYCLE MODEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "INVOICE NUMBER"
        '
        'txtFrameNumber
        '
        Me.txtFrameNumber.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrameNumber.Location = New System.Drawing.Point(421, 380)
        Me.txtFrameNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFrameNumber.Name = "txtFrameNumber"
        Me.txtFrameNumber.Size = New System.Drawing.Size(384, 23)
        Me.txtFrameNumber.TabIndex = 41
        '
        'txtEngineNumber
        '
        Me.txtEngineNumber.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngineNumber.Location = New System.Drawing.Point(421, 340)
        Me.txtEngineNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEngineNumber.Name = "txtEngineNumber"
        Me.txtEngineNumber.Size = New System.Drawing.Size(384, 23)
        Me.txtEngineNumber.TabIndex = 40
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(421, 299)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(384, 23)
        Me.txtPrice.TabIndex = 39
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(421, 133)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(384, 26)
        Me.txtInvoiceNumber.TabIndex = 36
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Clear.FlatAppearance.BorderSize = 2
        Me.Btn_Clear.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Clear.Location = New System.Drawing.Point(541, 439)
        Me.Btn_Clear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(124, 42)
        Me.Btn_Clear.TabIndex = 51
        Me.Btn_Clear.Text = "CLEAR"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'Btn_close
        '
        Me.Btn_close.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_close.FlatAppearance.BorderSize = 2
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_close.Location = New System.Drawing.Point(669, 439)
        Me.Btn_close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(124, 42)
        Me.Btn_close.TabIndex = 52
        Me.Btn_close.Text = "CLOSE"
        Me.Btn_close.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 149)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Btn_AddCateg
        '
        Me.Btn_AddCateg.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_AddCateg.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_AddCateg.FlatAppearance.BorderSize = 2
        Me.Btn_AddCateg.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddCateg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_AddCateg.Location = New System.Drawing.Point(821, 106)
        Me.Btn_AddCateg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AddCateg.Name = "Btn_AddCateg"
        Me.Btn_AddCateg.Size = New System.Drawing.Size(159, 57)
        Me.Btn_AddCateg.TabIndex = 70
        Me.Btn_AddCateg.Text = "ADD NEW MODEL/COLOR"
        Me.Btn_AddCateg.UseVisualStyleBackColor = False
        '
        'Cmb_Color
        '
        Me.Cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Color.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Color.FormattingEnabled = True
        Me.Cmb_Color.Location = New System.Drawing.Point(421, 257)
        Me.Cmb_Color.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Color.Name = "Cmb_Color"
        Me.Cmb_Color.Size = New System.Drawing.Size(384, 24)
        Me.Cmb_Color.TabIndex = 71
        '
        'Cmb_Model
        '
        Me.Cmb_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Model.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Model.FormattingEnabled = True
        Me.Cmb_Model.Location = New System.Drawing.Point(421, 218)
        Me.Cmb_Model.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Model.Name = "Cmb_Model"
        Me.Cmb_Model.Size = New System.Drawing.Size(384, 24)
        Me.Cmb_Model.TabIndex = 72
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.stockXproj.My.Resources.Resources.HONDA_COLOR
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(203, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(809, 64)
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Firebrick
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(221, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 29)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "ADD MOTORCYCLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(421, 83)
        Me.dt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(359, 23)
        Me.dt.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Date Added"
        '
        'addMotorcycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 503)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Cmb_Model)
        Me.Controls.Add(Me.Cmb_Color)
        Me.Controls.Add(Me.Btn_AddCateg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFrameNumber)
        Me.Controls.Add(Me.txtEngineNumber)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "addMotorcycle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addMotorcycle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Add As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFrameNumber As TextBox
    Friend WithEvents txtEngineNumber As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtInvoiceNumber As TextBox
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_close As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_AddCateg As Button
    Friend WithEvents Cmb_Color As ComboBox
    Friend WithEvents Cmb_Model As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
