Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class TransaksiJual
    Sub DataGrid()
        Call Connect()
        da = New OleDbDataAdapter("SELECT * FROM Penjualan", cn)
        ds = New DataSet
        da.Fill(ds, "Penjualan")
        DataGridView1.DataSource = ds.Tables("Penjualan")
        DataGridView1.ReadOnly = True
    End Sub


    Sub ComboBox()
        Call Connect()
        cmd = New OleDbCommand("SELECT Kode_Barang FROM BarangJadi", cn)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        Loop
        cmd.Dispose()
        dr.Close()
        cn.Close()
    End Sub
    Sub Hapus()
        TextBox1.Text = ""
        DateTimePicker1.ResetText()
        ComboBox1.ResetText()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub TransaksiJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Call Connect()
        Call DataGrid()
        Call ComboBox()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Call Connect()
            cmd = New OleDbCommand("SELECT Nomor_Transaksi FROM Penjualan WHERE Nomor_Transaksi='" & TextBox1.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                MsgBox("Maaf, Data dengan kode tersebut sudah ada", MsgBoxStyle.Exclamation, "Warning!")
            Else
                Call Connect()
                Dim Simpan As String
                Simpan = "INSERT INTO Penjualan(Nomor_Transaksi,Tanggal_Penjualan,Kode_Barang,Nama_Barang,Harga_Barang,Stok,Qty,Diskon,Total_Harga) VALUES ('" & TextBox1.Text & "','" & Format(DateTimePicker1.Value, "dd- MM-yyyy") & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "')"
                cmd = New OleDbCommand(Simpan, cn)
                cmd.ExecuteNonQuery()
                Dim ubah As String
                Dim sisa As Integer
                sisa = Val(TextBox4.Text) - Val(TextBox7.Text)
                ubah = "UPDATE BarangJadi SET Stok = '" & sisa & "' WHERE Kode_Barang ='" & ComboBox1.Text & "'"
                cmd = New OleDbCommand(ubah, cn)
                cmd.ExecuteNonQuery()
                Call DataGrid()
                Call Hapus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Hapus()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Connect()
        cmd = New OleDbCommand("SELECT Kode_Barang,Nama_Barang, Harga_Barang,Stok FROM BarangJadi WHERE Kode_Barang = '" & ComboBox1.Text & "'", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox2.Text = dr.Item(1)
            TextBox3.Text = dr.Item(2)
            TextBox4.Text = dr.Item(3)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim qty As Integer
        qty = TextBox7.Text
        If qty > TextBox4.Text Then
            MessageBox.Show("Jumlah Quantity melebihi sisa stok !", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf qty < 50 Then
            TextBox6.Text = 0
            TextBox5.Text = (Val(TextBox3.Text) * Val(qty)) - Val(TextBox6.Text)
        ElseIf qty >= 50 Then
            TextBox6.Text = Val(TextBox3.Text) * 0.05
            TextBox5.Text = (Val(TextBox3.Text) * Val(qty)) - Val(TextBox6.Text)
        ElseIf qty > 100 Then
            TextBox6.Text = Val(TextBox3.Text) * 0.1
            TextBox5.Text = (Val(TextBox3.Text) * Val(qty)) - Val(TextBox6.Text)
        ElseIf qty > 150 Then
            TextBox6.Text = Val(TextBox3.Text) * 0.15
            TextBox5.Text = (Val(TextBox3.Text) * Val(qty)) - Val(TextBox6.Text)
        ElseIf qty > 200 Then
            TextBox6.Text = Val(TextBox3.Text) * 0.2
            TextBox5.Text = (Val(TextBox3.Text) * Val(qty)) - Val(TextBox6.Text)
        End If
    End Sub
End Class