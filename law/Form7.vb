Imports System.Data.SqlClient

Public Class Form7
    Dim cmd As New SqlCommand
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        display_grid()
    End Sub
    Private Sub display_grid()
        Try

            cmd = con.CreateCommand
            cmd.CommandText = "SELECT Consaultation_text from consaultation where client_id=@id"
            cmd.Parameters.AddWithValue("@id", CurrentUserID)
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error displaying data: " & ex.Message)
        End Try
    End Sub
End Class