Imports System.Data
Imports System.Data.SqlClient

Imports GoEmail


Public Class F_RecuperarContraseña


    Dim Da As New SqlDataAdapter
    Dim Cn As New SqlConnection("Data Source=(local);Initial Catalog=Gcod ;User ID=sa;Password=root")
    Dim Cmd As New SqlCommand
    Dim Dt As DataTable
    Dim Dr As DataRow
    Dim Abc() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim Cba() As String = {"Z", "T", "D", "C", "P", "M", "W", "I", "H", "J", "S", "Q", "F", "N", "Ñ", "U", "E", "L", "R", "K", "B", "O", "X", "G", "V", "Y", "A"}
    Dim Bac() As String = {"Z", "A", "Q", "P", "C", "M", "X", "S", "U", "N", "I", "D", "R", "J", "Ñ", "H", "E", "L", "F", "B", "K", "G", "W", "O", "Y", "V", "T"}
    Dim nums() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}
    Dim num() As String = {"0", "9", "5", "7", "1", "2", "8", "3", "4", "6"}



  
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click



        'Inicializar la clase Random  
        Dim Random As New Random()


            ' generar un random entre 1 y 100  
            Dim numero As Integer = Random.Next(1, 100)
            Dim numero2 As Integer = Random.Next(1, 100)


            ' generar un random entre 5 y 15  
            numero = Random.Next(0, 5000)
            numero = Random.Next(0, 5000)


            TextBox2.Text = numero & "" & numero2



            Dim usuario As String = "admin"
            Dim clave As String = TextBox2.Text
            Dim angel As String = "angelrpaz54@gmail.com"
            Dim contraseña As String = "lujuria5455"



            Dim destino As String = TextBox1.Text
            Dim asunto As String = "CONTRASEÑA IHCAFE"
            Dim mensaje As String = "Usuario: " & usuario & "  " & "Contraseña: " & clave
            Dim nombre As String = "IHCAFE"
            Dim gmail As String = angel
            Dim password As String = contraseña

            Dim x As New EnviarEmail()
            Dim exito As Boolean = x.EnviarMail(destino, asunto, mensaje, nombre, gmail, password)

            If exito Then
                MessageBox.Show("...Se a enviado el mensaje...")
            Else
                MessageBox.Show("...No se a enviado el mensaje...")
            End If


            Me.Hide()
            F_ContraseñaRespaldo.Show()

            Dim resp As String

            resp = MsgBox("Desea Abrir el Explorador Web", MsgBoxStyle.YesNo, "P.A.P.P System")

            If resp = 6 Then

                Dim Proceso As New Process()
                Proceso.StartInfo.FileName = "iexplore.exe"
                Proceso.StartInfo.Arguments = ""
                Proceso.Start()
                Me.Hide()

            End If



    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Height = 45
        PictureBox1.Width = 45
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Height = 50
        PictureBox1.Width = 50
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        F_Contraseña.Show()

    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Height = 45
        PictureBox2.Width = 45
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Height = 50
        PictureBox2.Width = 50
    End Sub

    Private Sub F_RecuperarContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        
        
        
    End Sub
End Class