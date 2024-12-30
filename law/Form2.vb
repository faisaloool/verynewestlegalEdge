Imports System.Data.SqlClient

Public Class Form2
    Dim cmd As SqlCommand

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        display_grid()
    End Sub

    Private Sub display_grid()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "SELECT Consaultation.id, client.name FROM Consaultation JOIN client ON Consaultation.client_id = client.client_id WHERE Consaultation.status = 'false'"
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error displaying data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respond As String = TextBox2.Text
        Dim consID As Integer = Convert.ToInt32(Label3.Text)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand
        cmd.CommandText = "update consaultation set respond_text=@respond, status='true' where id=@id"
        cmd.Parameters.Add("@respond", SqlDbType.VarChar).Value = respond
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = consID

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Respond sent")
        Catch ex As Exception
            MsgBox("error " + ex.Message)
        End Try
        display_grid()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Try
                Dim constID As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
                RetrieveCaseData(constID)
            Catch ex As Exception
                MsgBox("Please select a valid row.")
            End Try
        End If
        Label3.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Sub RetrieveCaseData(constID As Integer)
        Dim query As String = "SELECT consaultation_text FROM consaultation WHERE id = @constID"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@constID", constID)

        Try
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim conText As String = reader("consaultation_text").ToString()
                    TextBox1.Text = conText
                    TextBox1.ReadOnly = True
                Else
                    MsgBox("No data found for the selected consaultation ID.")
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class
