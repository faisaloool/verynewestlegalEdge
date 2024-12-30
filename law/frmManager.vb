Imports System.Data
Imports System.Data.SqlClient
Public Class frmManager
    Dim cmd As New SqlCommand
    Dim i As Int32
    Public x As String
    Public vLawyerID As String



    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        displayData()
        GroupBox1.Enabled = False
    End Sub

    Public Sub fillForm(name As String, email As String, phone As String, birthdate As String, nationality As String, address As String, role As String, lawyerID As String, password As String)
        lblAddress.Text = lblAddress.Tag + address
        lblBirthdate.Text = lblBirthdate.Tag + birthdate
        lblEmail.Text = lblEmail.Tag + email
        lblManagerName.Text = lblManagerName.Tag + name
        lblPhone.Text = lblPhone.Tag + phone
        lblRole.Text = lblRole.Tag + role
        lblNationality.Text = lblNationality.Tag + nationality
        lblLawyerID.Text = lblLawyerID.Tag + lawyerID

        frmAddCase.LawyerID = lawyerID

        frmUpdatePassword.oldPassword = password
        frmUpdatePassword.SignedInID = lawyerID
        frmEditCase.LawyerID = lawyerID
    End Sub
    Public Sub displayData()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Case_ID, Title, Client_ID from [Case] where Lawyer_ID = " & CurrentUserID & ""
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

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmUpdatePassword.Role = "M"
        frmUpdatePassword.Show()
        Me.Hide()
    End Sub

    Private Sub NewCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCaseToolStripMenuItem.Click
        frmAddCase.PreviousForm = "M"
        frmAddCase.Show()
        Me.Hide()
    End Sub

    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click
        frmAddClient.PreviousForm = "M"
        frmAddClient.Show()
        Me.Hide()

    End Sub

    Private Sub NewLawyerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewLawyerToolStripMenuItem.Click
        frmAddLawyer.Show()
        Me.Hide()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        frmEditCase.PreviousForm = "M"
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from [case] where Case_ID = " & i & ""
        'cmd.ExecuteNonQuery()
        Dim dr As SqlClient.SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        dr.Read()
        frmEditCase.fillForm(dr("Description").ToString(), "meow", dr("Start_Date").ToString(), dr("End_Date").ToString(), dr("Decision").ToString(), dr("Case_Type").ToString(), dr("Remaining_Costs").ToString(), dr("Cost_Paid").ToString(), "meow", dr("Title").ToString(), dr("Lawyer_ID").ToString(), Convert.ToInt32(dr("Client_ID")))
        dr.Close()


        frmEditCase.Show()
        Me.Hide()
    End Sub

    Private Sub AllSessionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllSessionsToolStripMenuItem.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT * FROM [Session]"

            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            frmShowSessions.DataGridView1.DataSource = dt
            frmShowSessions.lRole = "M"
            frmShowSessions.Show()
            Me.Hide()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MySessionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MySessionsToolStripMenuItem.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT s.* FROM [Session] s JOIN [Case] c ON s.Case_ID = c.Case_ID WHERE c.Lawyer_ID = " & x & ""

            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            frmShowSessions.DataGridView1.DataSource = dt
            frmShowSessions.lRole = "M"
            frmShowSessions.Show()
            Me.Hide()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub NewSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSessionToolStripMenuItem.Click
        Form6.PreviousForm = "M"
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendEMessage()
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class