<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_customer
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
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Cmb_Filter = New System.Windows.Forms.ComboBox()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chk_Auto = New System.Windows.Forms.CheckBox()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grd_AllCustomer = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.grd_AllCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Dashboard.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Dashboard.Location = New System.Drawing.Point(12, 882)
        Me.Btn_Dashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(169, 57)
        Me.Btn_Dashboard.TabIndex = 69
        Me.Btn_Dashboard.Text = "DASHBOARD"
        Me.Btn_Dashboard.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Search.Location = New System.Drawing.Point(545, 306)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(124, 42)
        Me.Btn_Search.TabIndex = 68
        Me.Btn_Search.Text = "SEARCH"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Edit.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Edit.Location = New System.Drawing.Point(187, 882)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(159, 57)
        Me.Btn_Edit.TabIndex = 67
        Me.Btn_Edit.Text = "EDIT"
        Me.Btn_Edit.UseVisualStyleBackColor = False
        '
        'Cmb_Filter
        '
        Me.Cmb_Filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Filter.FormattingEnabled = True
        Me.Cmb_Filter.Items.AddRange(New Object() {"Last Name", "First Name", "Status", "Model", "Color", "Branch", "Engine no.", "Frame no.", "Type of pay", "Term of pay", "SIV"})
        Me.Cmb_Filter.Location = New System.Drawing.Point(12, 352)
        Me.Cmb_Filter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Filter.Name = "Cmb_Filter"
        Me.Cmb_Filter.Size = New System.Drawing.Size(376, 33)
        Me.Cmb_Filter.TabIndex = 66
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(12, 309)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(527, 34)
        Me.Txt_Search.TabIndex = 65
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column11.HeaderText = "SIV"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "DATE"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "AMOUNT"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Chk_Auto
        '
        Me.Chk_Auto.AutoSize = True
        Me.Chk_Auto.Font = New System.Drawing.Font("Bodoni MT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Auto.Location = New System.Drawing.Point(404, 358)
        Me.Chk_Auto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chk_Auto.Name = "Chk_Auto"
        Me.Chk_Auto.Size = New System.Drawing.Size(135, 25)
        Me.Chk_Auto.TabIndex = 71
        Me.Chk_Auto.Text = "Auto Complete"
        Me.Chk_Auto.UseVisualStyleBackColor = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "TERM OF PAYMENT"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "FRAME NO."
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ENGINE NO."
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column13.HeaderText = "BRANCH"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "COLOR"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "MODEL"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "STATUS"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "FIRST NAME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "LAST NAME"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "TYPE OF PAYMENT"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'grd_AllCustomer
        '
        Me.grd_AllCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_AllCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column12, Me.Column10, Me.Column13, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column11})
        Me.grd_AllCustomer.Location = New System.Drawing.Point(12, 413)
        Me.grd_AllCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_AllCustomer.Name = "grd_AllCustomer"
        Me.grd_AllCustomer.RowHeadersWidth = 51
        Me.grd_AllCustomer.RowTemplate.Height = 24
        Me.grd_AllCustomer.Size = New System.Drawing.Size(1983, 450)
        Me.grd_AllCustomer.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stockXproj.My.Resources.Resources.Add_a_subheading__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2047, 221)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 44)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "CUSTOMER LISTS"
        '
        'S_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 970)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Cmb_Filter)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Chk_Auto)
        Me.Controls.Add(Me.grd_AllCustomer)
        Me.Name = "S_customer"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grd_AllCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Cmb_Filter As ComboBox
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Chk_Auto As CheckBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents grd_AllCustomer As DataGridView
    Friend WithEvents Label3 As Label
End Class
