Partial Class SystemLetonaDataSet
    Partial Public Class Citologia_Moco_FecalDataTable
        Private Sub Citologia_Moco_FecalDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PacienteColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace SystemLetonaDataSetTableAdapters

    Partial Public Class EDrogasTableAdapter
    End Class
End Namespace
