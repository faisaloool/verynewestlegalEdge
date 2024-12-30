Imports System.Data.SqlClient

Public Class Form3
    Dim cmd As New SqlCommand
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        display_grid()
        show_sum()

    End Sub
    Private Sub display_grid()
        cmd = con.CreateCommand
        cmd.CommandText = "SELECT Case_ID, Title, Cost_Paid, Remaining_Costs FROM [Case];"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub show_sum()
        Dim totalRemainingCosts As Decimal = 0
        Dim totalPaidCosts As Decimal = 0

        Dim queryRemainingCosts As String = "SELECT SUM(CAST(Remaining_Costs AS DECIMAL(10, 2))) FROM [Case]"
        Dim queryPaidCosts As String = "SELECT SUM(CAST(Cost_Paid AS DECIMAL(10, 2))) FROM [Case]"
        Dim cmdRemainingCosts As New SqlCommand(queryRemainingCosts, con)
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        totalRemainingCosts = If(cmdRemainingCosts.ExecuteScalar(), 0)
        Dim cmdPaidCosts As New SqlCommand(queryPaidCosts, con)
        totalPaidCosts = If(cmdPaidCosts.ExecuteScalar(), 0)
        con.Close()
        Console.WriteLine("Total Remaining Costs: " & totalRemainingCosts)
        Console.WriteLine("Total Paid Costs: " & totalPaidCosts)
        TextBox1.Text = totalPaidCosts.ToString
        TextBox2.Text = totalRemainingCosts.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmManager.Show()

    End Sub
End Class