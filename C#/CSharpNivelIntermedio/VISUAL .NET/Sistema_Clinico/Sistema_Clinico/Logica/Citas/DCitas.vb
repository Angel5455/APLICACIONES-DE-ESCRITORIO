Imports System.Data.SqlClient

Public Class DCitas
    Dim ConexionC As New DataClasses1DataContext()
    Dim Query
    Event Errores(ByVal Pacientes As String)

    'Private _Id As Integer
    'Private _Fecha As Date
    'Private _Paciente As String
    'Private _Identidad As String
    'Private _Hora As String
    'Private _Observaciones As String
    'Private _Estado As String

    'Public Property Id() As Integer
    '    Get
    '        Return _Id
    '    End Get
    '    Set(ByVal value As Integer)
    '        _Id = value
    '    End Set
    'End Property



    'Public Property Fecha() As Date
    '    Get
    '        Return _Fecha
    '    End Get
    '    Set(ByVal value As Date)
    '        _Fecha = value
    '    End Set
    'End Property

    'Public Property Paciente() As String
    '    Get
    '        Return _Paciente
    '    End Get
    '    Set(ByVal value As String)
    '        _Paciente = value
    '    End Set
    'End Property

    'Public Property Identidad() As String
    '    Get
    '        Return _Identidad
    '    End Get
    '    Set(ByVal value As String)
    '        _Identidad = value
    '    End Set
    'End Property

    'Public Property Hora() As String
    '    Get
    '        Return _Hora
    '    End Get
    '    Set(ByVal value As String)
    '        _Hora = value
    '    End Set
    'End Property

    'Public Property Observaciones() As String
    '    Get
    '        Return _Observaciones
    '    End Get
    '    Set(ByVal value As String)
    '        _Observaciones = value
    '    End Set
    'End Property

    'Public Property Estado() As String
    '    Get
    '        Return _Estado
    '    End Get
    '    Set(ByVal value As String)
    '        _Estado = value
    '    End Set
    'End Property


    Public Sub Insertar_Cita(ByVal Paciente As String, ByVal Identidad As String, ByVal Fecha As Date, ByVal Hora As String, ByVal Observaciones As String, ByVal Estado As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Citas With {
            .Paciente = Paciente,
            .Identidad = Identidad,
            .Fecha = Fecha,
            .Hora = Hora,
            .Observaciones = Observaciones,
            .Estado = Estado
        }
        ConexionC.Citas.InsertOnSubmit(Servicionuevo)
        ConexionC.SubmitChanges()

    End Sub

    Sub Buscar(ByVal datagrid As DataGridView, ByVal parametro As String)

        If (parametro = "Buscar Pacientes" Or parametro = "") Then
            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Citas Where Paciente like'%" & "" & "%'", con)



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

            Dim da As New SqlDataAdapter("Select * from Citas Where Paciente like'%" & parametro & "%'", con)



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

    Public Sub Editar_Cita(ByVal Id As Integer, ByVal Paciente As String, ByVal Identidad As String, ByVal Fecha As Date, ByVal Hora As String, ByVal Observaciones As String, ByVal Estado As String)


        Dim modificar = (From n In ConexionC.Citas Where n.Id = Id Select n).Single
        modificar.Id = Id
        modificar.Paciente = Paciente
        modificar.Identidad = Identidad
        modificar.Fecha = Fecha
        modificar.Hora = Hora
        modificar.Observaciones = Observaciones
        modificar.Estado = Estado

        ConexionC.SubmitChanges()

    End Sub

    Sub Eliminar(ByVal id As Integer)
        Try
            Query = (From n In ConexionC.Citas Where n.Id = id Select n).Single

            ConexionC.Calendario.DeleteOnSubmit(Query)

            ConexionC.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Secuencia no contiene Elementos" Then
                RaiseEvent Errores("Seleccione el contacto que desea eliminar luego presione eliminar")
            Else
                RaiseEvent Errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try
    End Sub

End Class
