Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frmEditCase
    Public PreviousForm As String
    Public CASEID As Int32
    Public LawyerID As Int32


    Dim cmd As New SqlCommand
    Public Sub fillForm(Description As String, statement As String, stdate As String, endDate As String, decision As String, casetype As String, remainingcost As String, paidcoast As String, email As String, title As String, lawyerid As String, clientid As Int32)
        txtDescription.Text = Description
        comboStatement.Text = statement
        txtStartDate.Text = stdate
        txtEndDate.Text = endDate
        txtDecision.Text = decision
        comboCaseType.Text = casetype
        txtRemainingCost.Text = remainingcost
        txtPaidCost.Text = paidcoast
        txtEmail.Text = email
        txtTitle.Text = title
        txtLawyerID.Text = lawyerid
        txtClientID.Text = clientid.ToString()

    End Sub

    Private Sub DownloadFile()
        '' Define the SQL connection and query
        'If con.State = ConnectionState.Open Then
        '    con.Close()
        'End If
        'con.Open()

        'cmd = con.CreateCommand()
        'cmd.CommandType = CommandType.Text

        'cmd.CommandText = "SELECT file_data FROM [File] WHERE Id = @file_id"

        'cmd.Parameters.AddWithValue("@file_id", 1) ' Example file_id


        'Dim fileData As Byte() = CType(cmd.ExecuteScalar(), Byte())

        '' Write the data to a temporary file
        'Dim filePath As String = Path.Combine(Path.GetTempPath(), "DownloadedFile")
        'File.WriteAllBytes(filePath, fileData)

        '' Open the file
        'Process.Start(filePath)

    End Sub
    Private Sub frmEditCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboCaseType.Items.Clear()
        comboCaseType.Items.Add("Criminal")
        comboCaseType.Items.Add("Civil")
        comboCaseType.Items.Add("Administrative")
        comboCaseType.Items.Add("Business and Corporate")
        comboCaseType.Items.Add("Environmental")
        comboCaseType.Items.Add("Tax")
        comboCaseType.Items.Add("International")

        comboStatement.Items.Clear()
        comboStatement.Items.Add("Active")
        comboStatement.Items.Add("Closed")
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If PreviousForm = "M" Then
            frmManager.Show()
            Me.Close()
        ElseIf PreviousForm = "L" Then
            frmLawyer.Show()
            Me.Close()
        Else
            MessageBox.Show("An Error Occured")
        End If
    End Sub

    Private Sub btnuploadDoc_Click(sender As Object, e As EventArgs) Handles btnuploadDoc.Click
        Try

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                txtSelectedFilePath.Text = OpenFileDialog1.FileName
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
            End If

        Catch ex As Exception
            MessageBox.Show("Error when file loaded to the database")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()


            'the following code is to upload the rest of case attributes to table case
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            Dim clientID As Int32 = Val(txtClientID.Text)
            cmd.CommandText = "update [Case] set Client_ID = '" & clientID & "', Lawyer_ID = '" & LawyerID & "', Start_Date = '" + txtStartDate.Text + "', End_Date = '" + txtEndDate.Text + "', Case_Type = '" + comboCaseType.Text + "', Decision = '" + txtDecision.Text + "', Description = '" + txtDescription.Text + "', Cost_Paid = '" + txtPaidCost.Text + "', Remaining_Costs = '" + txtRemainingCost.Text + "', Title = '" + txtTitle.Text + "' where Case_ID = " & CASEID & ""
            cmd.ExecuteNonQuery()

            frmLawyer.displayData()

            MessageBox.Show("Upadated Successfully.")

            If PreviousForm = "M" Then
                frmManager.Show()
                Me.Close()
            ElseIf PreviousForm = "L" Then
                frmLawyer.Show()
                Me.Close()
            Else
                MessageBox.Show("An Error Occured")
            End If
        Catch ex As Exception
            MessageBox.Show("Exception: " + ex.Message)
        End Try

    End Sub
End Class