Imports System.Data.SqlClient

Public Class DPrescripcion

    Dim ConexionP As New DataClasses1DataContext()
    Dim Query
    Event Errores(ByVal Pacientes As String)

    Private _Id As Integer
    Private _Paciente As String
    Private _Fecha As String
    Private _Historia As String
    Private _Medicacion As String
    Private _Nota As String

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

    Public Property Historia() As String
        Get
            Return _Historia
        End Get
        Set(ByVal value As String)
            _Historia = value
        End Set
    End Property

    Public Property Medicacion() As String
        Get
            Return _Medicacion
        End Get
        Set(ByVal value As String)
            _Medicacion = value
        End Set
    End Property

    Public Property Nota() As String
        Get
            Return _Nota
        End Get
        Set(ByVal value As String)
            _Nota = value
        End Set
    End Property

    Sub Buscar_Receta(ByVal datagrid As DataGridView, ByVal parametro As String)

        If (parametro = "Buscar Pacientes" Or parametro = "") Then
            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Prescripcion Where Paciente like'%" & "" & "%'", con)



            Try


                da.Fill(tabla)


                datagrid.DataSource = tabla






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


            Dim da As New SqlDataAdapter("Select * from Prescripcion Where Paciente like'%" & parametro & "%'", con)



            Try


                da.Fill(tabla)


                datagrid.DataSource = tabla





            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing

                da = Nothing


                tabla = Nothing


            End Try


        End If


    End Sub
    Public Sub Insertar_Receta(ByVal Paciente As String, ByVal Fecha As String, ByVal Historia As String, ByVal Medicacion As String, ByVal Nota As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Prescripcion With {
            .Paciente = Paciente,
            .Fecha = Fecha,
            .Historia = Historia,
            .Medicacion = Medicacion,
            .Nota = Nota
        }
        ConexionP.Prescripcion.InsertOnSubmit(Servicionuevo)
        ConexionP.SubmitChanges()

    End Sub

    Public Sub Editar_Receta(ByVal Id As Integer, Paciente As String, ByVal Fecha As String, ByVal Historia As String, ByVal Medicacion As String, ByVal Nota As String)


        Dim modificar = (From n In ConexionP.Prescripcion Where n.Id = Id Select n).Single
        modificar.Id = Id
        modificar.Paciente = Paciente
        modificar.Fecha = Fecha
        modificar.Historia = Historia
        modificar.Medicacion = Medicacion
        modificar.Nota = Nota


        ConexionP.SubmitChanges()

    End Sub

    Sub Eliminar_Receta(ByVal id As String)

        Try
            Query = (From n In ConexionP.Prescripcion Where n.Id = id Select n).Single

            ConexionP.Prescripcion.DeleteOnSubmit(Query)

            ConexionP.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent Errores("Seleccione el documento que desea eliminar luego presione eliminar")
            Else
                RaiseEvent Errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub

End Class
