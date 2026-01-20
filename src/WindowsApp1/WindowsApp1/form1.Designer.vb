<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanelFood = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTambahNasi = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNasiGoreng = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnTambahMie = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMieGoreng = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlPreviewKeranjang = New System.Windows.Forms.Panel()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lnlSubTotal = New System.Windows.Forms.Label()
        Me.lblKeranjang = New System.Windows.Forms.ListBox()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSnack = New System.Windows.Forms.Button()
        Me.btnDrink = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanelFood.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPreviewKeranjang.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanelFood)
        Me.Panel1.Controls.Add(Me.pnlPreviewKeranjang)
        Me.Panel1.Controls.Add(Me.btnSnack)
        Me.Panel1.Controls.Add(Me.btnDrink)
        Me.Panel1.Controls.Add(Me.btnFood)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(20, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1258, 621)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(186, 133)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'FlowLayoutPanelFood
        '
        Me.FlowLayoutPanelFood.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanelFood.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanelFood.Location = New System.Drawing.Point(274, 50)
        Me.FlowLayoutPanelFood.Name = "FlowLayoutPanelFood"
        Me.FlowLayoutPanelFood.Size = New System.Drawing.Size(567, 550)
        Me.FlowLayoutPanelFood.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnTambahNasi)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lblNasiGoreng)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(277, 351)
        Me.Panel3.TabIndex = 0
        '
        'btnTambahNasi
        '
        Me.btnTambahNasi.BackColor = System.Drawing.Color.Red
        Me.btnTambahNasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahNasi.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahNasi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambahNasi.Location = New System.Drawing.Point(88, 309)
        Me.btnTambahNasi.Name = "btnTambahNasi"
        Me.btnTambahNasi.Size = New System.Drawing.Size(98, 37)
        Me.btnTambahNasi.TabIndex = 4
        Me.btnTambahNasi.Text = "+"
        Me.btnTambahNasi.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rp 20.000"
        '
        'lblNasiGoreng
        '
        Me.lblNasiGoreng.AutoSize = True
        Me.lblNasiGoreng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNasiGoreng.Location = New System.Drawing.Point(74, 248)
        Me.lblNasiGoreng.Name = "lblNasiGoreng"
        Me.lblNasiGoreng.Size = New System.Drawing.Size(132, 25)
        Me.lblNasiGoreng.TabIndex = 1
        Me.lblNasiGoreng.Text = "Nasi Goreng"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnTambahMie)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblMieGoreng)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(286, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 351)
        Me.Panel4.TabIndex = 3
        '
        'btnTambahMie
        '
        Me.btnTambahMie.BackColor = System.Drawing.Color.Red
        Me.btnTambahMie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahMie.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahMie.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambahMie.Location = New System.Drawing.Point(79, 311)
        Me.btnTambahMie.Name = "btnTambahMie"
        Me.btnTambahMie.Size = New System.Drawing.Size(98, 37)
        Me.btnTambahMie.TabIndex = 4
        Me.btnTambahMie.Text = "+"
        Me.btnTambahMie.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rp 20.000"
        '
        'lblMieGoreng
        '
        Me.lblMieGoreng.AutoSize = True
        Me.lblMieGoreng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMieGoreng.Location = New System.Drawing.Point(64, 248)
        Me.lblMieGoreng.Name = "lblMieGoreng"
        Me.lblMieGoreng.Size = New System.Drawing.Size(124, 25)
        Me.lblMieGoreng.TabIndex = 1
        Me.lblMieGoreng.Text = "Mie Goreng"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(271, 231)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'pnlPreviewKeranjang
        '
        Me.pnlPreviewKeranjang.Controls.Add(Me.lblItem)
        Me.pnlPreviewKeranjang.Controls.Add(Me.lnlSubTotal)
        Me.pnlPreviewKeranjang.Controls.Add(Me.lblKeranjang)
        Me.pnlPreviewKeranjang.Controls.Add(Me.btnBayar)
        Me.pnlPreviewKeranjang.Controls.Add(Me.btnCancel)
        Me.pnlPreviewKeranjang.Location = New System.Drawing.Point(938, 50)
        Me.pnlPreviewKeranjang.Name = "pnlPreviewKeranjang"
        Me.pnlPreviewKeranjang.Size = New System.Drawing.Size(297, 551)
        Me.pnlPreviewKeranjang.TabIndex = 3
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItem.Location = New System.Drawing.Point(29, 52)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(57, 20)
        Me.lblItem.TabIndex = 4
        Me.lblItem.Text = "Item :"
        '
        'lnlSubTotal
        '
        Me.lnlSubTotal.AutoSize = True
        Me.lnlSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlSubTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lnlSubTotal.Location = New System.Drawing.Point(29, 126)
        Me.lnlSubTotal.Name = "lnlSubTotal"
        Me.lnlSubTotal.Size = New System.Drawing.Size(101, 20)
        Me.lnlSubTotal.TabIndex = 3
        Me.lnlSubTotal.Text = "Sub Total :"
        '
        'lblKeranjang
        '
        Me.lblKeranjang.ForeColor = System.Drawing.SystemColors.Window
        Me.lblKeranjang.FormattingEnabled = True
        Me.lblKeranjang.ItemHeight = 16
        Me.lblKeranjang.Location = New System.Drawing.Point(21, 15)
        Me.lblKeranjang.Name = "lblKeranjang"
        Me.lblKeranjang.Size = New System.Drawing.Size(259, 148)
        Me.lblKeranjang.TabIndex = 2
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBayar.Location = New System.Drawing.Point(171, 185)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(109, 40)
        Me.btnBayar.TabIndex = 1
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Location = New System.Drawing.Point(21, 185)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 40)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSnack
        '
        Me.btnSnack.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSnack.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnack.Location = New System.Drawing.Point(20, 337)
        Me.btnSnack.Name = "btnSnack"
        Me.btnSnack.Size = New System.Drawing.Size(153, 54)
        Me.btnSnack.TabIndex = 2
        Me.btnSnack.Text = "Snack"
        Me.btnSnack.UseVisualStyleBackColor = False
        '
        'btnDrink
        '
        Me.btnDrink.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnDrink.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDrink.Location = New System.Drawing.Point(20, 246)
        Me.btnDrink.Name = "btnDrink"
        Me.btnDrink.Size = New System.Drawing.Size(153, 54)
        Me.btnDrink.TabIndex = 1
        Me.btnDrink.Text = "Drink"
        Me.btnDrink.UseVisualStyleBackColor = False
        '
        'btnFood
        '
        Me.btnFood.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnFood.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFood.Location = New System.Drawing.Point(20, 158)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(153, 55)
        Me.btnFood.TabIndex = 0
        Me.btnFood.Text = "Food"
        Me.btnFood.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1299, 696)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanelFood.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPreviewKeranjang.ResumeLayout(False)
        Me.pnlPreviewKeranjang.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents FlowLayoutPanelFood As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnTambahNasi As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNasiGoreng As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnTambahMie As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMieGoreng As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnlPreviewKeranjang As Panel
    Friend WithEvents lblItem As Label
    Friend WithEvents lnlSubTotal As Label
    Friend WithEvents lblKeranjang As ListBox
    Friend WithEvents btnBayar As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSnack As Button
    Friend WithEvents btnDrink As Button
    Friend WithEvents btnFood As Button
End Class
