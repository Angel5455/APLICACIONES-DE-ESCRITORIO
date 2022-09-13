Imports System.Data
Imports System.Data.SqlClient


Public Class Conexion_Productos

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter


    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub


    Public Function consultar_stock(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Insumos where Estado=@Estado", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Estado", SqlDbType.VarChar, 100).Value = datos.estado
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function

    Public Function consultar_etiqueta(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Etiquetas where Codigo=@Codigo", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigoE
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function




    Public Function consultar_todos_productos() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select N_Movimiento, Compra, Codigo, Insumos, Unidad, Cantidad, Precio, SubTotal from Productos", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function

    Public Function consultar_todos_productos2() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select N_Movimiento, Factura, Codigo, Insumos, Unidad, Cantidad, Precio, SubTotal from Productos2", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function consultar_todos_productos3() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select N_Movimiento, Factura, Codigo, Insumos, Unidad, Cantidad, Precio, SubTotal from Productos3", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function consultar_todos_articulos() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select  Codigo, Nombre, Linea, Unidad, Stock, Precio, Proveedor, Estado from Insumos", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function

    Public Function consultar_todos_etiquetas() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select  Codigo, Insumo, Unidad from Etiquetas", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function



    Public Function insertar_datos_articulos(ByRef datos As dProductos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Insumos(Codigo, Nombre, Linea, Unidad, Stock, Precio, Proveedor, Estado) values (@Codigo, @Nombre, @Linea, @Unidad, @Stock, @Precio, @Proveedor, @Estado)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.CodigoA
            _adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@Linea", SqlDbType.VarChar, 100).Value = datos.linea
            _adaptador.InsertCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 10).Value = datos.UnidadA
            _adaptador.InsertCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = datos.stock
            _adaptador.InsertCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precioA
            _adaptador.InsertCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 100).Value = datos.proveedor
            _adaptador.InsertCommand.Parameters.Add("@Estado", SqlDbType.VarChar, 100).Value = datos.estado
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function insertar_datos_productos(ByRef datos As dProductos) As Boolean


        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Productos(N_Movimiento, Compra, Codigo, Insumos, Unidad, Cantidad, Precio, Subtotal) values (@N_Movimiento, @Compra, @Codigo, @Insumos, @Unidad, @Cantidad, @Precio, @Subtotal)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento1
            _adaptador.InsertCommand.Parameters.Add("@Compra", SqlDbType.Int).Value = datos.compra
            _adaptador.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo1
            _adaptador.InsertCommand.Parameters.Add("@Insumos", SqlDbType.VarChar, 100).Value = datos.insumos1
            _adaptador.InsertCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 100).Value = datos.unidad1
            _adaptador.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = datos.cantidad1
            _adaptador.InsertCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precio1
            _adaptador.InsertCommand.Parameters.Add("@SubTotal", SqlDbType.Int).Value = datos.subtotal1

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado


    End Function

    Public Function insertar_datos_productos2(ByRef datos As dProductos) As Boolean


        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Productos2(N_Movimiento, Factura, Codigo, Insumos, Unidad, Cantidad, Precio, Subtotal) values (@N_Movimiento, @Factura, @Codigo, @Insumos, @Unidad, @Cantidad, @Precio, @Subtotal)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento2
            _adaptador.InsertCommand.Parameters.Add("@Factura", SqlDbType.VarChar, 50).Value = datos.factura
            _adaptador.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo2
            _adaptador.InsertCommand.Parameters.Add("@Insumos", SqlDbType.VarChar, 100).Value = datos.insumos2
            _adaptador.InsertCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 100).Value = datos.unidad2
            _adaptador.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.VarChar, 100).Value = datos.cantidad2
            _adaptador.InsertCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precio2
            _adaptador.InsertCommand.Parameters.Add("@SubTotal", SqlDbType.Int).Value = datos.subtotal2

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado




    End Function


    Public Function insertar_datos_productos3(ByRef datos As dProductos) As Boolean


        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Productos3(N_Movimiento, Factura, Codigo, Insumos, Unidad, Cantidad, Precio, Subtotal) values (@N_Movimiento, @Factura, @Codigo, @Insumos, @Unidad, @Cantidad, @Precio, @Subtotal)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento2
            _adaptador.InsertCommand.Parameters.Add("@Factura", SqlDbType.VarChar, 50).Value = datos.factura
            _adaptador.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo2
            _adaptador.InsertCommand.Parameters.Add("@Insumos", SqlDbType.VarChar, 100).Value = datos.insumos2
            _adaptador.InsertCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 100).Value = datos.unidad2
            _adaptador.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.VarChar, 100).Value = datos.cantidad2
            _adaptador.InsertCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precio2
            _adaptador.InsertCommand.Parameters.Add("@SubTotal", SqlDbType.Int).Value = datos.subtotal2

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado




    End Function



    Public Function insertar_datos_etiquetas(ByRef datos As dProductos) As Boolean


        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Etiquetas(Codigo, Insumo, Unidad) values (@Codigo, @Insumo, @Unidad)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigoE
            _adaptador.InsertCommand.Parameters.Add("@Insumo", SqlDbType.VarChar, 100).Value = datos.insumoE
            _adaptador.InsertCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 100).Value = datos.unidadE

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado




    End Function


    Public Function actualizar_datos_articulos(ByRef datos As dProductos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Insumos set Nombre=@Nombre, Linea=@Linea, Unidad=@Unidad, Stock=@Stock, Precio=@Precio, Proveedor=@Proveedor, Estado=@Estado where Codigo=@Codigo", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.CodigoA
            _adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.Nombre
            _adaptador.UpdateCommand.Parameters.Add("@Linea", SqlDbType.VarChar, 100).Value = datos.linea
            _adaptador.UpdateCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 10).Value = datos.UnidadA
            _adaptador.UpdateCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = datos.stock
            _adaptador.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precioA
            _adaptador.UpdateCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 100).Value = datos.proveedor
            _adaptador.UpdateCommand.Parameters.Add("@Estado", SqlDbType.VarChar, 100).Value = datos.estado
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function actualizar_datos_Productos(ByRef datos As dProductos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Productos set Compra=@Compra, Codigo=@Codigo, Insumos=@Insumos, Unidad=@Unidad, Cantidad=@Cantidad, SubTotal=@SubTotal where N_Movimiento=@N_Movimiento", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento1
            _adaptador.UpdateCommand.Parameters.Add("@Compra", SqlDbType.Int).Value = datos.compra
            _adaptador.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo1
            _adaptador.UpdateCommand.Parameters.Add("@Insumos", SqlDbType.VarChar, 100).Value = datos.insumos1
            _adaptador.UpdateCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 10).Value = datos.unidad1
            _adaptador.UpdateCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = datos.cantidad1
            _adaptador.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precio1
            _adaptador.UpdateCommand.Parameters.Add("@SubTotal", SqlDbType.VarChar, 100).Value = datos.subtotal1
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function actualizar_datos_Productos2(ByRef datos As dProductos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Productos2 set Factura=@Factura, Codigo=@Codigo, Insumos=@Insumos, Unidad=@Unidad, Cantidad=@Cantidad, SubTotal=@SubTotal where N_Movimiento=@N_Movimiento", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento2
            _adaptador.UpdateCommand.Parameters.Add("@Factura", SqlDbType.Int).Value = datos.factura
            _adaptador.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo2
            _adaptador.UpdateCommand.Parameters.Add("@Insumos", SqlDbType.VarChar, 100).Value = datos.insumos2
            _adaptador.UpdateCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 10).Value = datos.unidad2
            _adaptador.UpdateCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = datos.cantidad2
            _adaptador.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precio2
            _adaptador.UpdateCommand.Parameters.Add("@SubTotal", SqlDbType.VarChar, 100).Value = datos.subtotal2
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function actualizar_datos_Productos3(ByRef datos As dProductos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Productos3 set Factura=@Factura, Codigo=@Codigo, Insumos=@Insumos, Unidad=@Unidad, Cantidad=@Cantidad, SubTotal=@SubTotal where N_Movimiento=@N_Movimiento", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento2
            _adaptador.UpdateCommand.Parameters.Add("@Factura", SqlDbType.Int).Value = datos.factura
            _adaptador.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo2
            _adaptador.UpdateCommand.Parameters.Add("@Insumos", SqlDbType.VarChar, 100).Value = datos.insumos2
            _adaptador.UpdateCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 10).Value = datos.unidad2
            _adaptador.UpdateCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = datos.cantidad2
            _adaptador.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precio2
            _adaptador.UpdateCommand.Parameters.Add("@SubTotal", SqlDbType.VarChar, 100).Value = datos.subtotal2
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado

    End Function


    Public Function borrar_datos_productos(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Productos where Compra=@Compra", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Compra", SqlDbType.Int).Value = datos.compra
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function

    Public Function borrar_datos_productosE(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Productos where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo1
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function



    Public Function borrar_datos_productos2(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Productos2 where Factura=@Factura", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Factura", SqlDbType.Int).Value = datos.factura
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function

    Public Function borrar_datos_productos3(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Productos3 where Factura=@Factura", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Factura", SqlDbType.Int).Value = datos.factura
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function



    Public Function borrar_datos_productosS(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Productos2 where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo2
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function




    Public Function borrar_datos_productosF(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Productos3 where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo2
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function






    Public Function borrar_datos_articulos(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Insumos where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.CodigoA
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function


    Public Function borrar_datos_etiquetas(ByVal datos As dProductos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Etiquetas where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.Int).Value = datos.codigoE
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function


    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property

End Class
