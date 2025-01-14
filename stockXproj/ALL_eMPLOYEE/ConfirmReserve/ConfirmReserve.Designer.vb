<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfirmReserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmReserve))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tobranch = New System.Windows.Forms.ComboBox()
        Me.Btn_ConfirmReserve = New System.Windows.Forms.Button()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Btn_back = New System.Windows.Forms.Button()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.grdMotorcycle = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_Qunatity = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.grdMotorcycle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(918, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 27)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "BRANCH:"
        '
        'cmb_tobranch
        '
        Me.cmb_tobranch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tobranch.FormattingEnabled = True
        Me.cmb_tobranch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_tobranch.Location = New System.Drawing.Point(1045, 182)
        Me.cmb_tobranch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_tobranch.Name = "cmb_tobranch"
        Me.cmb_tobranch.Size = New System.Drawing.Size(217, 27)
        Me.cmb_tobranch.TabIndex = 27
        '
        'Btn_ConfirmReserve
        '
        Me.Btn_ConfirmReserve.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_ConfirmReserve.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ConfirmReserve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_ConfirmReserve.Location = New System.Drawing.Point(1146, 471)
        Me.Btn_ConfirmReserve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_ConfirmReserve.Name = "Btn_ConfirmReserve"
        Me.Btn_ConfirmReserve.Size = New System.Drawing.Size(116, 46)
        Me.Btn_ConfirmReserve.TabIndex = 26
        Me.Btn_ConfirmReserve.Text = "RESERVE"
        Me.Btn_ConfirmReserve.UseVisualStyleBackColor = False
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Font = New System.Drawing.Font("Bodoni MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuto.Location = New System.Drawing.Point(609, 149)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(135, 25)
        Me.chkAuto.TabIndex = 25
        Me.chkAuto.Text = "Auto Complete"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Firebrick
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(750, 102)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(116, 46)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(217, 110)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(527, 27)
        Me.txtSearch.TabIndex = 23
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(217, 147)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(376, 27)
        Me.cmbSearchType.TabIndex = 22
        '
        'Btn_back
        '
        Me.Btn_back.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_back.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_back.Location = New System.Drawing.Point(169, 472)
        Me.Btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_back.Name = "Btn_back"
        Me.Btn_back.Size = New System.Drawing.Size(116, 46)
        Me.Btn_back.TabIndex = 29
        Me.Btn_back.Text = "BACK"
        Me.Btn_back.UseVisualStyleBackColor = False
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(923, 117)
        Me.dt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(339, 27)
        Me.dt.TabIndex = 56
        '
        'grdMotorcycle
        '
        Me.grdMotorcycle.AllowUserToAddRows = False
        Me.grdMotorcycle.AllowUserToDeleteRows = False
        Me.grdMotorcycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMotorcycle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.grdMotorcycle.Location = New System.Drawing.Point(169, 215)
        Me.grdMotorcycle.Margin = New System.Windows.Forms.Padding(4)
        Me.grdMotorcycle.Name = "grdMotorcycle"
        Me.grdMotorcycle.RowHeadersWidth = 51
        Me.grdMotorcycle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdMotorcycle.Size = New System.Drawing.Size(1093, 251)
        Me.grdMotorcycle.TabIndex = 57
        '
        'Column1
        '
        Me.Column1.HeaderText = "SELECT"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.FillWeight = 107.895!
        Me.Column2.HeaderText = "INVOICE NUMBER"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 44.69028!
        Me.Column3.HeaderText = "DATE ADDED"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.FillWeight = 48.4963!
        Me.Column4.HeaderText = "MODEL"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.FillWeight = 53.03427!
        Me.Column5.HeaderText = "COLOR"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.FillWeight = 59.82906!
        Me.Column6.HeaderText = "PRICE"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.FillWeight = 160.6951!
        Me.Column7.HeaderText = "ENGINE NUMBER"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.FillWeight = 225.36!
        Me.Column8.HeaderText = "FRAME NUMBER"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'lbl_Qunatity
        '
        Me.lbl_Qunatity.AutoSize = True
        Me.lbl_Qunatity.Location = New System.Drawing.Point(227, 182)
        Me.lbl_Qunatity.Name = "lbl_Qunatity"
        Me.lbl_Qunatity.Size = New System.Drawing.Size(76, 16)
        Me.lbl_Qunatity.TabIndex = 58
        Me.lbl_Qunatity.Text = "QUANTITY"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(211, 177)
        Me.PictureBox3.TabIndex = 86
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1922, 99)
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(217, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(486, 73)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "RESERVATION"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(65, 215)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(97, 20)
        Me.CheckBox1.TabIndex = 89
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ConfirmReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1371, 528)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbl_Qunatity)
        Me.Controls.Add(Me.grdMotorcycle)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Btn_back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_tobranch)
        Me.Controls.Add(Me.Btn_ConfirmReserve)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ConfirmReserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfirmReserve"
        CType(Me.grdMotorcycle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_tobranch As ComboBox
    Friend WithEvents Btn_ConfirmReserve As Button
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Btn_back As Button
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents grdMotorcycle As DataGridView
    Friend WithEvents lbl_Qunatity As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
End Class
