Public Class F_BlocNotas

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        RichTextBox1.Clear()

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click

        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Abrir"
            dlg.Filter = "Documentos de texto (*.rtf)| *.rtf"
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

                RichTextBox1.LoadFile(dlg.FileName)

            End If

        Catch ex As Exception : End Try



    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Guardar"
            dlg.Filter = "Documentos de texto (*.rtf)| *.rtf"
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

                RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)

            End If

        Catch ex As Exception : End Try

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "System IHCAFE")
        If resp = 6 Then
            Me.Hide()
        End If
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerToolStripMenuItem.Click
        RichTextBox1.Undo()

    End Sub

    Private Sub RehacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RehacerToolStripMenuItem.Click
        RichTextBox1.Redo()

    End Sub

    Private Sub CortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.Paste()

    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarToolStripMenuItem.Click
        RichTextBox1.Clear()

    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        RichTextBox1.SelectAll()

    End Sub

    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click

        Try

            Dim dlg As FontDialog = New FontDialog
            dlg.Font = RichTextBox1.Font

            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

                RichTextBox1.Font = dlg.Font


            End If




        Catch ex As Exception : End Try


    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Try

            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = RichTextBox1.ForeColor

            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

                RichTextBox1.ForeColor = dlg.Color


            End If




        Catch ex As Exception : End Try


    End Sub

End Class