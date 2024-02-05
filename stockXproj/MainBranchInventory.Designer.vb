<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainBranchInventory
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grdMotorcycle = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        CType(Me.grdMotorcycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(549, 462)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(442, 462)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(343, 462)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(176, 465)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 16)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total"
        '
        'grdMotorcycle
        '
        Me.grdMotorcycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMotorcycle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.grdMotorcycle.Location = New System.Drawing.Point(113, 145)
        Me.grdMotorcycle.Name = "grdMotorcycle"
        Me.grdMotorcycle.RowHeadersWidth = 51
        Me.grdMotorcycle.RowTemplate.Height = 24
        Me.grdMotorcycle.Size = New System.Drawing.Size(978, 267)
        Me.grdMotorcycle.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Invoice Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date& Time"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Model"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Color"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Engine Number"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Frame Number"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(164, 82)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(121, 24)
        Me.cmbSearchType.TabIndex = 10
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(164, 54)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(212, 22)
        Me.txtSearch.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(418, 54)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Location = New System.Drawing.Point(164, 112)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(114, 20)
        Me.chkAuto.TabIndex = 13
        Me.chkAuto.Text = "AutoComplete"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'MainBranchInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 526)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.grdMotorcycle)
        Me.Name = "MainBranchInventory"
        Me.Text = "MainBranchInventory"
        CType(Me.grdMotorcycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents grdMotorcycle As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents chkAuto As CheckBox
End Class
