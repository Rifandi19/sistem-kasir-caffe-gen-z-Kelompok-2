Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatePreviewKeranjang()
    End Sub

    ' =========================
    ' TAMBAH NASI GORENG
    ' =========================
    Private Sub btnTambahNasi_Click(sender As Object, e As EventArgs) Handles btnTambahNasi.Click
        TambahItem("Nasi Goreng", 20000)
    End Sub

    ' =========================
    ' TAMBAH MIE GORENG
    ' =========================
    Private Sub btnTambahMie_Click(sender As Object, e As EventArgs) Handles btnTambahMie.Click
        TambahItem("Mie Goreng", 15000)
    End Sub

    ' =========================
    ' FUNGSI TAMBAH ITEM
    ' =========================
    Sub TambahItem(nama As String, harga As Decimal)
        Dim item = ModuleGlobal.Keranjang.Find(Function(x) x.Nama = nama)

        If item IsNot Nothing Then
            item.Qty += 1
            item.Subtotal = item.Qty * item.Harga
        Else
            ModuleGlobal.Keranjang.Add(New ItemKeranjang With {
                .Nama = nama,
                .Harga = harga,
                .Qty = 1,
                .Subtotal = harga
            })
        End If

        UpdatePreviewKeranjang()
    End Sub

    ' =========================
    ' PREVIEW KERANJANG
    ' =========================
    Sub UpdatePreviewKeranjang()
        Dim totalItem As Integer = 0
        Dim totalHarga As Decimal = 0

        For Each item In ModuleGlobal.Keranjang
            totalItem += item.Qty
            totalHarga += item.Subtotal
        Next

        lblItem.Text = "Item : " & totalItem
        lnlSubTotal.Text = "Sub Total : Rp " & totalHarga.ToString("#,##0")
    End Sub

    ' =========================
    ' CANCEL PESANAN
    ' =========================
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim konfirmasi = MessageBox.Show(
            "Batalkan pesanan dan kosongkan keranjang?",
            "Konfirmasi",
            MessageBoxButtons.YesNo
        )

        If konfirmasi = DialogResult.Yes Then
            ModuleGlobal.Keranjang.Clear()
            UpdatePreviewKeranjang()
        End If
    End Sub

    ' =========================
    ' NAVIGASI
    ' =========================
    Private Sub btnDrink_Click(sender As Object, e As EventArgs) Handles btnDrink.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnSnack_Click(sender As Object, e As EventArgs) Handles btnSnack.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Form4.Show()
    End Sub

End Class
