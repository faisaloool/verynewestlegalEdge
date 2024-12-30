Imports System.Data.SqlClient

Public Class Form1
    Dim cmd As SqlCommand
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        display_grid()
    End Sub
    Private Sub display_grid()
        cmd = con.CreateCommand
        cmd.CommandText = "select Lawyer_ID,Name,role,status from lawyer"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Try
            TextBox1.Text = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        Catch ex As Exception
            MsgBox("select valid row")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand
        Dim NewStatus As String = ComboBox1.SelectedItem.ToString
        Dim id As String = TextBox1.Text
        cmd.CommandText = "update lawyer set status= @newstatus where lawyer_id=@id"
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@newstatus", NewStatus)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("updated succefully")
            TextBox1.Clear()
            display_grid()

        Catch ex As Exception
            MsgBox("error: " + ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmManager.Show()

    End Sub
End Class
