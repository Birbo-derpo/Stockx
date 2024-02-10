<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Deposited
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btn_Customer = New System.Windows.Forms.Button()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Lbl_Branch = New System.Windows.Forms.Label()
        Me.Grd_Stock = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tobranch = New System.Windows.Forms.ComboBox()
        CType(Me.Grd_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(597, 481)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 62)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Btn_Customer
        '
        Me.Btn_Customer.Location = New System.Drawing.Point(81, 369)
        Me.Btn_Customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Customer.Name = "Btn_Customer"
        Me.Btn_Customer.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Customer.TabIndex = 24
        Me.Btn_Customer.Text = "Customer"
        Me.Btn_Customer.UseVisualStyleBackColor = True
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.Location = New System.Drawing.Point(81, 101)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(143, 62)
        Me.Btn_AllStock.TabIndex = 23
        Me.Btn_AllStock.Text = "All Stock"
        Me.Btn_AllStock.UseVisualStyleBackColor = True
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.Location = New System.Drawing.Point(81, 235)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Deposited.TabIndex = 22
        Me.Btn_Deposited.Text = "Deposited"
        Me.Btn_Deposited.UseVisualStyleBackColor = True
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.Location = New System.Drawing.Point(81, 303)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Repossess.TabIndex = 21
        Me.Btn_Repossess.TabStop = False
        Me.Btn_Repossess.Text = "Repossess"
        Me.Btn_Repossess.UseVisualStyleBackColor = True
        '
        'Btn_Released
        '
        Me.Btn_Released.Location = New System.Drawing.Point(81, 169)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(143, 62)
        Me.Btn_Released.TabIndex = 20
        Me.Btn_Released.Text = "Released "
        Me.Btn_Released.UseVisualStyleBackColor = True
        '
        'Lbl_Branch
        '
        Me.Lbl_Branch.AutoSize = True
        Me.Lbl_Branch.Location = New System.Drawing.Point(269, 11)
        Me.Lbl_Branch.Name = "Lbl_Branch"
        Me.Lbl_Branch.Size = New System.Drawing.Size(75, 16)
        Me.Lbl_Branch.TabIndex = 25
        Me.Lbl_Branch.Text = "X BRANCH"
        '
        'Grd_Stock
        '
        Me.Grd_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5, Me.Column8})
        Me.Grd_Stock.Location = New System.Drawing.Point(230, 101)
        Me.Grd_Stock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Grd_Stock.Name = "Grd_Stock"
        Me.Grd_Stock.RowHeadersWidth = 51
        Me.Grd_Stock.RowTemplate.Height = 24
        Me.Grd_Stock.Size = New System.Drawing.Size(1049, 377)
        Me.Grd_Stock.TabIndex = 26
        '
        'Column7
        '
        Me.Column7.HeaderText = "Branch"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Merchandise Transfer Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Date Arrived"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Model"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Price"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Engine no."
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Frame no"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Status"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1015, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Select Branch"
        '
        'cmb_tobranch
        '
        Me.cmb_tobranch.FormattingEnabled = True
        Me.cmb_tobranch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_tobranch.Location = New System.Drawing.Point(889, 54)
        Me.cmb_tobranch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_tobranch.Name = "cmb_tobranch"
        Me.cmb_tobranch.Size = New System.Drawing.Size(121, 24)
        Me.cmb_tobranch.TabIndex = 29
        '
        'Deposited
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 576)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_tobranch)
        Me.Controls.Add(Me.Grd_Stock)
        Me.Controls.Add(Me.Lbl_Branch)
        Me.Controls.Add(Me.Btn_Customer)
        Me.Controls.Add(Me.Btn_AllStock)
        Me.Controls.Add(Me.Btn_Deposited)
        Me.Controls.Add(Me.Btn_Repossess)
        Me.Controls.Add(Me.Btn_Released)
        Me.Controls.Add(Me.Button5)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Deposited"
        Me.Text = "Diposited"
        CType(Me.Grd_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As Button
    Friend WithEvents Btn_Customer As Button
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Lbl_Branch As Label
    Friend WithEvents Grd_Stock As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_tobranch As ComboBox
End Class
