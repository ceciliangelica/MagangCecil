Imports System.Data
Imports System.Data.SqlClient
Public Class LaporanKaryawan
    Private Sub LaporanKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PegawaiTableAdapter1.Fill(Me.DataSet1.Pegawai)

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        LaporanMaster.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        On Error GoTo ErrRe
        TextBox1.Select()
        PegawaiBindingSource.Filter = Nothing

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = PegawaiBindingSource
        End With
ErrEx:
        Exit Sub
ErrRe:
        MsgBox("Error Number " & Err.Number & vbNewLine & "Error Description" & Err.Description, MsgBoxStyle.Critical, "Reset Error")
        Resume ErrEx
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo SearchErr
        If TextBox1.Text = "" Then
            Exit Sub
        Else
            Dim cantFind As String = TextBox1.Text

            PegawaiBindingSource.Filter = "(Convert(Nomor_Pegawai, 'System.String') LIKE '" & TextBox1.Text & "')" & "OR (Nama_Pegawai LIKE '" & TextBox1.Text & "') OR (Jenis_Kelamin LIKE '" & TextBox1.Text & "')" & "OR (Tempat_Lahir LIKE '" & TextBox1.Text & "') OR (Tanggal_Lahir LIKE '" & TextBox1.Text & "')" & "OR (Nomor_Telepon LIKE '" & TextBox1.Text & "')" & "OR(Alamat LIKE '" & TextBox1.Text & "')" & "OR(Jabatan LIKE '" & TextBox1.Text & "')" & "OR(Tanggal_Masuk LIKE '" & TextBox1.Text & "')"
            If PegawaiBindingSource.Count Then
                With DataGridView1
                    .DataSource = PegawaiBindingSource
                End With
            Else
                MsgBox("-->" & cantFind & vbNewLine & "The search item was not found", MsgBoxStyle.Information, "Error!")
                PegawaiBindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = PegawaiBindingSource
                End With
            End If
        End If
ErrEx:
        Exit Sub
SearchErr:
        MsgBox("Error Number " & Err.Number & vbNewLine & "Error Description" & Err.Description, MsgBoxStyle.Critical, "Reset Error")
        Resume ErrEx
    End Sub
End Class