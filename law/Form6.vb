Imports System.Data.SqlClient

Public Class Form6
    Dim cmd As New SqlCommand
    Public PreviousForm As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Session values ('" & txtDate.Text & "', '" & txtTime.Text & "', " & Convert.ToInt32(txtCaseID.Text) & ", '" & txtEmailStatus.Text & "')"

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Inserted Successfully")
            If PreviousForm = "M" Then
                frmManager.Show()
                Me.Close()
            ElseIf PreviousForm = "L" Then
                frmLawyer.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("ex: " + ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PreviousForm = "M" Then
            frmManager.Show()
            Me.Close()
        ElseIf PreviousForm = "L" Then
            frmLawyer.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class