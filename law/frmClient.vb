Imports System.Data
Imports System.Data.SqlClient
Public Class frmClient
    Dim cmd As New SqlCommand
    Dim i As Int32
    Public x As Int32

    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        displayData()
        GroupBox1.Enabled = False
    End Sub
    Public Sub fillForm(name As String, email As String, phone As String, birthdate As String, nationality As String, address As String, nationalID As String)
        lblAddress.Text = lblAddress.Tag + address
        lblBirthdate.Text = lblBirthdate.Tag + birthdate
        lblEmail.Text = lblEmail.Tag + email
        lblName.Text = lblName.Tag + name
        lblPhone.Text = lblPhone.Tag + phone
        lblNationality.Text = lblNationality.Tag + nationality
        lblNationalID.Text = lblNationalID.Tag + nationalID
    End Sub
    Public Sub displayData()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Case_ID, Title, Lawyer_ID from [Case] where Client_ID = " & x & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Try

        Catch ex As Exception
            MessageBox.Show("Error in frmManager in line 46")
        End Try
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmHome.Show()
        Me.Close()
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
            cmd.CommandText = "select client_Id, case_ID, description, Cost_Paid, Remaining_Costs, Decision from [Case] where Case_ID = " & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                TextBox1.Text = dr.GetInt32(0).ToString()
                TextBox2.Text = dr.GetInt32(1).ToString()
                frmEditCase.CASEID = TextBox2.Text
                TextBox3.Text = dr.GetString(2).ToString()
                TextBox4.Text = dr.GetString(3).ToString()
                TextBox5.Text = dr.GetString(4).ToString()
                TextBox6.Text = dr.GetString(5).ToString()
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Please Click A Valid Row.107")
        End Try
    End Sub

    Private Sub PreviousCasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviousCasesToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()

    End Sub
End Class