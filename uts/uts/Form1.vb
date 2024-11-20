Imports System.Data.OleDb

Public Class frmPenjualan
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db_barang.mdb;"

    ' Form Load
    Private Sub frmPenjualan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            LoadKodeBarang()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error initializing form: " & ex.Message)
        End Try
    End Sub

    ' Load data ke combobox
    Private Sub LoadKodeBarang()
        Try
            Dim sql As String = "SELECT Kodebrg, Namabrg, Sisastok FROM StokBRG"
            Dim dt As New DataTable()
            Using adapter As New OleDbDataAdapter(sql, connectionString)
                adapter.Fill(dt)
            End Using
            cboKodebrg.DataSource = dt
            cboKodebrg.DisplayMember = "Kodebrg"
            cboKodebrg.ValueMember = "Kodebrg"
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    ' TextChanged untuk jumlah dan harga
    Private Sub TextChangedHandler(ByVal sender As Object, ByVal e As EventArgs) Handles txtJumlah.TextChanged, txtHJual.TextChanged
        UpdateSubtotal()
        If txtJumlah.Text.Length > 0 Then
            CheckStock()
        End If
    End Sub

    ' Update subtotal
    Private Sub UpdateSubtotal()
        If IsNumeric(txtJumlah.Text) AndAlso IsNumeric(txtHJual.Text) Then
            txtSubtotal.Text = (Convert.ToInt32(txtJumlah.Text) * Convert.ToDouble(txtHJual.Text)).ToString("N0")
        Else
            txtSubtotal.Text = "0"
        End If
    End Sub

    ' Periksa stok
    Private Sub CheckStock()
        Try
            Dim sisaStok As Integer = GetSisaStok(cboKodebrg.SelectedValue.ToString())
            If sisaStok < Convert.ToInt32(txtJumlah.Text) Then
                MessageBox.Show("Stok tidak mencukupi! Sisa stok: " & sisaStok)
                txtJumlah.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking stock: " & ex.Message)
        End Try
    End Sub

    ' Ambil sisa stok
    Private Function GetSisaStok(ByVal kodeBarang As String) As Integer
        Dim sisaStok As Integer = 0
        Dim sql As String = "SELECT Sisastok FROM StokBRG WHERE Kodebrg = @kodebrg"
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kodebrg", kodeBarang)
                sisaStok = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
        Return sisaStok
    End Function

    ' Simpan transaksi
    Private Sub btnSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpan.Click
        If Not IsValidForm() Then
            MessageBox.Show("Semua field harus diisi dengan benar!")
            Return
        End If

        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Using transaction = conn.BeginTransaction()
                    ' Insert ke JUALBRG
                    Dim sqlInsert As String = "INSERT INTO JUALBRG (NOFAKTUR, TGLJUAL, Kodebrg, Jumlah, HJUAL, Subtotal) VALUES (?, ?, ?, ?, ?, ?)"
                    Using cmd As New OleDbCommand(sqlInsert, conn, transaction)
                        cmd.Parameters.AddWithValue("@nofaktur", txtNofaktur.Text)
                        cmd.Parameters.AddWithValue("@tgljual", dtpTglJual.Value.Date)
                        cmd.Parameters.AddWithValue("@kodebrg", cboKodebrg.SelectedValue.ToString())
                        cmd.Parameters.AddWithValue("@jumlah", Convert.ToInt32(txtJumlah.Text))
                        cmd.Parameters.AddWithValue("@hjual", Convert.ToDouble(txtHJual.Text))
                        cmd.Parameters.AddWithValue("@subtotal", Convert.ToDouble(txtSubtotal.Text.Replace(",", "")))
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Update stok barang
                    Dim sqlUpdate As String = "UPDATE StokBRG SET Sisastok = Sisastok - ? WHERE Kodebrg = ?"
                    Using cmd As New OleDbCommand(sqlUpdate, conn, transaction)
                        cmd.Parameters.AddWithValue("@jumlah", Convert.ToInt32(txtJumlah.Text))
                        cmd.Parameters.AddWithValue("@kodebrg", cboKodebrg.SelectedValue.ToString())
                        cmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                End Using
            End Using

            MessageBox.Show("Data berhasil disimpan!")
            ClearForm()
            LoadKodeBarang() ' Refresh data combobox
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub

    ' Validasi form
    Private Function IsValidForm() As Boolean
        If String.IsNullOrEmpty(txtNofaktur.Text) OrElse _
           cboKodebrg.SelectedValue Is Nothing OrElse _
           Not IsNumeric(txtJumlah.Text) OrElse _
           Not IsNumeric(txtHJual.Text) Then
            Return False
        End If
        Return True
    End Function

    ' Reset form
    Private Sub ClearForm()
        txtNofaktur.Text = ""
        dtpTglJual.Value = DateTime.Now
        cboKodebrg.SelectedIndex = -1
        txtJumlah.Text = ""
        txtHJual.Text = ""
        txtSubtotal.Text = ""
    End Sub

    ' Hanya angka di txtJumlah dan txtHJual
    Private Sub NumericKeyPressHandler(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtJumlah.KeyPress, txtHJual.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
