Imports System.Data
Imports System.Data.SqlClient
Public Class frmAddCase
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub frmAddCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Criminal")
        ComboBox1.Items.Add("Civil")
        ComboBox1.Items.Add("Administrative")
        ComboBox1.Items.Add("Business and Corporate")
        ComboBox1.Items.Add("Environmental")
        ComboBox1.Items.Add("Tax")
        ComboBox1.Items.Add("International")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLawyer.Show()
        Me.Hide()
    End Sub
End Class