Imports System.Data.SqlClient

Public Class Form5
    Dim cmd As New SqlCommand
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        display_grid()
    End Sub
    Private Sub display_grid()
        cmd = con.CreateCommand
        cmd.CommandText = "select Case_ID,Title,Lawyer_ID from [case] where status='Open'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                Dim caseId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
                RetrieveCaseData(caseId)
            Catch ex As Exception
                MsgBox("select valid row")
            End Try

        End If
    End Sub
    Sub RetrieveCaseData(caseId As Integer)
        Dim costPaid As Decimal
        Dim lawyerID As Integer
        Dim startDate As DateTime
        Dim endDate As DateTime
        Dim title As String
        Dim remainingCosts As Decimal
        Dim decision As String
        Dim description As String

        Dim query As String = "SELECT Cost_Paid, Lawyer_ID, Start_Date, End_Date, Title, Remaining_Costs, Decision, Description " &
                              "FROM [Case] WHERE Case_ID = @Case_ID"

        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Case_ID", caseId)

        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim costPaidString As String = If(reader.IsDBNull(reader.GetOrdinal("Cost_Paid")), String.Empty, reader.GetString(reader.GetOrdinal("Cost_Paid")))
                If Not Decimal.TryParse(costPaidString, costPaid) Then
                    costPaid = 0
                End If

                Dim lawyerIDString As String = If(reader.IsDBNull(reader.GetOrdinal("Lawyer_ID")), String.Empty, reader.GetString(reader.GetOrdinal("Lawyer_ID")))
                If Not Integer.TryParse(lawyerIDString, lawyerID) Then
                    lawyerID = 0
                End If

                Dim startDateString As String = If(reader.IsDBNull(reader.GetOrdinal("Start_Date")), String.Empty, reader.GetString(reader.GetOrdinal("Start_Date")))
                If Not DateTime.TryParse(startDateString, startDate) Then
                    startDate = DateTime.MinValue
                End If

                Dim endDateString As String = If(reader.IsDBNull(reader.GetOrdinal("End_Date")), String.Empty, reader.GetString(reader.GetOrdinal("End_Date")))
                If Not DateTime.TryParse(endDateString, endDate) Then
                    endDate = DateTime.MinValue
                End If

                title = If(reader.IsDBNull(reader.GetOrdinal("Title")), String.Empty, reader.GetString(reader.GetOrdinal("Title")))

                Dim remainingCostsString As String = If(reader.IsDBNull(reader.GetOrdinal("Remaining_Costs")), String.Empty, reader.GetString(reader.GetOrdinal("Remaining_Costs")))
                If Not Decimal.TryParse(remainingCostsString, remainingCosts) Then
                    remainingCosts = 0
                End If

                decision = If(reader.IsDBNull(reader.GetOrdinal("Decision")), String.Empty, reader.GetString(reader.GetOrdinal("Decision")))
                description = If(reader.IsDBNull(reader.GetOrdinal("Description")), String.Empty, reader.GetString(reader.GetOrdinal("Description")))

                TextBox1.Text = caseId.ToString()
                TextBox2.Text = costPaid.ToString("F2")
                TextBox3.Text = lawyerID.ToString()
                TextBox4.Text = startDate.ToShortDateString()
                TextBox5.Text = endDate.ToShortDateString()
                TextBox6.Text = title
                TextBox7.Text = remainingCosts.ToString("F2")
                TextBox8.Text = decision
                TextBox9.Text = description
            End If
        End Using

        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmManager.Show()

    End Sub
End Class
