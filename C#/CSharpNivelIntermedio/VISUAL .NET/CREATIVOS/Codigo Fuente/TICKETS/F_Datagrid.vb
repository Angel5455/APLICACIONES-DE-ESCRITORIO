Public Class F_Datagrid

    Private Sub F_Datagrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DRptCREATIVOS.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.DRptCREATIVOS.Inventario)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try

            ' Busca descripcion y precio del producto por el "Codigo"
            If DataGridView1.CurrentCell.ColumnIndex = 0 Then
                'DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = Me.InventarioTableAdapter.Select_Descripcion(DataGridView1.CurrentRow.Cells(0).Value)
                'DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value = Me.ArtículosTableAdapter1.Buscar_Precio(DataGridView1.CurrentRow.Cells(0).Value)
                'DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value = 1
                'DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value = CInt(Me.ArtículosTableAdapter1.Buscar_Precio(DataGridView1.CurrentRow.Cells(0).Value)) * CInt(DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)

                Dim total As Integer

                For i As Integer = 0 To DataGridView1.RowCount - 1

                    total = total + CDbl(DataGridView1.Item(4, i).Value)

                Next

                txt_Subtotal.Text = "¢" & total



            End If

            ' Busca descripcion y precio del producto por la "Descripción"
            If DataGridView1.CurrentCell.ColumnIndex = 1 Then
                '    DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value = Me.ArtículosTableAdapter1.Select_Id(DataGridView1.CurrentRow.Cells(1).Value)
                '     DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value = Me.ArtículosTableAdapter1.Select_Precio(DataGridView1.CurrentRow.Cells(1).Value)
                '      DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value = 1
                '       DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value = CInt(Me.ArtículosTableAdapter1.Buscar_Precio(DataGridView1.CurrentRow.Cells(0).Value)) * CInt(DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)
                Dim total As Double = 0
                For i As Integer = 0 To DataGridView1.RowCount - 1

                    total = total + CDbl(DataGridView1.Item(4, i).Value)

                Next

            
            End If

            ' Pone el precio de acuerdo a la cantidad escogida
            If DataGridView1.CurrentCell.ColumnIndex = 2 Then
                '                DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value = CInt(Me.ArtículosTableAdapter1.Buscar_Precio(DataGridView1.CurrentRow.Cells(0).Value)) * CInt(DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)

                Dim total As Double = 0
                For i As Integer = 0 To DataGridView1.RowCount - 1

                    total = total + CDbl(DataGridView1.Item(4, i).Value)

                Next

                txt_Subtotal.Text = "¢" & total
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class