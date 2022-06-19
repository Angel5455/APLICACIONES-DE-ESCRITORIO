Imports EasyTCPLib.Managed

Public Class IHCAFE_CHAT

    Private WithEvents cl As New ManagedClient
    Dim nick As String


    Private Sub IHCAFE_CHAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        nick = InputBox("Ingrese Nombre de Usuario", "IHCAFE_CHAT", "USERS" + New Random().Next(1, 2000000).ToString)
        '  cl.Connect("127.0.0.1", 8000)
        Control.CheckForIllegalCrossThreadCalls = False


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cl.Send(nick + "|." + TextBox1.Text)
        TextBox1.Text = ""

    End Sub

    Dim html As String

    Private Sub cl_datareceived(ByVal sender As Object, ByVal e As EasyTCPLib.Managed.DataReceivedArgs) Handles cl.DataReceived

        Dim txt As String = e.Value.ToString()
        Dim txt1 As String = txt.Substring(txt.IndexOf("|." + 2))


    End Sub


End Class