Imports System.Data.SqlClient

Public Class DHistorial

    Dim ConexionH As New DataClasses1DataContext()
    'Dim Query
    Event Errores(ByVal Pacientes As String)

    Private _Id As Integer
    Private _Codigo_Historial As String
    Private _Identidad As String
    Private _Paciente As String
    Private _Sexo As String
    Private _Edad As Integer
    Private _Telefono As String
    Private _Motivo_Consulta As String
    Private _Fecha As String
    Private _Antecedentes_Personales As String
    Private _Antecedentes_Familiares As String
    Private _HEA As Integer
    Private _Examen_Fisico As String
    Private _Examen_Complementario As String
    Private _PA As Integer
    Private _FC As Integer
    Private _FR As Integer
    Private _T As Integer
    Private _Peso As Integer
    Private _Diagnostico As String
    Private _Tratamiento As String

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Codigo_Historial() As String
        Get
            Return _Codigo_Historial
        End Get
        Set(ByVal value As String)
            _Codigo_Historial = value
        End Set
    End Property

    Public Property Identidad() As String
        Get
            Return _Identidad
        End Get
        Set(ByVal value As String)
            _Identidad = value
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
    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property

    Public Property Edad() As Integer
        Get
            Return _Edad
        End Get
        Set(ByVal value As Integer)
            _Edad = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Motivo_Consulta() As String
        Get
            Return _Motivo_Consulta
        End Get
        Set(ByVal value As String)
            _Motivo_Consulta = value
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

    Public Property Antecedentes_Personales() As String
        Get
            Return _Antecedentes_Personales
        End Get
        Set(ByVal value As String)
            _Antecedentes_Personales = value
        End Set
    End Property

    Public Property Antecedentes_Familiares() As String
        Get
            Return _Antecedentes_Familiares
        End Get
        Set(ByVal value As String)
            _Antecedentes_Familiares = value
        End Set
    End Property

    Public Property HEA() As String
        Get
            Return _HEA
        End Get
        Set(ByVal value As String)
            _HEA = value
        End Set
    End Property

    Public Property Examen_Fisico() As String
        Get
            Return _Examen_Fisico
        End Get
        Set(ByVal value As String)
            _Examen_Fisico = value
        End Set
    End Property

    Public Property Examen_Complementario() As String
        Get
            Return _Examen_Complementario
        End Get
        Set(ByVal value As String)
            _Examen_Complementario = value
        End Set
    End Property

    Public Property PA() As String
        Get
            Return _PA
        End Get
        Set(ByVal value As String)
            _PA = value
        End Set
    End Property

    Public Property FC() As String
        Get
            Return _FC
        End Get
        Set(ByVal value As String)
            _FC = value
        End Set
    End Property

    Public Property FR() As String
        Get
            Return _FR
        End Get
        Set(ByVal value As String)
            _FR = value
        End Set
    End Property

    Public Property T() As String
        Get
            Return _T
        End Get
        Set(ByVal value As String)
            _T = value
        End Set
    End Property

    Public Property Peso() As String
        Get
            Return _Peso
        End Get
        Set(ByVal value As String)
            _Peso = value
        End Set
    End Property

    Public Property Diagnostico() As String
        Get
            Return _Diagnostico
        End Get
        Set(ByVal value As String)
            _Diagnostico = value
        End Set
    End Property

    Public Property Tratamiento() As String
        Get
            Return _Tratamiento
        End Get
        Set(ByVal value As String)
            _Tratamiento = value
        End Set
    End Property
    Public Sub Insertar_Historial(ByVal Codigo_Historial As String, ByVal Identidad As String, ByVal Paciente As String, ByVal Sexo As String, ByVal Edad As Integer, ByVal Telefono As String, ByVal Motivo_Consulta As String, ByVal Fecha As String, ByVal Antecedentes_Personales As String, ByVal Antecedentes_Familiares As String, ByVal HEA As String, ByVal Examen_Fisico As String, ByVal Examen_Complementario As String, ByVal PA As Integer, ByVal FC As Integer, ByVal FR As Integer, ByVal T As Integer, ByVal Peso As Integer, ByVal Diagnostico As String, ByVal Tratamiento As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Historial With {
            .Codigo_Historial = Codigo_Historial,
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Sexo = Sexo,
            .Edad = Edad,
            .Telefono = Telefono,
            .Motivo_Consulta = Motivo_Consulta,
            .Fecha = Fecha,
            .Antecedentes_Personales = Antecedentes_Personales,
            .Antecedentes_Familiares = Antecedentes_Familiares,
            .HEA = HEA,
            .Examen_Fisico = Examen_Fisico,
            .Examenes_Complementarios = Examen_Complementario,
            .PA = PA,
            .FC = FC,
            .FR = FR,
            .T = T,
            .Peso = Peso,
            .Diagnostico = Diagnostico,
            .Tratamiento = Tratamiento
        }
        ConexionH.Historial.InsertOnSubmit(Servicionuevo)
        ConexionH.SubmitChanges()

    End Sub

    Public Sub Editar_Historial(ByVal IdHistorial As Integer, ByVal Codigo_Historial As String, ByVal Identidad As String, ByVal Paciente As String, ByVal Sexo As String, ByVal Edad As String, ByVal Telefono As String, ByVal Motivo_Consulta As String, ByVal Fecha As String, ByVal Antecedentes_Personales As String, ByVal Antecedentes_Familiares As String, ByVal HEA As String, ByVal Examen_Fisico As String, ByVal Examen_Complementario As String, ByVal PA As Integer, ByVal FC As Integer, ByVal FR As Integer, ByVal T As Integer, ByVal Peso As Integer, ByVal Diagnostico As String, ByVal Tratamiento As String)


        Dim modificar = (From n In ConexionH.Historial Where n.Id = IdHistorial Select n).Single
        modificar.Id = IdHistorial
        modificar.Codigo_Historial = Codigo_Historial
        modificar.Identidad = Identidad
        modificar.Paciente = Paciente
        modificar.Sexo = Sexo
        modificar.Edad = Edad
        modificar.Telefono = Telefono
        modificar.Motivo_Consulta = Motivo_Consulta
        modificar.Fecha = Fecha
        modificar.Antecedentes_Personales = Antecedentes_Personales
        modificar.Antecedentes_Familiares = Antecedentes_Familiares
        modificar.HEA = HEA
        modificar.Examen_Fisico = Examen_Fisico
        modificar.Examenes_Complementarios = Examen_Complementario
        modificar.PA = PA
        modificar.FC = FC
        modificar.FR = FR
        modificar.T = T
        modificar.Peso = Peso
        modificar.Diagnostico = Diagnostico
        modificar.Tratamiento = Tratamiento


        ConexionH.SubmitChanges()

    End Sub

    Sub Buscar(ByVal datagrid As DataGridView, ByVal parametro As String)

        Dim constr As String

        constr = Conexion.Cadena



        Dim con As New SqlConnection(constr)

        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select Codigo_Historial, Paciente, Fecha, Motivo_Consulta from Historial Where Paciente like'" & parametro & "'", con)



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



    End Sub


End Class

