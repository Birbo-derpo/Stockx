﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Btn_transfer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tobranch = New System.Windows.Forms.ComboBox()
        Me.grdMotorcycle = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdMotorcycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Transit
        '
        Me.Btn_Transit.Location = New System.Drawing.Point(32, 229)
        Me.Btn_Transit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Transit.Name = "Btn_Transit"
        Me.Btn_Transit.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Transit.TabIndex = 24
        Me.Btn_Transit.Text = "Transit"
        Me.Btn_Transit.UseVisualStyleBackColor = True
        '
        'Btn_AvStock
        '
        Me.Btn_AvStock.Location = New System.Drawing.Point(32, 120)
        Me.Btn_AvStock.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_AvStock.Name = "Btn_AvStock"
        Me.Btn_AvStock.Size = New System.Drawing.Size(107, 50)
        Me.Btn_AvStock.TabIndex = 23
        Me.Btn_AvStock.Text = "Available Stock"
        Me.Btn_AvStock.UseVisualStyleBackColor = True
        '
        'Btn_Reserved
        '
        Me.Btn_Reserved.Location = New System.Drawing.Point(32, 174)
        Me.Btn_Reserved.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Reserved.Name = "Btn_Reserved"
        Me.Btn_Reserved.Size = New System.Drawing.Size(107, 50)
        Me.Btn_Reserved.TabIndex = 22
        Me.Btn_Reserved.Text = "Reserved"
        Me.Btn_Reserved.UseVisualStyleBackColor = True
        '
        'Btn_transfer
        '
        Me.Btn_transfer.Location = New System.Drawing.Point(777, 371)
        Me.Btn_transfer.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_transfer.Name = "Btn_transfer"
        Me.Btn_transfer.Size = New System.Drawing.Size(141, 37)
        Me.Btn_transfer.TabIndex = 26
        Me.Btn_transfer.Text = "Transfer To Selected Branch"
        Me.Btn_transfer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(575, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Select Branch"
        '
        'cmb_tobranch
        '
        Me.cmb_tobranch.FormattingEnabled = True
        Me.cmb_tobranch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_tobranch.Location = New System.Drawing.Point(479, 24)
        Me.cmb_tobranch.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tobranch.Name = "cmb_tobranch"
        Me.cmb_tobranch.Size = New System.Drawing.Size(92, 21)
        Me.cmb_tobranch.TabIndex = 36
        '
        'grdMotorcycle
        '
        Me.grdMotorcycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMotorcycle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.grdMotorcycle.Location = New System.Drawing.Point(171, 60)
        Me.grdMotorcycle.Margin = New System.Windows.Forms.Padding(2)
        Me.grdMotorcycle.Name = "grdMotorcycle"
        Me.grdMotorcycle.RowHeadersWidth = 51
        Me.grdMotorcycle.RowTemplate.Height = 24
        Me.grdMotorcycle.Size = New System.Drawing.Size(791, 291)
        Me.grdMotorcycle.TabIndex = 37
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Check_state"
        Me.Column8.HeaderText = "Check select"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
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
        'TRANSIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 430)
        Me.Controls.Add(Me.grdMotorcycle)
        Me.Controls.Add(Me.cmb_tobranch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_transfer)
        Me.Controls.Add(Me.Btn_Transit)
        Me.Controls.Add(Me.Btn_AvStock)
        Me.Controls.Add(Me.Btn_Reserved)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TRANSIT"
        Me.Text = "TRANSIT"
        CType(Me.grdMotorcycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Transit As Button
    Friend WithEvents Btn_AvStock As Button
    Friend WithEvents Btn_Reserved As Button
    Friend WithEvents Btn_transfer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_tobranch As ComboBox
    Friend WithEvents grdMotorcycle As DataGridView
    Friend WithEvents Column8 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
