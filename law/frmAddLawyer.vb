Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frmAddLawyer
    Dim cmd As New SqlCommand
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into lawyer values ('" + txtName.Text + "', '" + txtBirthdate.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + comboGender.Text + "', '" + txtPhone.Text + "', '" + comboRole.Text + "', '" + txtPassword.Text + "', '" + txtNationality.Text + "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Lawyer Inserted Successfully")
            frmManager.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class