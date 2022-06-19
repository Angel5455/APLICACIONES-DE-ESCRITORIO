Imports System.Data.SqlClient

Public Class Dpacientes
    Dim ConexionP As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Pacientes As String)

    Sub Obtener_Paciente(ByVal Identidad As MaskedTextBox)

        Try
            Query = (From n In ConexionP.Pacientes Where n.Identidad = Val(Identidad) Select n).Single
            Identidad.Text = Query.Nombre

        Catch ex As Exception
            RaiseEvent Errores("Error al intentar pasar los datos")
        End Try


    End Sub

    Sub Buscar(ByVal datagrid As DataGridView, ByVal parametro As String)

        If (parametro = "Buscar Pacientes" Or parametro = "") Then
            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select Id, Paciente, Identidad, Telefono from Pacientes Where Paciente like'%" & "" & "%'", con)



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

            Dim da As New SqlDataAdapter("Select Id, Paciente, Identidad, Telefono from Pacientes Where Paciente like'%" & parametro & "%'", con)



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
    Public Sub Insertar_Pacientes(ByVal Identidad As String, ByVal Paciente As String, ByVal Email As String, ByVal Direccion As String, ByVal Telefono As String, ByVal Fecha As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Foto As Byte())

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Pacientes With {
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Email = Email,
            .Direccion = Direccion,
            .Telefono = Telefono,
            .Fecha_Nacimiento = Fecha,
            .Edad = Edad,
            .Sexo = Sexo,
            .Foto = Foto
        }
        ConexionP.Pacientes.InsertOnSubmit(Servicionuevo)
        ConexionP.SubmitChanges()

    End Sub

    Public Sub Editar_Pacientes(ByVal IdPaciente As Integer, ByVal Identidad As String, ByVal Paciente As String, ByVal Email As String, ByVal Direccion As String, ByVal Telefono As String, ByVal Fecha As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Foto As Byte())


        Dim modificar = (From n In ConexionP.Pacientes Where n.Id = IdPaciente Select n).Single
        modificar.Id = IdPaciente
        modificar.Identidad = Identidad
        modificar.Paciente = Paciente
        modificar.Email = Email
        modificar.Telefono = Telefono
        modificar.Direccion = Direccion
        modificar.Sexo = Sexo
        modificar.Fecha_Nacimiento = Fecha
        modificar.Edad = Edad
        modificar.Foto = Foto

        ConexionP.SubmitChanges()

    End Sub

    Sub Eliminar_Paciente(ByVal id As String)

        Try
            Query = (From n In ConexionP.Pacientes Where n.Id = id Select n).Single

            ConexionP.Pacientes.DeleteOnSubmit(Query)

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
