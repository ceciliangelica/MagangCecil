Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class TransaksiBeli
    Sub DataGrid()
        Call Connect()
        da = New OleDbDataAdapter("SELECT * FROM Pembelian", cn)
        ds = New DataSet
        da.Fill(ds, "Pembelian")
        DataGridView1.DataSource = ds.Tables("Pembelian")
        DataGridView1.ReadOnly = True
    End Sub
    Sub ComboBox()
        Call Connect()
        cmd = New OleDbCommand("SELECT Kode_Barang FROM BahanBaku", cn)
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
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub TransaksiBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Call Connect()
        Call DataGrid()
        Call ComboBox()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Call Connect()
            cmd = New OleDbCommand("SELECT Nomor_Transaksi FROM Pembelian WHERE Nomor_Transaksi='" & TextBox1.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                MsgBox("Maaf, Data dengan kode tersebut sudah ada", MsgBoxStyle.Exclamation, "Warning!")
            Else
                Call Connect()
                Dim Simpan As String
                Simpan = "INSERT INTO Pembelian(Nomor_Transaksi,Tanggal_Pembelian,Kode_Barang,Nama_Barang,Harga_Barang,Stok,Qty,Total_Harga) VALUES ('" & TextBox1.Text & "','" & Format(DateTimePicker1.Value, "dd- MM-yyyy") & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
                cmd = New OleDbCommand(Simpan, cn)
                cmd.ExecuteNonQuery()
                Dim ubah As String
                Dim stok As Integer
                stok = Val(TextBox6.Text) + Val(TextBox4.Text)
                ubah = "UPDATE BahanBaku SET Stok = '" & stok & "' WHERE Kode_Barang ='" & ComboBox1.Text & "'"
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
        cmd = New OleDbCommand("SELECT Kode_Barang,Nama_Barang, Harga_Barang,Stok FROM BahanBaku WHERE Kode_Barang = '" & ComboBox1.Text & "'", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox2.Text = dr.Item(1)
            TextBox3.Text = dr.Item(2)
            TextBox6.Text = dr.Item(3)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        TransaksiBeli_Load(e, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim qty As Integer
        qty = TextBox4.Text
        If qty > TextBox4.Text Then
            MessageBox.Show("Jumlah Quantity melebihi sisa stok !", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TextBox5.Text = Val(TextBox3.Text) * Val(qty)
        End If
    End Sub
End Class