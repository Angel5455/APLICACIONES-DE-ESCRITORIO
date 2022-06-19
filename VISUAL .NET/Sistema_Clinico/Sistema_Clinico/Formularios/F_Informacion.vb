Public Class F_Informacion
    Private Sub F_Informacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblMac.Text = ObtenerMac().ToString
        LblEquipo.Text = My.Computer.Name.ToString

        Dim ip As System.Net.IPHostEntry
        ip = System.Net.Dns.GetHostEntry(My.Computer.Name)
        LblIP.Text = ip.AddressList(0).ToString
        TextBox1.Text = ip.AddressList(0).ToString
    End Sub

    Public Function ObtenerMac() As String

        Dim str As String

        Dim p As New Process

        p.StartInfo.UseShellExecute = False

        p.StartInfo.RedirectStandardOutput = True

        p.StartInfo.FileName = “GetMac.exe”

        p.StartInfo.Arguments = “/fo list”

        p.Start()

        'StandardOutput Obtiene una secuencia que se utiliza

        str = p.StandardOutput.ReadLine

        str = p.StandardOutput.ReadLine

        p.WaitForExit()

        Return str.Substring(23)

    End Function
End Class