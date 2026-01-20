<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnQris = New System.Windows.Forms.Button()
        Me.dgvPembayaran = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMetodePembayaran = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalBayar = New System.Windows.Forms.Label()
        Me.lblBayar = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.lblKembalian = New System.Windows.Forms.Label()
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment"
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCash.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(215, 130)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(162, 63)
        Me.btnCash.TabIndex = 2
        Me.btnCash.Text = "CASH"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnQris
        '
        Me.btnQris.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnQris.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQris.Location = New System.Drawing.Point(18, 129)
        Me.btnQris.Name = "btnQris"
        Me.btnQris.Size = New System.Drawing.Size(161, 65)
        Me.btnQris.TabIndex = 3
        Me.btnQris.Text = "QRIS"
        Me.btnQris.UseVisualStyleBackColor = False
        '
        'dgvPembayaran
        '
        Me.dgvPembayaran.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPembayaran.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembayaran.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Nama, Me.Qty, Me.Harga, Me.SubTotal})
        Me.dgvPembayaran.Location = New System.Drawing.Point(18, 285)
        Me.dgvPembayaran.Name = "dgvPembayaran"
        Me.dgvPembayaran.RowHeadersWidth = 51
        Me.dgvPembayaran.RowTemplate.Height = 24
        Me.dgvPembayaran.Size = New System.Drawing.Size(722, 331)
        Me.dgvPembayaran.TabIndex = 4
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.MinimumWidth = 6
        Me.No.Name = "No"
        Me.No.Width = 125
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.MinimumWidth = 6
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 125
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.MinimumWidth = 6
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 125
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.MinimumWidth = 6
        Me.Harga.Name = "Harga"
        Me.Harga.Width = 125
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Width = 125
        '
        'lblMetodePembayaran
        '
        Me.lblMetodePembayaran.AutoSize = True
        Me.lblMetodePembayaran.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetodePembayaran.Location = New System.Drawing.Point(13, 76)
        Me.lblMetodePembayaran.Name = "lblMetodePembayaran"
        Me.lblMetodePembayaran.Size = New System.Drawing.Size(234, 28)
        Me.lblMetodePembayaran.TabIndex = 5
        Me.lblMetodePembayaran.Text = "METODE PEMBAYARAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "RINCIAN PEMBAYARAN"
        '
        'lblTotalBayar
        '
        Me.lblTotalBayar.AutoSize = True
        Me.lblTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBayar.Location = New System.Drawing.Point(25, 666)
        Me.lblTotalBayar.Name = "lblTotalBayar"
        Me.lblTotalBayar.Size = New System.Drawing.Size(136, 25)
        Me.lblTotalBayar.TabIndex = 7
        Me.lblTotalBayar.Text = "Total Bayar :"
        '
        'lblBayar
        '
        Me.lblBayar.AutoSize = True
        Me.lblBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBayar.Location = New System.Drawing.Point(25, 722)
        Me.lblBayar.Name = "lblBayar"
        Me.lblBayar.Size = New System.Drawing.Size(135, 25)
        Me.lblBayar.TabIndex = 8
        Me.lblBayar.Text = "Bayar          :"
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.Location = New System.Drawing.Point(179, 661)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(198, 30)
        Me.txtTotalBayar.TabIndex = 10
        '
        'txtBayar
        '
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(179, 719)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(198, 30)
        Me.txtBayar.TabIndex = 11
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBayar.Location = New System.Drawing.Point(611, 821)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(109, 40)
        Me.btnBayar.TabIndex = 14
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Location = New System.Drawing.Point(458, 821)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 40)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtKembalian
        '
        Me.txtKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembalian.Location = New System.Drawing.Point(179, 777)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(198, 30)
        Me.txtKembalian.TabIndex = 15
        '
        'lblKembalian
        '
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.Location = New System.Drawing.Point(25, 777)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(133, 25)
        Me.lblKembalian.TabIndex = 16
        Me.lblKembalian.Text = "Kembalian  :"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(753, 888)
        Me.Controls.Add(Me.lblKembalian)
        Me.Controls.Add(Me.txtKembalian)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.lblBayar)
        Me.Controls.Add(Me.lblTotalBayar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMetodePembayaran)
        Me.Controls.Add(Me.dgvPembayaran)
        Me.Controls.Add(Me.btnQris)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCash As Button
    Friend WithEvents btnQris As Button
    Friend WithEvents dgvPembayaran As DataGridView
    Friend WithEvents lblMetodePembayaran As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalBayar As Label
    Friend WithEvents lblBayar As Label
    Friend WithEvents txtTotalBayar As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents btnBayar As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents txtKembalian As TextBox
    Friend WithEvents lblKembalian As Label
End Class
