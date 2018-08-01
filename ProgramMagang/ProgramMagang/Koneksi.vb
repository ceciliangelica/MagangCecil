Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Module Koneksi

    Public cn As OleDbConnection
    Public dr As OleDbDataReader
    Public cmd As New OleDbCommand
    'Public cmd1 As New OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public table As DataTable
    Public count As Integer

    Public Sub Connect()
        Dim acdb As String
        acdb = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Database.mdb;"
        cn = New OleDbConnection(acdb)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub
End Module
