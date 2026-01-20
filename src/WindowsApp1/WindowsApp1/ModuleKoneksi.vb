Imports MySql.Data.MySqlClient

Module ModuleKoneksi

    Public conn As MySqlConnection

    Public Sub KoneksiDB()
        Try
            conn = New MySqlConnection(
                "server=localhost;" &
                "user id=root;" &
                "password=;" &
                "database=kasir_genz"
            )

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub

End Module
