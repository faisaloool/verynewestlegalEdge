Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmAddCase
    Public PreviousForm As String
    Dim cmd As New SqlCommand
    Public LawyerID As Int32

    Private Sub frmAddCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboCaseType.Items.Clear()
        comboCaseType.Items.Add("Criminal")
        comboCaseType.Items.Add("Civil")
        comboCaseType.Items.Add("Administrative")
        comboCaseType.Items.Add("Business and Corporate")
        comboCaseType.Items.Add("Environmental")
        comboCaseType.Items.Add("Tax")
        comboCaseType.Items.Add("International")

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If PreviousForm = "L" Then
            frmLawyer.Show()
            Me.Close()
        ElseIf PreviousForm = "M" Then
            frmManager.Show()
            Me.Close()
        Else
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            Dim clientID As Int32 = Val(txtClientID.Text)

            cmd.CommandText = "insert into [Case] values ('" & clientID & "', '" + Convert.ToString(txtLawyerID.Text) + "', '" + txtStartDate.Text + "', '" + txtEndDate.Text + "', '" + comboCaseType.Text + "', '" + txtDecision.Text + "', '" + txtDescription.Text + "', '" + txtPaidCost.Text + "', '" + txtRemainingCost.Text + "', '" + txtTitle.Text + "')"

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class