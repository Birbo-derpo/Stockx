<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TRANSIT
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
        Me.Btn_Transit = New System.Windows.Forms.Button()
        Me.Btn_AvStock = New System.Windows.Forms.Button()
        Me.Btn_Reserved = New System.Windows.Forms.Button()
        Me.Grd_Motorcycle = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Transfer = New System.Windows.Forms.Button()
        Me.cmb_branch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Grd_Motorcycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Transit
        '
        Me.Btn_Transit.Location = New System.Drawing.Point(32, 229)
        Me.Btn_Transit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Transit.Name = "Btn_Transit"
        Me.Btn_Transit.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Transit.TabIndex = 24
        Me.Btn_Transit.Text = "Transit"
        Me.Btn_Transit.UseVisualStyleBackColor = True
        '
        'Btn_AvStock
        '
        Me.Btn_AvStock.Location = New System.Drawing.Point(32, 121)
        Me.Btn_AvStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AvStock.Name = "Btn_AvStock"
        Me.Btn_AvStock.Size = New System.Drawing.Size(143, 62)
        Me.Btn_AvStock.TabIndex = 23
        Me.Btn_AvStock.Text = "Available Stock"
        Me.Btn_AvStock.UseVisualStyleBackColor = True
        '
        'Btn_Reserved
        '
        Me.Btn_Reserved.Location = New System.Drawing.Point(32, 174)
        Me.Btn_Reserved.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Reserved.Name = "Btn_Reserved"
        Me.Btn_Reserved.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Reserved.TabIndex = 22
        Me.Btn_Reserved.Text = "Reserved"
        Me.Btn_Reserved.UseVisualStyleBackColor = True
        '
        'Grd_Motorcycle
        '
        Me.Grd_Motorcycle.AllowUserToAddRows = False
        Me.Grd_Motorcycle.AllowUserToDeleteRows = False
        Me.Grd_Motorcycle.AllowUserToResizeColumns = False
        Me.Grd_Motorcycle.AllowUserToResizeRows = False
        Me.Grd_Motorcycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_Motorcycle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column10, Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Grd_Motorcycle.Location = New System.Drawing.Point(199, 53)
        Me.Grd_Motorcycle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Grd_Motorcycle.Name = "Grd_Motorcycle"
        Me.Grd_Motorcycle.RowHeadersWidth = 51
        Me.Grd_Motorcycle.RowTemplate.Height = 24
        Me.Grd_Motorcycle.Size = New System.Drawing.Size(1246, 290)
        Me.Grd_Motorcycle.TabIndex = 37
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Check_state"
        Me.Column8.HeaderText = "Check select"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "For Branch"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Merchandise Transfer Number"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 125
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
        'Btn_Transfer
        '
        Me.Btn_Transfer.Location = New System.Drawing.Point(644, 354)
        Me.Btn_Transfer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Transfer.Name = "Btn_Transfer"
        Me.Btn_Transfer.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Transfer.TabIndex = 38
        Me.Btn_Transfer.Text = "confirm delivery"
        Me.Btn_Transfer.UseVisualStyleBackColor = True
        '
        'cmb_branch
        '
        Me.cmb_branch.FormattingEnabled = True
        Me.cmb_branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.Location = New System.Drawing.Point(180, 25)
        Me.cmb_branch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_branch.Name = "cmb_branch"
        Me.cmb_branch.Size = New System.Drawing.Size(121, 24)
        Me.cmb_branch.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "sort by selected Branch"
        '
        'TRANSIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 492)
        Me.Controls.Add(Me.cmb_branch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Transfer)
        Me.Controls.Add(Me.Grd_Motorcycle)
        Me.Controls.Add(Me.Btn_Transit)
        Me.Controls.Add(Me.Btn_AvStock)
        Me.Controls.Add(Me.Btn_Reserved)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TRANSIT"
        Me.Text = "TRANSIT"
        CType(Me.Grd_Motorcycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Transit As Button
    Friend WithEvents Btn_AvStock As Button
    Friend WithEvents Btn_Reserved As Button
    Friend WithEvents Grd_Motorcycle As DataGridView
    Friend WithEvents Btn_Transfer As Button
    Friend WithEvents Column8 As DataGridViewCheckBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents cmb_branch As ComboBox
    Friend WithEvents Label2 As Label
End Class
