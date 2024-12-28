Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frmEditCase
    Public PreviousForm As String
    Public CASEID As Int32
    Public LawyerID As Int32


    Dim cmd As New SqlCommand



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

    Private Sub btnuploadDoc_Click(sender As Object, e As EventArgs) Handles btnuploadDoc.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtSelectedFilePath.Text = OpenFileDialog1.FileName
        End If


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        'the following code to upload the file to the db
        Dim filePath As String = txtSelectedFilePath.Text
        If txtSelectedFilePath.Text = "" Then

        Else
            Dim fileData As Byte() = File.ReadAllBytes(filePath)
            Dim fileName As String = Path.GetFileName(filePath)
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            'cmd.CommandText = "insert into [File] values ('" & fileName & "', '" & "0x" & BitConverter.ToString(fileData).Replace("-", "") & "', '" & CASEID & "')"
            cmd.CommandText = "insert into [File] (File_Name, File_Data, Case_ID) values ('" & fileName & "', @fileData, '" & CASEID & "')"


            cmd.Parameters.Add("@fileData", SqlDbType.VarBinary).Value = fileData

            cmd.ExecuteNonQuery()
        End If
        'the following code is to upload the rest of case attributes to table case
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        Dim clientID As Int32 = Val(txtClientID.Text)
        cmd.CommandText = "insert into [Case] values ('" & clientID & "', '" & LawyerID & "', '" + txtStartDate.Text + "', '" + txtEndDate.Text + "', '" + comboCaseType.Text + "', '" + txtDecision.Text + "', '" + txtDescription.Text + "', '" + txtPaidCost.Text + "', '" + txtRemainingCost.Text + "', '" + txtTitle.Text + "')"
        cmd.ExecuteNonQuery()


        Try



        Catch ex As Exception
            MessageBox.Show("fuck you :)")
        End Try

    End Sub
End Class