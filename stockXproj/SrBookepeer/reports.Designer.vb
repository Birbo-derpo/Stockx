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
        Me.grd_report = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.grd_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_report
        '
        Me.grd_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_report.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.grd_report.Location = New System.Drawing.Point(233, 96)
        Me.grd_report.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grd_report.Name = "grd_report"
        Me.grd_report.RowHeadersWidth = 51
        Me.grd_report.RowTemplate.Height = 24
        Me.grd_report.Size = New System.Drawing.Size(532, 166)
        Me.grd_report.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Branc"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Model"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Engine Number"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'cmb_Month
        '
        Me.cmb_Month.FormattingEnabled = True
        Me.cmb_Month.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER ", "DECEMEBR"})
        Me.cmb_Month.Location = New System.Drawing.Point(88, 103)
        Me.cmb_Month.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_Month.Name = "cmb_Month"
        Me.cmb_Month.Size = New System.Drawing.Size(92, 21)
        Me.cmb_Month.TabIndex = 1
        '
        'btnTagum
        '
        Me.btnTagum.Location = New System.Drawing.Point(247, 293)
        Me.btnTagum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTagum.Name = "btnTagum"
        Me.btnTagum.Size = New System.Drawing.Size(118, 44)
        Me.btnTagum.TabIndex = 2
        Me.btnTagum.Text = "TAGUM:   "
        Me.btnTagum.UseVisualStyleBackColor = True
        '
        'btnDavao
        '
        Me.btnDavao.Location = New System.Drawing.Point(410, 293)
        Me.btnDavao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDavao.Name = "btnDavao"
        Me.btnDavao.Size = New System.Drawing.Size(118, 44)
        Me.btnDavao.TabIndex = 3
        Me.btnDavao.Text = "DAVAO:   "
        Me.btnDavao.UseVisualStyleBackColor = True
        '
        'btnGensan
        '
        Me.btnGensan.Location = New System.Drawing.Point(622, 293)
        Me.btnGensan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGensan.Name = "btnGensan"
        Me.btnGensan.Size = New System.Drawing.Size(118, 44)
        Me.btnGensan.TabIndex = 4
        Me.btnGensan.Text = "GENERAL SANTOS:   "
        Me.btnGensan.UseVisualStyleBackColor = True
        '
        'btnDigos
        '
        Me.btnDigos.Location = New System.Drawing.Point(410, 396)
        Me.btnDigos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDigos.Name = "btnDigos"
        Me.btnDigos.Size = New System.Drawing.Size(118, 44)
        Me.btnDigos.TabIndex = 5
        Me.btnDigos.Text = "DIGOS:   "
        Me.btnDigos.UseVisualStyleBackColor = True
        '
        'btnBajada
        '
        Me.btnBajada.Location = New System.Drawing.Point(247, 396)
        Me.btnBajada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBajada.Name = "btnBajada"
        Me.btnBajada.Size = New System.Drawing.Size(118, 44)
        Me.btnBajada.TabIndex = 6
        Me.btnBajada.Text = "BAJADA:   "
        Me.btnBajada.UseVisualStyleBackColor = True
        '
        'btnKidapawan
        '
        Me.btnKidapawan.Location = New System.Drawing.Point(622, 409)
        Me.btnKidapawan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnKidapawan.Name = "btnKidapawan"
        Me.btnKidapawan.Size = New System.Drawing.Size(118, 44)
        Me.btnKidapawan.TabIndex = 7
        Me.btnKidapawan.Text = "KIDAPAWAN:   "
        Me.btnKidapawan.UseVisualStyleBackColor = True
        '
        'Chk_Auto
        '
        Me.Chk_Auto.AutoSize = True
        Me.Chk_Auto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Auto.Location = New System.Drawing.Point(520, 59)
        Me.Chk_Auto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Chk_Auto.Name = "Chk_Auto"
        Me.Chk_Auto.Size = New System.Drawing.Size(127, 21)
        Me.Chk_Auto.TabIndex = 80
        Me.Chk_Auto.Text = "AutoComplete"
        Me.Chk_Auto.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Search.Location = New System.Drawing.Point(634, 16)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(93, 34)
        Me.Btn_Search.TabIndex = 79
        Me.Btn_Search.Text = "SEARCH"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(233, 16)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(396, 35)
        Me.Txt_Search.TabIndex = 78
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Engine Number", "Date"})
        Me.cmbSearchType.Location = New System.Drawing.Point(233, 52)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(283, 34)
        Me.cmbSearchType.TabIndex = 77
        '
        'reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 749)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "reports"
        Me.Text = "aa"
        CType(Me.grd_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_report As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
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
End Class
