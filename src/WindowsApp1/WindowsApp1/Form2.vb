Public Class Form2

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdatePreviewKeranjang()
    End Sub


    Private Sub btnTambahTeh_Click(sender As Object, e As EventArgs) Handles btnTambahTeh.Click
        TambahItem("Es Teh Manis", 10000)
    End Sub


    Private Sub btnTambahJeruk_Click(sender As Object, e As EventArgs) Handles btnTambahJeruk.Click
        TambahItem("Es Jeruk", 10000)
    End Sub


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
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim f As New Form4
        f.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim konfirmasi = MessageBox.Show(
        "Batalkan pesanan dan kosongkan keranjang?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If konfirmasi = DialogResult.Yes Then
            ' Kosongkan keranjang global
            ModuleGlobal.Keranjang.Clear()

            ' Reset preview
            lblItem.Text = "Item : 0"
            lnlSubTotal.Text = "Sub Total : Rp 0"
        End If
    End Sub


    ' Pindah ke Food
    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        Form1.Show()
        Me.Hide()
    End Sub

    ' Pindah ke Snack
    Private Sub btnSnack_Click(sender As Object, e As EventArgs) Handles btnSnack.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdatePreviewKeranjang()
    End Sub
End Class
