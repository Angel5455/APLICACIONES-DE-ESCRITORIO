Imports System.Data.SqlClient

Public Class CConexion

    ' Dim command As New SqlCommand

    Public Cadena As String = "Data Source=(local);Initial Catalog=SystemLetona;Persist Security Info=True;User ID=sa;Password=root"
    Public Conexion As New SqlConnection(Cadena)


    Private _Tabla As New DataTable
    Private _Adaptador As SqlDataAdapter = New SqlDataAdapter




    Public Function Consultar(ByVal Sql) As DataSet
        Dim Datos As New DataSet
        Try
            If Not Conexion.State = ConnectionState.Open Then
                Conexion.ConnectionString = Cadena

                Conexion.Open()

            End If

            Dim Comando As New SqlCommand(Sql, Conexion)
            Dim Adaptador As New SqlDataAdapter(Comando)
            Adaptador.Fill(Datos)
            Comando.ExecuteScalar()


            Conexion.Close()



        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

        Return Datos
    End Function

    Public Function Consultar_Historial(ByVal datos As DHistorial) As Boolean

        Dim estado As Boolean = True

        Try
            'conexionCrys()
            _Adaptador.SelectCommand = New SqlCommand("Select * from Historial where Codigo_Historial=@Codigo_Historial", Conexion)

            _Adaptador.SelectCommand.Parameters.Add("@Codigo_Historial", SqlDbType.VarChar).Value = datos.Codigo_Historial
            _Adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            Cerrar()


        End Try

        Return estado


    End Function

    Public Function Consultar_Prescripcion(ByVal datos As DPrescripcion) As Boolean

        Dim estado As Boolean = True

        Try
            'conexionCrys()
            _Adaptador.SelectCommand = New SqlCommand("Select * from Prescripcion where Id=@Id", Conexion)

            _Adaptador.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = datos.Id
            _Adaptador.Fill(_Tabla)
        Catch ex As Exception

            estado = False
        Finally

            Cerrar()


        End Try

        Return estado


    End Function

    Public ReadOnly Property Tabla() As DataTable
        Get
            Return _Tabla
        End Get
    End Property


End Class
