Public Class F_Respaldos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase1.accdb", "C:\Fase1.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase2.accdb", "C:\Fase2.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase1.accdb", "C:\Fase3.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase2.accdb", "C:\Fase4.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase1.accdb", "C:\Fase5.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase2.accdb", "C:\Fase6.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase1.accdb", "C:\Fase7.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase2.accdb", "C:\Fase8.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase1.accdb", "C:\Fase9.accdb")
            System.IO.File.Copy("C:\Program Files\ARP\IHCAFE SYSTEM\Fase2.accdb", "C:\Fase10.accdb")
            MsgBox("Bases de datos respaldadas en C:\", MsgBoxStyle.Information, "IHCAFE SYSTEM")
        Catch ex As Exception
            MsgBox("Error realizando el respaldo" & vbNewLine & ex.Message)
        End Try
    End Sub
End Class