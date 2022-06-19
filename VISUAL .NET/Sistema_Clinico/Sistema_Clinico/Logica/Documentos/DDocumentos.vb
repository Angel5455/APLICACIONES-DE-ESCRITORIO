Imports System.Data.SqlClient

Public Class DDocumentos

    Dim ConexionD As New DataClasses1DataContext()
    Dim Query
    Event Errores(ByVal Pacientes As String)

    Private _Id As Integer
    Private _Paciente As String
    Private _Fecha As String
    Private _Descripcion As String
    Private _Foto As Image

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Paciente() As String
        Get
            Return _Paciente
        End Get
        Set(ByVal value As String)
            _Paciente = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Foto() As Image
        Get
            Return _Foto
        End Get
        Set(ByVal value As Image)
            _Foto = value
        End Set
    End Property


    Sub Buscar_Documento(ByVal Datagrid As DataGridView, ByVal Parametro As String)

        If (Parametro = "Buscar Pacientes" Or Parametro = "") Then
            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select Id, Paciente, Fecha from Documentos Where Paciente like'%" & "" & "%'", con)



            Try


                da.Fill(tabla)


                Datagrid.DataSource = tabla


            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing

                da = Nothing


                tabla = Nothing


            End Try

        Else
            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select Id, Paciente, Fecha from Documentos Where Paciente like'%" & Parametro & "%'", con)



            Try


                da.Fill(tabla)


                Datagrid.DataSource = tabla





            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing

                da = Nothing


                tabla = Nothing


            End Try


        End If

    End Sub


    Public Sub Insertar_Documento(ByVal Paciente As String, ByVal Fecha As String, ByVal Descripcion As String, ByVal Foto As Byte())

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Documentos With {
            .Paciente = Paciente,
            .Fecha = Fecha,
            .Descripcion = Descripcion,
            .Documento = Foto
        }
        ConexionD.Documentos.InsertOnSubmit(Servicionuevo)
        ConexionD.SubmitChanges()

    End Sub

    Public Sub Editar_Documento(ByVal Id As Integer, ByVal Paciente As String, ByVal Fecha As String, ByVal Descripcion As String, ByVal Foto As Byte())


        Dim modificar = (From n In ConexionD.Documentos Where n.Id = Id Select n).Single
        modificar.Id = Id
        modificar.Paciente = Paciente
        modificar.Fecha = Fecha
        modificar.Descripcion = Descripcion
        modificar.Documento = Foto

        ConexionD.SubmitChanges()

    End Sub

    Sub Eliminar_Documento(ByVal id As String)

        Try
            Query = (From n In ConexionD.Documentos Where n.Id = id Select n).Single

            ConexionD.Documentos.DeleteOnSubmit(Query)

            ConexionD.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent Errores("Seleccione el documento que desea eliminar luego presione eliminar")
            Else
                RaiseEvent Errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub
End Class
