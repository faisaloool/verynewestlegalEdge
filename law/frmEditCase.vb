Imports System.Data
Imports System.Data.SqlClient
Public Class frmEditCase
    Public PreviousForm As String


    Private Sub frmEditCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboCaseType.Items.Clear()
        comboCaseType.Items.Add("Criminal")
        comboCaseType.Items.Add("Civil")
        comboCaseType.Items.Add("Administrative")
        comboCaseType.Items.Add("Business and Corporate")
        comboCaseType.Items.Add("Environmental")
        comboCaseType.Items.Add("Tax")
        comboCaseType.Items.Add("International")
    End Sub
    Public Sub fillForm()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If PreviousForm = "Manager" Then
            frmManager.Show()
            Me.Close()
        ElseIf PreviousForm = "Lawyer" Then
            frmLawyer.Show()
            Me.Close()
        End If
    End Sub
End Class