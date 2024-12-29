﻿Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frmLawyer
    Dim cmd As New SqlCommand
    Dim i As Int32
    Public x As String
    Private Sub frmLawyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        displayData()
        GroupBox1.Enabled = False
    End Sub
    Public Sub displayData()

        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select Case_ID, Title, Client_ID from [Case] where Lawyer_ID = " & x & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error in frmLawyer in line 0008")
        End Try
    End Sub
    Public Sub fillForm(name As String, email As String, phone As String, birthdate As String, nationality As String, address As String, role As String, lawyerID As String, password As String)
        lblAddress.Text = lblAddress.Tag + address
        lblBirthdate.Text = lblBirthdate.Tag + birthdate
        lblEmail.Text = lblEmail.Tag + email
        lblName.Text = lblName.Tag + name
        lblPhone.Text = lblPhone.Tag + phone
        lblRole.Text = lblRole.Tag + role
        lblNationality.Text = lblNationality.Tag + nationality
        lblLawyerID.Text = lblLawyerID.Tag + lawyerID

        frmAddCase.LawyerID = lawyerID

        frmUpdatePassword.oldPassword = password
        frmUpdatePassword.SignedInID = lawyerID
        frmEditCase.LawyerID = lawyerID
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmUpdatePassword.Role = "L"
        frmUpdatePassword.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click
        frmAddClient.PreviousForm = "L"
        frmAddClient.Show()
        Me.Hide()
    End Sub

    Private Sub NewCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCaseToolStripMenuItem.Click
        frmAddCase.PreviousForm = "L"
        frmAddCase.Show()
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
            MessageBox.Show("Please Click A Valid Row.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GroupBox1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update [Case] set description = '" + TextBox3.Text + "', Cost_Paid = '" + TextBox4.Text + "', Remaining_Costs = '" + TextBox5.Text + "', Decision = '" + TextBox6.Text + "' where Case_ID = " & i & ""
        cmd.ExecuteNonQuery()
        displayData()
        MessageBox.Show("Record Updated Successfully")
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        frmEditCase.PreviousForm = "L"
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

End Class