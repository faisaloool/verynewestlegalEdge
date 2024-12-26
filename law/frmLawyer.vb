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
            cmd.CommandText = "select Case_ID, Client_ID from [Case] where Lawyer_ID = " & x & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("An Error Occurred When Data Load.")
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

        frmUpdatePassword.oldPassword = password
        frmUpdatePassword.SignedInID = lawyerID
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmUpdatePassword.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub NewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewClientToolStripMenuItem.Click
        frmAddClient.Show()
        Me.Hide()
    End Sub

    Private Sub NewCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCaseToolStripMenuItem.Click
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
                TextBox3.Text = dr.GetString(2).ToString()
                TextBox4.Text = dr.GetString(3).ToString()
                TextBox5.Text = dr.GetString(4).ToString()
                TextBox6.Text = dr.GetString(5).ToString()
            End While
        Catch ex As Exception
            MessageBox.Show("Please Click A Valid Row.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        frmEditCase.Show()
        Me.Hide()
    End Sub
End Class