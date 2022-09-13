Imports System.Data.SqlClient

Public Class DUsuarios

    Dim ConexionU As New DataClasses1DataContext()
    Dim Query
    Event Errores(ByVal Pacientes As String)




    Sub Buscar_Usuarios(ByVal datagrid As DataGridView, ByVal parametro As String, ByVal Cargo As String)

        If (parametro = "Buscar Usuario" Or parametro = "") Then
            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select Id, Nombre, Identidad, Telefono from Usuarios Where Nombre like'%" & "" & "%'" & "And Cargo like'" & Cargo & "'", con)



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

            Dim da As New SqlDataAdapter("Select Id, Nombre, Identidad, Telefono from Usuarios Where Nombre like'%" & parametro & "%'" & "And Cargo like'" & Cargo & "'", con)



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

    Public Sub Insertar_Usuario(ByVal Nombre As String, ByVal Identidad As String, ByVal Email As String, ByVal Password As String, ByVal Direccion As String, ByVal Telefono As String, ByVal Cargo As String, ByVal Foto As Byte())

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Usuarios With {
            .Nombre = Nombre,
            .Identidad = Identidad,
            .Email = Email,
            .Password = Password,
            .Direccion = Direccion,
            .Telefono = Telefono,
            .Cargo = Cargo,
            .Foto = Foto
        }
        ConexionU.Usuarios.InsertOnSubmit(Servicionuevo)
        ConexionU.SubmitChanges()

    End Sub

    Public Sub Editar_Usuario(ByVal Id As Integer, ByVal Nombre As String, ByVal Identidad As String, ByVal Email As String, ByVal Password As String, ByVal Direccion As String, ByVal Telefono As String, ByVal Cargo As String, ByVal Foto As Byte())


        Dim modificar = (From n In ConexionU.Usuarios Where n.Id = Id Select n).Single
        modificar.Id = Id
        modificar.Nombre = Nombre
        modificar.Identidad = Identidad
        modificar.Email = Email
        modificar.Password = Password
        modificar.Direccion = Direccion
        modificar.Telefono = Telefono
        modificar.Cargo = Cargo
        modificar.Foto = Foto


        ConexionU.SubmitChanges()

    End Sub

    Sub Eliminar_Usuario(ByVal id As String)

        Try
            Query = (From n In ConexionU.Usuarios Where n.Id = id Select n).Single

            ConexionU.Usuarios.DeleteOnSubmit(Query)

            ConexionU.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent Errores("Seleccione el documento que desea eliminar luego presione eliminar")
            Else
                RaiseEvent Errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub


End Class
