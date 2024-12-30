Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Globalization
Module Module1

    Public con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\LegalEdgeDatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

    Private cmd As New SqlCommand
    Public CurrentUserID As New Integer
    Public CurrentUserRole As String
    Public LoginStatus As Integer = 0

    Function IsSessionTomorrow(sessionDate As String) As Boolean
        Dim todayDate As String = Date.Today.ToString("dd/MM/yyyy")
        Dim parsedSessionDate As Date = DateTime.ParseExact(sessionDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)
        Dim difference As TimeSpan = parsedSessionDate - Date.Today

        If difference.TotalDays = 1 Then
            Return True
        Else
            Return True
        End If
        Try

        Catch ex As Exception
            MessageBox.Show("ex1: " + ex.Message)
            Return False
        End Try
    End Function
    Private Sub sendEmail(personName As String, email As String)
        Dim mail As New MailMessage()
        Dim smtp As New SmtpClient("smtp.gmail.com")

        mail.From = New MailAddress("legaledge81@gmail.com")
        mail.To.Add(email)
        mail.Subject = "LegalEdge Session Alert"
        mail.Body = "Hello, your session is very near, within 24 hours. We hope you arrive at least 30 minutes before your session."

        smtp.Port = 587
        smtp.Credentials = New Net.NetworkCredential("legaledge81@gmail.com", "bqff aldw psaz jptl")
        smtp.EnableSsl = True

        smtp.Send(mail)
        Try

        Catch ex As Exception
            MessageBox.Show("ex2:" + ex.Message)
        End Try

    End Sub

    Public Sub SendEMessage()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "select * from Session where Email_Status = " & v & ""
        Dim v As String = "False"
        'cmd.CommandText = "SELECT Session.*, Client.Name, Client.Email FROM Session INNER JOIN [Case] ON Session.Case_ID = [Case].Case_ID INNER JOIN Client ON [Case].Client_ID = Client.Client_ID WHERE Session.Email_Status = " & v & ""
        cmd.CommandText = "SELECT Session.*, Client.Name, Client.Email FROM Session INNER JOIN [Case] ON Session.Case_ID = [Case].Case_ID INNER JOIN Client ON [Case].Client_ID = Client.Client_ID WHERE Session.Email_Status = '" & v & "'"

        cmd.ExecuteNonQuery()

        Dim dr As SqlClient.SqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            Dim SessionDate As String = dr("Date")
            Dim isTomorrow As Boolean = IsSessionTomorrow(SessionDate)
            If isTomorrow Then
                sendEmail(dr("name"), dr("Email"))
            End If
        End While
        MessageBox.Show("No Errors :)")
        Try

        Catch ex As Exception
            MessageBox.Show("ex3: " & ex.Message)
        End Try

    End Sub
End Module
