Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmShowSessions
    Dim cmd As New SqlCommand
    Dim i As Int32
    Public RetrieveType As String
    Public vLawyer_ID As String
    Public query As String
    Public lRole As String


    Private Sub frmShowSessions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lRole = "M" Then
            frmManager.Show()
            Me.Close()
        ElseIf lRole = "L" Then
            frmLawyer.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from [Session] where ID = " & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                txtSessionID.Text = dr.GetInt32(0).ToString()
                txtDate.Text = dr.GetString(1).ToString()

                txtTime.Text = dr.GetString(2).ToString()
                txtCaseID.Text = dr.GetInt32(3).ToString()
                txtEmailStatus.Text = dr.GetString(4).ToString()
            End While
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Please Click A Valid Row.107")
        End Try
    End Sub
End Class