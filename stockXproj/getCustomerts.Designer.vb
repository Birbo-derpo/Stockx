<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class getCustomerts
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
        Me.grd_GetCustomer = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_AddCustomer = New System.Windows.Forms.Button()
        CType(Me.grd_GetCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_GetCustomer
        '
        Me.grd_GetCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_GetCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.grd_GetCustomer.Location = New System.Drawing.Point(138, 74)
        Me.grd_GetCustomer.Name = "grd_GetCustomer"
        Me.grd_GetCustomer.RowHeadersWidth = 51
        Me.grd_GetCustomer.RowTemplate.Height = 24
        Me.grd_GetCustomer.Size = New System.Drawing.Size(864, 488)
        Me.grd_GetCustomer.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "First Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Last Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Amount Paid"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Payment Status"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'btn_AddCustomer
        '
        Me.btn_AddCustomer.BackColor = System.Drawing.Color.Firebrick
        Me.btn_AddCustomer.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_AddCustomer.Location = New System.Drawing.Point(465, 576)
        Me.btn_AddCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_AddCustomer.Name = "btn_AddCustomer"
        Me.btn_AddCustomer.Size = New System.Drawing.Size(159, 57)
        Me.btn_AddCustomer.TabIndex = 28
        Me.btn_AddCustomer.Text = "ADD CUSTOMER"
        Me.btn_AddCustomer.UseVisualStyleBackColor = False
        '
        'getCustomerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 680)
        Me.Controls.Add(Me.btn_AddCustomer)
        Me.Controls.Add(Me.grd_GetCustomer)
        Me.Name = "getCustomerts"
        Me.Text = "getCustomertsfullypaid"
        CType(Me.grd_GetCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grd_GetCustomer As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btn_AddCustomer As Button
End Class
