
Imports System.Data.SqlClient

Public Class F_Backup

    Dim Conexion As New SqlConnection("SERVER=.; DATABASE=SystemLetona; Uid=sa; Pwd=root")

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim Nombre_Copia As String = (Date.Today.Day.ToString) & "-" & (Date.Today.Month.ToString) & "-" & (Date.Today.Year.ToString)
        Dim Comando_Consulta As String = "BACKUP DATABASE [SystemLetona] TO  DISK = N'C:\Copias\" & Nombre_Copia & "' WITH NOFORMAT, NOINIT,  NAME = N'SystemLetona-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
"
        Dim cmd As SqlCommand = New SqlCommand(Comando_Consulta, Conexion)

        Try
            Conexion.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Copia de Seguridad Creada", MsgBoxStyle.Exclamation, "Consultorio Letona")

        Catch ex As Exception
            MsgBox("Error, intente de nuevo cerrando primero la ventana de Backup", MsgBoxStyle.Critical, "Consultorio Letona")
        End Try



    End Sub
End Class