Module Module1
    Public sAppPath As String = Application.StartupPath.ToString
    Public sBaseDatos As String = sAppPath & "\datos.mdb"
    Public sConexion As String = "Provider=Microsoft.jet.OLEDB.4.0; Data Source=" & sBaseDatos


    Sub Main()
        Dim flogin As New F_Password
        If flogin.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            flogin.Close()
            Application.Run(New Form1)
        End If
    End Sub
End Module
