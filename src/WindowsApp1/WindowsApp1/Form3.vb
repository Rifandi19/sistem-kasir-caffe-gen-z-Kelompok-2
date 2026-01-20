Public Class Form3

    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdatePreviewKeranjang()
    End Sub

    Private Sub btnTambahKentang_Click(sender As Object, e As EventArgs) Handles btnTambahKentang.Click
        TambahItem("Kentang Goreng", 10000)
    End Sub
    Private Sub btnTambahCireng_Click(sender As Object, e As EventArgs) Handles btnTambahCireng.Click
        TambahItem("Cireng", 15000)
    End Sub
    Private Sub btnTambahNugget_Click(sender As Object, e As EventArgs) Handles btnTambahNugget.Click
        TambahItem("Nugget", 15000)
    End Sub
    Private Sub btnTambahSosis_Click(sender As Object, e As EventArgs) Handles btnTambahSosis.Click
        TambahItem("Sosing Goreng", 10000)
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


    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnDrink_Click(sender As Object, e As EventArgs) Handles btnDrink.Click
        Form2.Show()
        Me.Hide()
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

    Private Sub Form_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdatePreviewKeranjang()
    End Sub
End Class

