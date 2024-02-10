<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Repossess
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
        Me.Lbl_Branch = New System.Windows.Forms.Label()
        Me.Btn_Customer = New System.Windows.Forms.Button()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Grd_StockRepossessed = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grd_StockRepossessed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Branch
        '
        Me.Lbl_Branch.AutoSize = True
        Me.Lbl_Branch.Location = New System.Drawing.Point(198, 41)
        Me.Lbl_Branch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Branch.Name = "Lbl_Branch"
        Me.Lbl_Branch.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_Branch.TabIndex = 15
        Me.Lbl_Branch.Text = "X BRANCH"
        '
        'Btn_Customer
        '
        Me.Btn_Customer.Location = New System.Drawing.Point(91, 307)
        Me.Btn_Customer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Customer.Name = "Btn_Customer"
        Me.Btn_Customer.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Customer.TabIndex = 20
        Me.Btn_Customer.Text = "Customer"
        Me.Btn_Customer.UseVisualStyleBackColor = True
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.Location = New System.Drawing.Point(91, 89)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(107, 50)
        Me.Btn_AllStock.TabIndex = 19
        Me.Btn_AllStock.Text = "All Stock"
        Me.Btn_AllStock.UseVisualStyleBackColor = True
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.Location = New System.Drawing.Point(91, 198)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Deposited.TabIndex = 18
        Me.Btn_Deposited.Text = "Deposited"
        Me.Btn_Deposited.UseVisualStyleBackColor = True
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.Location = New System.Drawing.Point(91, 253)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Repossess.TabIndex = 17
        Me.Btn_Repossess.TabStop = False
        Me.Btn_Repossess.Text = "Repossess"
        Me.Btn_Repossess.UseVisualStyleBackColor = True
        '
        'Btn_Released
        '
        Me.Btn_Released.Location = New System.Drawing.Point(91, 144)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Released.TabIndex = 16
        Me.Btn_Released.Text = "Released "
        Me.Btn_Released.UseVisualStyleBackColor = True
        '
        'Grd_StockRepossessed
        '
        Me.Grd_StockRepossessed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_StockRepossessed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        Me.Grd_StockRepossessed.Location = New System.Drawing.Point(261, 89)
        Me.Grd_StockRepossessed.Margin = New System.Windows.Forms.Padding(2)
        Me.Grd_StockRepossessed.Name = "Grd_StockRepossessed"
        Me.Grd_StockRepossessed.RowHeadersWidth = 51
        Me.Grd_StockRepossessed.RowTemplate.Height = 24
        Me.Grd_StockRepossessed.Size = New System.Drawing.Size(624, 249)
        Me.Grd_StockRepossessed.TabIndex = 23
        '
        'Column7
        '
        Me.Column7.HeaderText = "Branch"
        Me.Column7.Name = "Column7"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "invoice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Date Arrived"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Model"
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Engine no."
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Frame no"
        Me.Column5.Name = "Column5"
        '
        'Repossess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 386)
        Me.Controls.Add(Me.Grd_StockRepossessed)
        Me.Controls.Add(Me.Btn_Customer)
        Me.Controls.Add(Me.Btn_AllStock)
        Me.Controls.Add(Me.Btn_Deposited)
        Me.Controls.Add(Me.Btn_Repossess)
        Me.Controls.Add(Me.Btn_Released)
        Me.Controls.Add(Me.Lbl_Branch)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Repossess"
        Me.Text = "Reposes"
        CType(Me.Grd_StockRepossessed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Branch As Label
    Friend WithEvents Btn_Customer As Button
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Grd_StockRepossessed As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
