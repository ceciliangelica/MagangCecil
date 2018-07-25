Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class MasterKaryawan
    Sub DataGrid()
        Call Connect()
        da = New OleDbDataAdapter("SELECT * FROM Pegawai", cn)
        ds = New DataSet
        da.Fill(ds, "Pegawai")
        DataGridView1.DataSource = ds.Tables("Pegawai")
        DataGridView1.ReadOnly = True
    End Sub
    Sub ComboBox()
        Call Connect()
        cmd = New OleDbCommand("SELECT Nomor_Pegawai FROM Pegawai", cn)
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
        ComboBox2.Text = ""
        TextBox4.Text = ""
        DateTimePicker1.ResetText()
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        DateTimePicker2.ResetText()
        TextBox1.Focus()
        Button1.Text = "Tambah"
    End Sub
    Private Sub MasterKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Add("Laki-Laki")
        ComboBox2.Items.Add("Perempuan")
        TextBox1.Focus()
        Call Connect()
        Call DataGrid()
        Call ComboBox()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Call Connect()
            cmd = New OleDbCommand("SELECT Nomor_Pegawai FROM Pegawai WHERE Nomor_Pegawai ='" & TextBox1.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                MsgBox("Maaf, Data dengan kode tersebut sudah ada", MsgBoxStyle.Exclamation, "Warning!")
            Else
                Call Connect()
                Dim Simpan As String
                Simpan = "INSERT INTO Pegawai(Nomor_Pegawai,Nama_Pegawai,Jenis_Kelamin,Tempat_Lahir,Tanggal_Lahir,Nomor_Telepon,Alamat,Jabatan,Tanggal_Masuk) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & ComboBox2.Text & "', '" & TextBox4.Text & "', '" & Format(DateTimePicker1.Value, "dd- MM-yyyy") & "', '" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & Format(DateTimePicker2.Value, "dd-MM-yyyy") & "')"
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
        cmd = New OleDbCommand("SELECT Nomor_Pegawai,Nama_Pegawai,Jenis_Kelamin,Tempat_Lahir,Tanggal_Lahir,Nomor_Telepon,Alamat,Jabatan,Tanggal_Masuk FROM Pegawai WHERE Nomor_Pegawai = '" & ComboBox1.Text & "'", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox1.Text = dr.Item(0)
            TextBox2.Text = dr.Item(1)
            ComboBox2.Text = dr.Item(2)
            TextBox4.Text = dr.Item(3)
            DateTimePicker1.Value = dr.Item(4)
            TextBox5.Text = dr.Item(5)
            TextBox6.Text = dr.Item(6)
            TextBox7.Text = dr.Item(7)
            DateTimePicker2.Value = dr.Item(8)
            TextBox1.Enabled = False
            TextBox2.Focus()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Call Connect()
            Dim ubah As String
            ubah = "UPDATE Barang SET Nama_Pegawai = '" & TextBox2.Text & "',Jenis_Kelamin= '" & ComboBox2.Text & "', Tempat_Lahir='" & TextBox4.Text & "', Tanggal_Lahir='" & Format(DateTimePicker1.Value, "DD-MM-YYYY") & "', Nomor_Handphone='" & TextBox5.Text & "', Alamat='" & TextBox6.Text & "', Jabatan='" & TextBox7.Text & "', Tanggal_Masuk='" & Format(DateTimePicker2.Value, "DD-MM-YYYY") & "' WHERE Nomor_Pegawai = '" & TextBox1.Text & "'"
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
            Hapusaja = "DELETE FROM Pegawai Where Nomor_Pegawai='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(Hapusaja, cn)
            cmd.ExecuteNonQuery()
            Call Hapus()
            Call DataGrid()
            Call ComboBox()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MasterKaryawan_Load(e, e)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class