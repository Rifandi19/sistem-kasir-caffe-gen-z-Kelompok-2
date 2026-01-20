<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlPreviewKeranjang = New System.Windows.Forms.Panel()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lnlSubTotal = New System.Windows.Forms.Label()
        Me.lblKeranjang = New System.Windows.Forms.ListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTambahKentang = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnTambahCireng = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnTambahNugget = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnTambahSosis = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnSnack = New System.Windows.Forms.Button()
        Me.btnDrink = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlPreviewKeranjang.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlPreviewKeranjang)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btnSnack)
        Me.Panel1.Controls.Add(Me.btnDrink)
        Me.Panel1.Controls.Add(Me.btnFood)
        Me.Panel1.Location = New System.Drawing.Point(27, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1258, 621)
        Me.Panel1.TabIndex = 5
        '
        'pnlPreviewKeranjang
        '
        Me.pnlPreviewKeranjang.Controls.Add(Me.btnBayar)
        Me.pnlPreviewKeranjang.Controls.Add(Me.lblItem)
        Me.pnlPreviewKeranjang.Controls.Add(Me.lnlSubTotal)
        Me.pnlPreviewKeranjang.Controls.Add(Me.lblKeranjang)
        Me.pnlPreviewKeranjang.Controls.Add(Me.btnCancel)
        Me.pnlPreviewKeranjang.Location = New System.Drawing.Point(938, 50)
        Me.pnlPreviewKeranjang.Name = "pnlPreviewKeranjang"
        Me.pnlPreviewKeranjang.Size = New System.Drawing.Size(297, 551)
        Me.pnlPreviewKeranjang.TabIndex = 6
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
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(186, 133)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(280, 51)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(575, 550)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnTambahKentang)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(277, 351)
        Me.Panel3.TabIndex = 0
        '
        'btnTambahKentang
        '
        Me.btnTambahKentang.BackColor = System.Drawing.Color.Red
        Me.btnTambahKentang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahKentang.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahKentang.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambahKentang.Location = New System.Drawing.Point(95, 303)
        Me.btnTambahKentang.Name = "btnTambahKentang"
        Me.btnTambahKentang.Size = New System.Drawing.Size(98, 37)
        Me.btnTambahKentang.TabIndex = 5
        Me.btnTambahKentang.Text = "+"
        Me.btnTambahKentang.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rp 10.000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kentang Goreng"
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
        Me.Panel4.Controls.Add(Me.btnTambahCireng)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(286, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 351)
        Me.Panel4.TabIndex = 3
        '
        'btnTambahCireng
        '
        Me.btnTambahCireng.BackColor = System.Drawing.Color.Red
        Me.btnTambahCireng.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahCireng.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahCireng.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambahCireng.Location = New System.Drawing.Point(86, 303)
        Me.btnTambahCireng.Name = "btnTambahCireng"
        Me.btnTambahCireng.Size = New System.Drawing.Size(98, 37)
        Me.btnTambahCireng.TabIndex = 5
        Me.btnTambahCireng.Text = "+"
        Me.btnTambahCireng.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rp 15.000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cireng Bumbu Rujak"
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
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnTambahNugget)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.PictureBox4)
        Me.Panel6.Location = New System.Drawing.Point(3, 360)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(277, 351)
        Me.Panel6.TabIndex = 6
        '
        'btnTambahNugget
        '
        Me.btnTambahNugget.BackColor = System.Drawing.Color.Red
        Me.btnTambahNugget.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahNugget.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahNugget.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambahNugget.Location = New System.Drawing.Point(95, 302)
        Me.btnTambahNugget.Name = "btnTambahNugget"
        Me.btnTambahNugget.Size = New System.Drawing.Size(98, 37)
        Me.btnTambahNugget.TabIndex = 5
        Me.btnTambahNugget.Text = "+"
        Me.btnTambahNugget.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Rp 15.000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(100, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nugget"
        '
        'PictureBox4
        '
        Me.PictureBox4.ErrorImage = Nothing
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = Nothing
        Me.PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(271, 231)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnTambahSosis)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(286, 360)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(277, 351)
        Me.Panel5.TabIndex = 4
        '
        'btnTambahSosis
        '
        Me.btnTambahSosis.BackColor = System.Drawing.Color.Red
        Me.btnTambahSosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahSosis.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahSosis.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambahSosis.Location = New System.Drawing.Point(86, 302)
        Me.btnTambahSosis.Name = "btnTambahSosis"
        Me.btnTambahSosis.Size = New System.Drawing.Size(98, 37)
        Me.btnTambahSosis.TabIndex = 5
        Me.btnTambahSosis.Text = "+"
        Me.btnTambahSosis.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Rp 10.000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Sosis Goreng"
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(-3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(271, 231)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'btnSnack
        '
        Me.btnSnack.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSnack.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSnack.Location = New System.Drawing.Point(21, 340)
        Me.btnSnack.Name = "btnSnack"
        Me.btnSnack.Size = New System.Drawing.Size(153, 54)
        Me.btnSnack.TabIndex = 2
        Me.btnSnack.Text = "Snack"
        Me.btnSnack.UseVisualStyleBackColor = False
        '
        'btnDrink
        '
        Me.btnDrink.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDrink.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDrink.Location = New System.Drawing.Point(21, 249)
        Me.btnDrink.Name = "btnDrink"
        Me.btnDrink.Size = New System.Drawing.Size(153, 54)
        Me.btnDrink.TabIndex = 1
        Me.btnDrink.Text = "Drink"
        Me.btnDrink.UseVisualStyleBackColor = False
        '
        'btnFood
        '
        Me.btnFood.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFood.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFood.Location = New System.Drawing.Point(21, 161)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(153, 55)
        Me.btnFood.TabIndex = 0
        Me.btnFood.Text = "Food"
        Me.btnFood.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1306, 699)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.pnlPreviewKeranjang.ResumeLayout(False)
        Me.pnlPreviewKeranjang.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSnack As Button
    Friend WithEvents btnDrink As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnTambahKentang As Button
    Friend WithEvents btnTambahCireng As Button
    Friend WithEvents btnTambahNugget As Button
    Friend WithEvents btnTambahSosis As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pnlPreviewKeranjang As Panel
    Friend WithEvents lblItem As Label
    Friend WithEvents lnlSubTotal As Label
    Friend WithEvents lblKeranjang As ListBox
    Friend WithEvents btnBayar As Button
    Friend WithEvents btnCancel As Button
End Class
