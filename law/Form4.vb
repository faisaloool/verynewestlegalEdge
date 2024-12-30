Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Dim cmd As New SqlCommand
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        display_grid()
    End Sub
    Private Sub display_grid()
        cmd = con.CreateCommand()

        If CurrentUserRole = "Lawyer" Or CurrentUserRole = "Manager" Then
            cmd.CommandText = "select Case_ID, title from [case] where Lawyer_ID = @id and status='Closed'"
        Else
            cmd.CommandText = "select Case_ID, title from [case] where Client_ID = @id and status='Closed'"
        End If

        cmd.Parameters.AddWithValue("@id", CurrentUserID)

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
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

        Dim query As String = "SELECT Case_ID, Title, Cost_Paid, Remaining_Costs, Lawyer_ID, Start_Date, End_Date, Decision, Description " &
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
                TextBox2.Text = title
                TextBox3.Text = costPaid.ToString("F2")
                TextBox4.Text = remainingCosts.ToString("F2")
                TextBox5.Text = lawyerID.ToString()
                TextBox6.Text = startDate.ToShortDateString()
                TextBox7.Text = endDate.ToShortDateString()
                TextBox8.Text = decision
            End If
        End Using
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        If CurrentUserRole = "Manager" Then
            frmManager.Show()
        ElseIf CurrentUserRole = "Lawyer" Then
            frmLawyer.Show
        ElseIf CurrentUserRole = "Client" Then
            frmClient.Show()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class