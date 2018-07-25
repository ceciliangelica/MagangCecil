Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class MasterBarangJadi
    Sub DataGrid()
        Call Connect()
        da = New OleDbDataAdapter("SELECT * FROM BarangJadi", cn)
        ds = New DataSet
        da.Fill(ds, "BarangJadi")
        DataGridView1.DataSource = ds.Tables("BarangJadi")
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
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Call Connect()
        Call DataGrid()
        Call ComboBox()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Call Connect()
            cmd = New OleDbCommand("SELECT Kode_Barang FROM BarangJadi WHERE Kode_Barang='" & TextBox1.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                MsgBox("Maaf, Data dengan kode tersebut sudah ada", MsgBoxStyle.Exclamation, "Warning!")
            Else
                Call Connect()
                Dim Simpan As String
                Simpan = "INSERT INTO BarangJadi(Kode_Barang,Nama_Barang,Harga_Barang,Stok) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                cmd = New OleDbCommand(Simpan, cn)
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
        TextBox1.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Connect()
        cmd = New OleDbCommand("SELECT Kode_Barang,Nama_Barang, Harga_Barang,Stok FROM BarangJadi WHERE Kode_Barang = '" & ComboBox1.Text & "'", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox1.Text = dr.Item(0)
            TextBox2.Text = dr.Item(1)
            TextBox3.Text = dr.Item(2)
            TextBox4.Text = dr.Item(3)
            TextBox1.Enabled = False
            TextBox2.Focus()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Call Connect()
            Dim ubah As String
            ubah = "UPDATE BarangJadi SET Nama_Barang = '" & TextBox2.Text & "', Harga_Barang = '" & TextBox3.Text & "', Stok = '" & TextBox4.Text & "' WHERE Kode_Barang ='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(ubah, cn)
            cmd.ExecuteNonQuery()
            Call Hapus()
            Call DataGrid()
            Call ComboBox()
            TextBox1.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Call Connect()
            Dim Hapusaja As String
            Hapusaja = "DELETE FROM BarangJadi Where Kode_Barang='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(Hapusaja, cn)
            cmd.ExecuteNonQuery()
            Call Hapus()
            Call DataGrid()
            Call ComboBox()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        Form1_Load(e, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
