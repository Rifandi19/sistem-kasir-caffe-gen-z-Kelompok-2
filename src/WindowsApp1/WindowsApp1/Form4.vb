Imports MySql.Data.MySqlClient
Public Class Form4

    Dim metodePembayaran As String = ""


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGrid()
        TampilkanKeranjang()
    End Sub


    Sub SetupGrid()
        With dgvPembayaran
            .Columns.Clear()
            .AllowUserToAddRows = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .Columns.Add("no", "No")
            .Columns.Add("nama", "Nama")
            .Columns.Add("qty", "Qty")
            .Columns.Add("harga", "Harga")
            .Columns.Add("subtotal", "Sub Total")

            .Columns("no").Width = 40
            .Columns("qty").Width = 50
        End With
    End Sub


    Sub TampilkanKeranjang()
        dgvPembayaran.Rows.Clear()

        Dim total As Decimal = 0
        Dim no As Integer = 1

        For Each item In ModuleGlobal.Keranjang
            dgvPembayaran.Rows.Add(
            no,
            item.Nama,
            item.Qty,
            item.Harga.ToString("#,##0"),
            item.Subtotal.ToString("#,##0")
        )

            total += item.Subtotal
            no += 1
        Next

        txtTotalBayar.Text = total.ToString("#,##0")
    End Sub



    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        metodePembayaran = "CASH"
        MessageBox.Show("Metode pembayaran: CASH")
    End Sub

    Private Sub btnQris_Click(sender As Object, e As EventArgs) Handles btnQris.Click
        metodePembayaran = "QRIS"
        MessageBox.Show("Metode pembayaran: QRIS")
    End Sub

    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        If metodePembayaran <> "CASH" Then Exit Sub

        Dim bayar As Decimal
        Dim total As Decimal

        If Decimal.TryParse(txtBayar.Text, bayar) AndAlso
       Decimal.TryParse(txtTotalBayar.Text, total) Then

            txtKembalian.Text = (bayar - total).ToString("#,##0")
        End If

    End Sub


    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click

        ' =========================
        ' VALIDASI METODE
        ' =========================
        If metodePembayaran = "" Then
            MessageBox.Show("Pilih metode pembayaran!", "Peringatan")
            Exit Sub
        End If

        If ModuleGlobal.Keranjang.Count = 0 Then
            MessageBox.Show("Keranjang masih kosong!", "Peringatan")
            Exit Sub
        End If

        Dim total As Decimal = Decimal.Parse(txtTotalBayar.Text)
        Dim bayar As Decimal = 0
        Dim kembalian As Decimal = 0

        ' =========================
        ' LOGIKA PEMBAYARAN
        ' =========================
        If metodePembayaran = "CASH" Then

            If Not Decimal.TryParse(txtBayar.Text, bayar) Then
                MessageBox.Show("Masukkan uang bayar!", "Peringatan")
                Exit Sub
            End If

            If bayar < total Then
                MessageBox.Show("Uang bayar kurang!", "Peringatan")
                Exit Sub
            End If

            kembalian = bayar - total
            txtKembalian.Text = kembalian.ToString("#,##0")

        ElseIf metodePembayaran = "QRIS" Then

            bayar = total
            kembalian = 0

            txtBayar.Text = total.ToString("#,##0")
            txtKembalian.Text = "0"

        End If

        ' =========================
        ' SIMPAN KE DATABASE
        ' =========================
        KoneksiDB()

        ' 1. SIMPAN TRANSAKSI
        Dim cmdTransaksi As New MySql.Data.MySqlClient.MySqlCommand(
    "INSERT INTO transaksi 
    (tanggal, total, bayar, kembalian, metode_pembayaran)
     VALUES (NOW(), @total, @bayar, @kembalian, @metode)", conn)

        cmdTransaksi.Parameters.AddWithValue("@total", total)
        cmdTransaksi.Parameters.AddWithValue("@bayar", bayar)
        cmdTransaksi.Parameters.AddWithValue("@kembalian", kembalian)
        cmdTransaksi.Parameters.AddWithValue("@metode", metodePembayaran)

        cmdTransaksi.ExecuteNonQuery()

        Dim idTransaksi As Integer = cmdTransaksi.LastInsertedId


        ' 2. SIMPAN DETAIL TRANSAKSI
        For Each item In ModuleGlobal.Keranjang
            Dim cmdDetail As New MySql.Data.MySqlClient.MySqlCommand(
            "INSERT INTO detail_transaksi
            (id_transaksi, nama_produk, qty, harga, subtotal)
            VALUES (@id, @nama, @qty, @harga, @subtotal)", conn)

            cmdDetail.Parameters.AddWithValue("@id", idTransaksi)
            cmdDetail.Parameters.AddWithValue("@nama", item.Nama)
            cmdDetail.Parameters.AddWithValue("@qty", item.Qty)
            cmdDetail.Parameters.AddWithValue("@harga", item.Harga)
            cmdDetail.Parameters.AddWithValue("@subtotal", item.Subtotal)

            cmdDetail.ExecuteNonQuery()
        Next

        ' =========================
        ' STRUK (PUNYA KAMU)
        ' =========================
        TampilkanStruk(total, bayar, kembalian)

        ' =========================
        ' RESET TRANSAKSI
        ' =========================
        ModuleGlobal.Keranjang.Clear()
        dgvPembayaran.Rows.Clear()

        txtTotalBayar.Text = ""
        txtBayar.Text = ""
        txtKembalian.Text = ""

        MessageBox.Show("Transaksi berhasil disimpan", "Sukses")

        Me.Close()

    End Sub


    Sub TampilkanStruk(total As Decimal, bayar As Decimal, kembalian As Decimal)

        Dim struk As String = ""
        struk &= "        CAFE GEN Z" & vbCrLf
        struk &= "--------------------------------" & vbCrLf
        struk &= "Tanggal : " & DateTime.Now.ToString("dd-MM-yyyy HH:mm") & vbCrLf
        struk &= "--------------------------------" & vbCrLf

        For Each item In ModuleGlobal.Keranjang
            struk &= item.Nama & vbCrLf
            struk &= "  " & item.Qty & " x " &
                 item.Harga.ToString("#,##0") &
                 " = " & item.Subtotal.ToString("#,##0") & vbCrLf
        Next

        struk &= "--------------------------------" & vbCrLf
        struk &= "TOTAL     : Rp " & total.ToString("#,##0") & vbCrLf
        struk &= "BAYAR     : Rp " & bayar.ToString("#,##0") & vbCrLf
        struk &= "KEMBALIAN : Rp " & kembalian.ToString("#,##0") & vbCrLf
        struk &= "METODE    : " & metodePembayaran & vbCrLf
        struk &= "--------------------------------" & vbCrLf
        struk &= " Terima Kasih 🙏" & vbCrLf

        MessageBox.Show(struk, "Struk Pembayaran")
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim konfirmasi = MessageBox.Show(
            "Batalkan pembayaran?",
            "Konfirmasi",
            MessageBoxButtons.YesNo
        )

        If konfirmasi = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
