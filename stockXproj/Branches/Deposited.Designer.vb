﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deposited))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Grd_StockDeposit = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grd_StockDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1460, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 28)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "BRANCH:"
        '
        'Cmb_Branch
        '
        Me.Cmb_Branch.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.Cmb_Branch.Font = New System.Drawing.Font("Arial Narrow", 16.2!)
        Me.Cmb_Branch.FormattingEnabled = True
        Me.Cmb_Branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.Cmb_Branch.Location = New System.Drawing.Point(1580, 232)
        Me.Cmb_Branch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Branch.Name = "Cmb_Branch"
        Me.Cmb_Branch.Size = New System.Drawing.Size(361, 39)
        Me.Cmb_Branch.TabIndex = 51
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Dashboard.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Dashboard.Location = New System.Drawing.Point(253, 802)
        Me.Btn_Dashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(177, 69)
        Me.Btn_Dashboard.TabIndex = 50
        Me.Btn_Dashboard.Text = "DASHBOARD"
        Me.Btn_Dashboard.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(0, 94)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 62)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "ALL UNITS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Font = New System.Drawing.Font("Bell MT", 10.2!, System.Drawing.FontStyle.Bold)
        Me.chkAuto.Location = New System.Drawing.Point(634, 107)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(145, 25)
        Me.chkAuto.TabIndex = 48
        Me.chkAuto.Text = "Auto Complete"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Search.Location = New System.Drawing.Point(786, 54)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(124, 42)
        Me.Btn_Search.TabIndex = 47
        Me.Btn_Search.Text = "SEARCH"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(253, 54)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(527, 42)
        Me.txtSearch.TabIndex = 46
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(253, 99)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(376, 39)
        Me.cmbSearchType.TabIndex = 45
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Update.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Update.Location = New System.Drawing.Point(436, 802)
        Me.Btn_Update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(177, 69)
        Me.Btn_Update.TabIndex = 44
        Me.Btn_Update.Text = "RELEASED"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_AllStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllStock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_AllStock.Location = New System.Drawing.Point(0, 160)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(241, 62)
        Me.Btn_AllStock.TabIndex = 43
        Me.Btn_AllStock.Text = "AVAILABLE UNITS"
        Me.Btn_AllStock.UseVisualStyleBackColor = False
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Deposited.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Deposited.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Deposited.Location = New System.Drawing.Point(0, 293)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(241, 62)
        Me.Btn_Deposited.TabIndex = 42
        Me.Btn_Deposited.Text = "DEPOSITED UNITS"
        Me.Btn_Deposited.UseVisualStyleBackColor = False
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Repossess.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Repossess.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Repossess.Location = New System.Drawing.Point(0, 359)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(241, 62)
        Me.Btn_Repossess.TabIndex = 41
        Me.Btn_Repossess.TabStop = False
        Me.Btn_Repossess.Text = "REPOSSESED UNITS"
        Me.Btn_Repossess.UseVisualStyleBackColor = False
        '
        'Btn_Released
        '
        Me.Btn_Released.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Released.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Released.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Released.Location = New System.Drawing.Point(0, 227)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(241, 62)
        Me.Btn_Released.TabIndex = 40
        Me.Btn_Released.Text = "RELEASED UNITS"
        Me.Btn_Released.UseVisualStyleBackColor = False
        '
        'Grd_StockDeposit
        '
        Me.Grd_StockDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_StockDeposit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column9, Me.Column4, Me.Column5, Me.Column8})
        Me.Grd_StockDeposit.Location = New System.Drawing.Point(253, 287)
        Me.Grd_StockDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Grd_StockDeposit.Name = "Grd_StockDeposit"
        Me.Grd_StockDeposit.RowHeadersWidth = 51
        Me.Grd_StockDeposit.RowTemplate.Height = 24
        Me.Grd_StockDeposit.Size = New System.Drawing.Size(1688, 505)
        Me.Grd_StockDeposit.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Btn_Released)
        Me.GroupBox1.Controls.Add(Me.Btn_Repossess)
        Me.GroupBox1.Controls.Add(Me.Btn_Deposited)
        Me.GroupBox1.Controls.Add(Me.Btn_AllStock)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(0, 287)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(247, 505)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 213)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "SELECT"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "BRANCH"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "MT NO."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DATE DEPOSITED"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MODEL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "PRICE"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "COLOR"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ENGINE NO."
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "FRAME NO."
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Deposited
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 922)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Branch)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Grd_StockDeposit)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Deposited"
        Me.Text = "Diposited"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grd_StockDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Branch As ComboBox
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Grd_StockDeposit As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column10 As DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
