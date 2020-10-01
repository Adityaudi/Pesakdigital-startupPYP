Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public conn As New SqlConnection
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public sql As String

    Public Sub koneksi()
        sql = "Data Source=DESKTOP-L63F7SH;Initial Catalog=DB_LOMBA;Integrated Security=True"
        conn = New SqlConnection(sql)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("NIS dan Password salah", MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
