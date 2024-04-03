<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reports))
        Me.grd_report = New System.Windows.Forms.DataGridView()
        Me.cmb_Month = New System.Windows.Forms.ComboBox()
        Me.btnTagum = New System.Windows.Forms.Button()
        Me.btnDavao = New System.Windows.Forms.Button()
        Me.btnGensan = New System.Windows.Forms.Button()
        Me.btnDigos = New System.Windows.Forms.Button()
        Me.btnBajada = New System.Windows.Forms.Button()
        Me.btnKidapawan = New System.Windows.Forms.Button()
        Me.Chk_Auto = New System.Windows.Forms.CheckBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grd_report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_report
        '
        Me.grd_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_report.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.grd_report.Location = New System.Drawing.Point(527, 371)
        Me.grd_report.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_report.Name = "grd_report"
        Me.grd_report.RowHeadersWidth = 51
        Me.grd_report.RowTemplate.Height = 24
        Me.grd_report.Size = New System.Drawing.Size(823, 385)
        Me.grd_report.TabIndex = 0
        '
        'cmb_Month
        '
        Me.cmb_Month.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Month.FormattingEnabled = True
        Me.cmb_Month.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER ", "DECEMEBR"})
        Me.cmb_Month.Location = New System.Drawing.Point(35, 371)
        Me.cmb_Month.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Month.Name = "cmb_Month"
        Me.cmb_Month.Size = New System.Drawing.Size(422, 27)
        Me.cmb_Month.TabIndex = 1
        Me.cmb_Month.Text = "MONTH"
        '
        'btnTagum
        '
        Me.btnTagum.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTagum.Location = New System.Drawing.Point(35, 412)
        Me.btnTagum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTagum.Name = "btnTagum"
        Me.btnTagum.Size = New System.Drawing.Size(422, 54)
        Me.btnTagum.TabIndex = 2
        Me.btnTagum.Text = "TAGUM:   "
        Me.btnTagum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTagum.UseVisualStyleBackColor = True
        '
        'btnDavao
        '
        Me.btnDavao.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDavao.Location = New System.Drawing.Point(35, 470)
        Me.btnDavao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDavao.Name = "btnDavao"
        Me.btnDavao.Size = New System.Drawing.Size(422, 54)
        Me.btnDavao.TabIndex = 3
        Me.btnDavao.Text = "DAVAO:   "
        Me.btnDavao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDavao.UseVisualStyleBackColor = True
        '
        'btnGensan
        '
        Me.btnGensan.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGensan.Location = New System.Drawing.Point(35, 528)
        Me.btnGensan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGensan.Name = "btnGensan"
        Me.btnGensan.Size = New System.Drawing.Size(422, 54)
        Me.btnGensan.TabIndex = 4
        Me.btnGensan.Text = "GENERAL SANTOS:   "
        Me.btnGensan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGensan.UseVisualStyleBackColor = True
        '
        'btnDigos
        '
        Me.btnDigos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDigos.Location = New System.Drawing.Point(35, 644)
        Me.btnDigos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDigos.Name = "btnDigos"
        Me.btnDigos.Size = New System.Drawing.Size(422, 54)
        Me.btnDigos.TabIndex = 5
        Me.btnDigos.Text = "DIGOS:   "
        Me.btnDigos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDigos.UseVisualStyleBackColor = True
        '
        'btnBajada
        '
        Me.btnBajada.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajada.Location = New System.Drawing.Point(35, 586)
        Me.btnBajada.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBajada.Name = "btnBajada"
        Me.btnBajada.Size = New System.Drawing.Size(422, 54)
        Me.btnBajada.TabIndex = 6
        Me.btnBajada.Text = "BAJADA:   "
        Me.btnBajada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBajada.UseVisualStyleBackColor = True
        '
        'btnKidapawan
        '
        Me.btnKidapawan.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKidapawan.Location = New System.Drawing.Point(35, 702)
        Me.btnKidapawan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKidapawan.Name = "btnKidapawan"
        Me.btnKidapawan.Size = New System.Drawing.Size(422, 54)
        Me.btnKidapawan.TabIndex = 7
        Me.btnKidapawan.Text = "KIDAPAWAN:   "
        Me.btnKidapawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKidapawan.UseVisualStyleBackColor = True
        '
        'Chk_Auto
        '
        Me.Chk_Auto.AutoSize = True
        Me.Chk_Auto.BackColor = System.Drawing.Color.Firebrick
        Me.Chk_Auto.Font = New System.Drawing.Font("Bodoni MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Auto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Chk_Auto.Location = New System.Drawing.Point(1084, 295)
        Me.Chk_Auto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chk_Auto.Name = "Chk_Auto"
        Me.Chk_Auto.Size = New System.Drawing.Size(131, 25)
        Me.Chk_Auto.TabIndex = 80
        Me.Chk_Auto.Text = "AutoComplete"
        Me.Chk_Auto.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Search.Location = New System.Drawing.Point(1235, 244)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(115, 35)
        Me.Btn_Search.TabIndex = 79
        Me.Btn_Search.Text = "SEARCH"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(527, 249)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(688, 30)
        Me.Txt_Search.TabIndex = 78
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Engine Number", "Date"})
        Me.cmbSearchType.Location = New System.Drawing.Point(527, 293)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(537, 27)
        Me.cmbSearchType.TabIndex = 77
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 188)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1538, 168)
        Me.PictureBox2.TabIndex = 82
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 52)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "BRANCH REPORTS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(247, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1779, 190)
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1, -3)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(241, 190)
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "BRANCH"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 139
        '
        'Column2
        '
        Me.Column2.HeaderText = "MODEL"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "ENGINE NUMBER"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "DATE"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 922)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk_Auto)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.btnKidapawan)
        Me.Controls.Add(Me.btnBajada)
        Me.Controls.Add(Me.btnDigos)
        Me.Controls.Add(Me.btnGensan)
        Me.Controls.Add(Me.btnDavao)
        Me.Controls.Add(Me.btnTagum)
        Me.Controls.Add(Me.cmb_Month)
        Me.Controls.Add(Me.grd_report)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "reports"
        Me.Text = "aa"
        CType(Me.grd_report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_report As DataGridView
    Friend WithEvents cmb_Month As ComboBox
    Friend WithEvents btnTagum As Button
    Friend WithEvents btnDavao As Button
    Friend WithEvents btnGensan As Button
    Friend WithEvents btnDigos As Button
    Friend WithEvents btnBajada As Button
    Friend WithEvents btnKidapawan As Button
    Friend WithEvents Chk_Auto As CheckBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
