Imports System.Data.SqlClient

Public Class DDrogas
    Dim ConexionA As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Drogas As String)


    Private _nMuestra As Integer
    Private _IdP As String
    Private _Paciente As String
    Private _Sexo As String


    Private _cadena As String
    Private _conexion As SqlConnection

    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter

    Public Property nMuestra() As Integer
        Get
            Return _nMuestra
        End Get

        Set(ByVal value As Integer)
            _nMuestra = value
        End Set
    End Property

    Public Property IdP() As String
        Get
            Return _IdP
        End Get

        Set(ByVal value As String)
            _IdP = value
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



    'Ultimo Registro de la tabla EDrogas
    Function Id() As Integer

        Dim ConexionDoc As New CConexion
        Dim Sql As New DataSet
        Dim M As Integer

        Sql = ConexionDoc.Consultar("SELECT * FROM Abuso_Drogas WHERE N_Muestra=   (SELECT MAX(N_Muestra) FROM Abuso_Drogas)")

        If (Sql.Tables(0).Rows.Count > 0) Then
            M = Sql.Tables(0).Rows(0).Item("N_Muestra")
        Else

            M = 0
        End If

        Return M
    End Function
    Public Sub Guardar_Pacientes(ByVal Identidad As String, ByVal Paciente As String, Sexo As String, ByVal FechaNac As String, ByVal Edad As Integer, ByVal Email As String)

        Dim Servicionuevo As New Pacientes With {
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Sexo = Sexo,
            .Fecha_Nacimiento = FechaNac,
            .Edad = Edad,
            .Email = Email
        }
        ConexionA.Pacientes.InsertOnSubmit(Servicionuevo)
        ConexionA.SubmitChanges()

    End Sub

    Public Sub Guardar_Examen(ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal Muestra As Integer, ByVal Fecha As String, ByVal Examen As String, ByVal Resultado As String, ByVal Observacion As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Abuso_Drogas With {
             .N_Muestra = Muestra,
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referencia = Referencia,
            .Fecha = Fecha,
            .Examen = Examen,
            .Resultado = Resultado,
            .Observacion = Observacion
        }


        ConexionA.Abuso_Drogas.InsertOnSubmit(Servicionuevo)
        ConexionA.SubmitChanges()

    End Sub



End Class
