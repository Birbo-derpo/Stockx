<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_MT_Number
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
        Me.Btn_ConfirmTransit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_MTN = New System.Windows.Forms.TextBox()
        Me.Grd_MotorcycleReserved = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_back = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        CType(Me.Grd_MotorcycleReserved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_ConfirmTransit
        '
        Me.Btn_ConfirmTransit.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_ConfirmTransit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ConfirmTransit.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ConfirmTransit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_ConfirmTransit.Location = New System.Drawing.Point(897, 431)
        Me.Btn_ConfirmTransit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_ConfirmTransit.Name = "Btn_ConfirmTransit"
        Me.Btn_ConfirmTransit.Size = New System.Drawing.Size(155, 55)
        Me.Btn_ConfirmTransit.TabIndex = 42
        Me.Btn_ConfirmTransit.Text = "CONFIRM TRANSIT"
        Me.Btn_ConfirmTransit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 27)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Merchandise Transit No.:"
        '
        'txt_MTN
        '
        Me.txt_MTN.BackColor = System.Drawing.SystemColors.Window
        Me.txt_MTN.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MTN.Location = New System.Drawing.Point(404, 102)
        Me.txt_MTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MTN.Name = "txt_MTN"
        Me.txt_MTN.Size = New System.Drawing.Size(205, 28)
        Me.txt_MTN.TabIndex = 40
        '
        'Grd_MotorcycleReserved
        '
        Me.Grd_MotorcycleReserved.AllowUserToAddRows = False
        Me.Grd_MotorcycleReserved.AllowUserToDeleteRows = False
        Me.Grd_MotorcycleReserved.AllowUserToResizeColumns = False
        Me.Grd_MotorcycleReserved.AllowUserToResizeRows = False
        Me.Grd_MotorcycleReserved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_MotorcycleReserved.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Grd_MotorcycleReserved.Location = New System.Drawing.Point(22, 160)
        Me.Grd_MotorcycleReserved.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Grd_MotorcycleReserved.Name = "Grd_MotorcycleReserved"
        Me.Grd_MotorcycleReserved.ReadOnly = True
        Me.Grd_MotorcycleReserved.RowHeadersWidth = 51
        Me.Grd_MotorcycleReserved.RowTemplate.Height = 24
        Me.Grd_MotorcycleReserved.Size = New System.Drawing.Size(1122, 267)
        Me.Grd_MotorcycleReserved.TabIndex = 39
        '
        'Column9
        '
        Me.Column9.HeaderText = "Check Select"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Branch"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Invoice Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date& Time"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Model"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Color"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Engine Number"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Frame Number"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'Btn_back
        '
        Me.Btn_back.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_back.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_back.Location = New System.Drawing.Point(111, 431)
        Me.Btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_back.Name = "Btn_back"
        Me.Btn_back.Size = New System.Drawing.Size(155, 55)
        Me.Btn_back.TabIndex = 43
        Me.Btn_back.Text = "BACK"
        Me.Btn_back.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Firebrick
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(937, 60)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(115, 37)
        Me.btnSearch.TabIndex = 46
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(603, 66)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(328, 28)
        Me.txtSearch.TabIndex = 45
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Location = New System.Drawing.Point(950, 121)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(114, 20)
        Me.chkAuto.TabIndex = 47
        Me.chkAuto.Text = "AutoComplete"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'Add_MT_Number
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 568)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Btn_back)
        Me.Controls.Add(Me.Btn_ConfirmTransit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_MTN)
        Me.Controls.Add(Me.Grd_MotorcycleReserved)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Add_MT_Number"
        Me.Text = "Add_MT_Number"
        CType(Me.Grd_MotorcycleReserved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_ConfirmTransit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_MTN As TextBox
    Friend WithEvents Grd_MotorcycleReserved As DataGridView
    Friend WithEvents Btn_back As Button
    Friend WithEvents Column9 As DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents chkAuto As CheckBox
End Class
