Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [User] WHERE [ID] ='" & TextBox1.Text & "'AND [Password] = '" & TextBox2.Text & "'", cn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim UserFound As Boolean = False
        Dim Access As String
        While dr.Read
            UserFound = True
            Access = dr("Access").ToString
        End While

        If UserFound = True And Access = "all" Then
            Me.Hide()
            MainMenu.Show()

        Else
            MsgBox("Username/Password yang anda masukkan salah", MsgBoxStyle.OkOnly, "Invalid Login")
        End If
    End Sub
End Class