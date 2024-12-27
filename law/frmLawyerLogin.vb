Imports System.Data.SqlClient
Imports System.Data
Public Class frmLawyerLogin
    Dim cmd As New SqlCommand
    Dim i As Int32
    Private Sub frmLawyerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        frmContact.Show()
        Me.Hide()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from lawyer where Lawyer_ID = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'"
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("Login Successfully")

                reader.Read()
                If reader("Role") = "Lawyer" Then
                    frmLawyer.fillForm(reader("Name").ToString, reader("Email").ToString, reader("Phone_Number").ToString, reader("Birthdate").ToString, reader("Nationality").ToString, reader("Address").ToString, reader("Role").ToString, reader("Lawyer_ID").ToString, reader("Password").ToString)
                    frmLawyer.x = reader("Lawyer_ID")
                    frmLawyer.Show()
                    Me.Close()
                ElseIf reader("Role") = "Manager" Then
                    frmManager.Show()
                    Me.Hide()
                End If


                reader.Close()
            Else
                    MessageBox.Show("Id / Password Are Incorrect.")
            End If

        Catch ex As Exception
            MessageBox.Show("An Error Occurredxxx")
        End Try
    End Sub

    Private Sub ServeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServeToolStripMenuItem.Click
        frmServices.Show()
        Me.Hide()
    End Sub
End Class