Imports System.Net.Http
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports MimeKit
Imports System.Net.Mail

Public Class meow

    Public Sub SendMessage(token As String, phoneId As String, recipientPhone As String)
        Try


            ' قالب الرسالة
            Dim templateName As String = "hello_world"

            ' رابط الـ API
            Dim url As String = $"https://graph.facebook.com/v16.0/{phoneId}/messages"

            ' إعداد بيانات الطلب
            Dim payload As New With {
            Key .messaging_product = "whatsapp",
            .to = recipientPhone,
            .type = "template",
            .template = New With {
                Key .name = templateName,
                .language = New With {
                    Key .code = "en_US"
                }
            }
        }

            ' تحويل البيانات إلى JSON
            Dim jsonPayload As String = JsonConvert.SerializeObject(payload)
            Dim content As New StringContent(jsonPayload, Encoding.UTF8, "application/json")

            ' إعداد الطلب
            Using client As New HttpClient()
                client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Bearer", token)
                Dim response = client.PostAsync(url, content).Result

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Message sent successfully!")
                Else
                    Dim errorContent = response.Content.ReadAsStringAsync().Result
                    MessageBox.Show($"Error: {errorContent}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Exception: {ex.Message}")
        End Try
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim accessToken As String = "EAAITKI5VXNMBO0gMnZCmjKk2bnyfkSZBVVKssUrZBWyCfa5NYcpDxvuczoZBBOK9GSomMZCjN1FfTjvOI2zDnlRmLSu1ZAyZAg8od3BXkqSO5ZBXNXXHgQNtK7e7KswxdIASKTnks2I4a0ZBFwUj9Ed5dtnn11ffybqdMf4G7lcYgAwkr5cPOw0U36DZAxPUrn149xGJ8aKjFHmYfwc5k9sYKlYjOXF8CzaId2k5oZD" ' ادخل Access Token
        Dim phoneNumberId As String = "500022413198514"
        Dim toPhoneNumber As String = "962795411463"
        SendMessage(accessToken, phoneNumberId, toPhoneNumber)
    End Sub
End Class