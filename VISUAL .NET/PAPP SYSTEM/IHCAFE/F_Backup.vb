Imports System.Text
Imports System.Data.SqlClient
Public Class F_Backup

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        If cmbServidor.Text <> "" Then
            If Me.cboBaseDatos.Text <> "" Then
                If txtDirPathBackup.Text <> "" Then
                    If txtNom_Backup.Text <> "" Then
                        If txtDescrip_Backup.Text <> "" Then
                            If crear_backup() = True Then
                                MessageBox.Show("Backup creado satisfactoriamnete", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Error al crear el Backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Ingrese una descripcion del Backup", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("Ingrese el nombre del Backup", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Seleccione la ruta donde se creara el Backup", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Seleccione la Base de Datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Else
            MessageBox.Show("Ingrese el Nombre del Servidor de Datos SQL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function crear_backup() As Boolean

        Dim conecsb As New SqlConnectionStringBuilder
        conecsb.DataSource = Me.cmbServidor.Text
        conecsb.InitialCatalog = "master"
        conecsb.IntegratedSecurity = True

        If txtDirPathBackup.Text.Length <> 3 Then
            txtDirPathBackup.Text = txtDirPathBackup.Text + "\" + txtNom_Backup.Text + ".bak"
        Else
            txtDirPathBackup.Text = txtDirPathBackup.Text + txtNom_Backup.Text + ".bak"
        End If

        Using con As New SqlConnection(conecsb.ConnectionString)
            Try
                con.Open()
                Dim sCmd As New StringBuilder

                sCmd.Append("BACKUP DATABASE [" + cboBaseDatos.Text + "] TO  DISK = N'" + txtDirPathBackup.Text + "' ")
                sCmd.Append("WITH DESCRIPTION = N'" + txtDescrip_Backup.Text + "', NOFORMAT, NOINIT, ")
                sCmd.Append("NAME = N'" + txtNom_Backup.Text + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
                Dim cmd As New SqlCommand(sCmd.ToString, con)
                cmd.ExecuteNonQuery()
                crear_backup = True
            Catch ex As Exception
                crear_backup = False
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End Using



    End Function

    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        Dim Directorio As New FolderBrowserDialog

        If Directorio.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtDirPathBackup.Text = Directorio.SelectedPath
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub F_Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
