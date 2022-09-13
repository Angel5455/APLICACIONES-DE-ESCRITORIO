Imports System.Data.SqlClient
Imports System.IO

Public Class F_AgregarDocumentos

    Dim WithEvents Queryconsultas As New DDocumentos
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim Query

    Dim encontrado As Boolean

    Dim resultado As MsgBoxResult

    Public CARPETA As String
    Public PACIENTE As String
    Private Sub F_Documentos_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub F_AgregarDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.Text = "Editar Documento" Or LblOpcion.Text = "Editar" Or Me.Text = "Editar Informe" Then



            Dim ConexionDoc As New CConexion
            Dim Sql As New DataSet

            Sql = ConexionDoc.Consultar("SELECT * FROM DOCUMENTOS WHERE Id='" & LblId.Text & "'")

            TxtPaciente.Text = Sql.Tables(0).Rows(0).Item("Paciente")
            TxtFecha.Text = Sql.Tables(0).Rows(0).Item("Fecha")
            TxtDescripcion.Text = Sql.Tables(0).Rows(0).Item("Descripcion")
            ObtenerImagen()

        End If


    End Sub

    Sub Limpiar()
        TxtPaciente.Clear()
        TxtDescripcion.Clear()

        Dim Logo As String
        Logo = "\img\Usuarios\Usuario.png"

        PicFoto.Load(Application.StartupPath & Logo)



    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        If LblOpcion.Text = "Agregar" Or Me.Text = "Agregar Documento" Or Me.Text = "Agregar Informe - Laboratorio" Then

            If TxtPaciente.Text = "" Then

                MsgBox("Busque el nombre del Paciente", MsgBoxStyle.Exclamation, "Consultorio Letona")

            Else

                Call Queryconsultas.Insertar_Documento(TxtPaciente.Text, TxtFecha.Text, TxtDescripcion.Text, ConvertImage.ImageToByteArray(PicFoto.Image))
                MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")


                My.Settings.Ruta = "AgregarDoc"
                My.Settings.Save()
                My.Settings.Reload()

                F_Historial.Consulta()

                If LblOpcion.Text = "Agregar" Then

                    F_Historial.Consulta()

                    Limpiar()
                    Me.Close()

                ElseIf Me.Text = "Agregar Documento" Then
                    F_Documentos.Close()
                    Abrir_FormulariosHijos(New F_Documentos)

                    Limpiar()
                    Me.Close()

                ElseIf Me.Text = "Agregar Informe - Laboratorio" Then
                    F_Laboratorio.Close()
                    Abrir_FormulariosHijos(New F_Laboratorio)

                    Limpiar()
                    Me.Close()

                End If

            End If



        ElseIf LblOpcion.Text = "Editar" Or Me.Text = "Editar Documento" Or Me.Text = "Editar Informe" Then

            Call Queryconsultas.Editar_Documento(LblId.Text, TxtPaciente.Text, TxtFecha.Text, TxtDescripcion.Text, ConvertImage.ImageToByteArray(PicFoto.Image))
            MessageBox.Show("Los Datos fueron modificados con exito", "Datos Guardados...")


            If LblOpcion.Text = "Editar" Then

                My.Settings.Ruta = "EditarH"
                My.Settings.Save()
                My.Settings.Reload()


                'F_Historial.Close()
                'Abrir_FormulariosHijos(New F_Historial)
                F_Historial.Consulta()
                Limpiar()
                Me.Close()

            ElseIf Me.Text = "Editar Documento" Then

                F_Documentos.Close

                Abrir_FormulariosHijos(New F_Documentos)
                Limpiar()
                Me.Close()
            ElseIf Me.Text = "Editar Informe" Then

                F_Laboratorio.Close()

                Abrir_FormulariosHijos(New F_Laboratorio)
                F_Laboratorio.Query.Buscar_Documento(F_Laboratorio.DataGridView1, "")
                Limpiar()
                Me.Close()

            End If

        End If




    End Sub

    Private FormularioActual As Form = Nothing
    Private Sub Abrir_FormulariosHijos(FormularioHijo As Form)

        If FormularioActual IsNot Nothing Then FormularioActual.Close()
        FormularioActual = FormularioHijo

        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        Form1.PanelFormularioHijo.Controls.Add(FormularioHijo)
        Form1.PanelFormularioHijo.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()



    End Sub

    Private Sub F_AgregarDocumentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Limpiar()

        My.Settings.Ruta = ""
        My.Settings.Save()
        My.Settings.Reload()

        If Me.Text = "Agregar Documento" Or Me.Text = "Editar Documento" Then
            Abrir_FormulariosHijos(New F_Documentos)
        Else
            Abrir_FormulariosHijos(New F_Informes)
        End If
    End Sub

    Private Sub BtnFoto_Click(sender As Object, e As EventArgs) Handles BtnFoto.Click
        Dim file As New OpenFileDialog With {
          .Filter = "Archivo JPG|*.jpg"
      }
        If file.ShowDialog() = DialogResult.OK Then
            PicFoto.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Public Sub ObtenerImagen()
        Dim connect As New SqlConnection("Server=localhost;database=SystemLetona;integrated security=true")
        Dim command As New SqlCommand("Select Documento from Documentos where Id= @Id", connect)
        command.Parameters.AddWithValue("@Id", LblId.Text)
        'Representa un set de comandos que es utilizado para llenar un DataSet
        Dim dp As New SqlDataAdapter(command)
        'Representa un caché (un espacio) en memoria de los datos.
        Dim ds As New DataSet("Documentos")

        'Arreglo de byte en donde se almacenara la foto en bytes
        Dim MyData(0 To 0 - 1) As Byte

        'Llenamosel DataSet con la tabla. cliente es nombre de la tabla
        dp.Fill(ds, "Documentos")
        'Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
        Dim myRow As DataRow = ds.Tables("Documentos").Rows(0)
        'Se almacena el campo foto de la tabla en el arreglo de bytes
        MyData = CType(myRow("Documento"), Byte())
        'Se inicializa un flujo en memoria del arreglo de bytes
        Dim stream As New MemoryStream(MyData)
        'En el picture box se muestra la imagen que esta almacenada en el flujo en memoria
        'el cual contiene el arreglo de bytes
        Me.PicFoto.Image = Image.FromStream(stream)
    End Sub

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        F_BuscarPaciente.Text = "Buscar Paciente - Documentos"
        F_BuscarPaciente.Show()

    End Sub

    Private Sub BtnCaptura_Click(sender As Object, e As EventArgs) Handles BtnCaptura.Click

        If TxtPaciente.Text <> "" Then

            CARPETA = "C:\SystemLetona\PLaboratorio\"
            PACIENTE = TxtPaciente.Text


            F_Captura.Opacity = 0.5
            Form1.Hide()
            F_Captura.Show()
            Me.Close()
            'Me.WindowState = FormWindowState.Minimized
        Else
            MsgBox("Ingrese nombre del paciente primero", MsgBoxStyle.Exclamation, "Consultorio Letona")
        End If

    End Sub

    Private Sub PicFoto_Click(sender As Object, e As EventArgs) Handles PicFoto.Click
        F_Ver.VerPicFoto.Image = PicFoto.Image
        F_Ver.ShowDialog()
    End Sub
End Class