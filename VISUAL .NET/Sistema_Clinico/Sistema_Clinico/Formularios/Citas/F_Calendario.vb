Imports System.Data.SqlClient

Public Class F_Calendario

    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Private Sub F_Calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        DisplayCurrentDate()



        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        DateTimePicker1.Text = startDate
        DateTimePicker2.Text = endDate



    End Sub

    Private Sub AddNewAppointment(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            With F_AgregarCita
                .AppID = 0
                .TxtPaciente.Text = ""
                .TxtIdentidad.Text = ""
                .TxtTelefono.Text = ""
                .TxtHora.Text = ""
                .TxtObservaciones.Text = ""
                .TxtEstado.Text = ""
                .LblText.Text = "Agregar Cita"
                .TxtTelefono.Enabled = False
                .TxtIdentidad.Enabled = False
                .TxtPaciente.Enabled = False
                .BtnBuscar.Enabled = True

                .TxtFecha.Value = New Date(currentDate.Year, currentDate.Month, day)
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub ShowAppointmentDetail(sender As Object, e As EventArgs)
        Dim appID As Integer = CType(sender, LinkLabel).Tag
        'Dim sql As String = $"select * from Calendario where Id = {appID}"
        'Dim dt As DataTable = QueryAsDataTable(sql)

        Dim dt As New DataTable

        Dim da As New SqlDataAdapter($"select * from Citas where Id = {appID}", Conexion.Conexion)


        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With F_AgregarCita
                .LblText.Text = "Editar Cita"
                .AppID = appID
                .TxtPaciente.Text = row("Paciente")
                .TxtIdentidad.Text = row("Identidad")
                .TxtObservaciones.Text = row("Observaciones")
                .TxtEstado.Text = row("Estado")
                .TxtFecha.Value = row("Fecha")
                .TxtHora.Text = row("Hora")
                .BtnBuscar.Enabled = False
                .TxtIdentidad.Enabled = False
                .TxtTelefono.Enabled = False
                '.TxtTelefono.Visible = False
                '.BunifuCheckbox1.Visible = False
                '.Label4.Visible = False
                .BtnEliminar.Visible = True
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)

        Dim mes As String = currentDate.Month
        Dim year As String = currentDate.Year

        Dim fecha As String = year & "-" & mes





        Dim dt As New DataTable
        Dim cmd As New SqlCommand

        Dim da As New SqlDataAdapter($"Select * from Citas Where Fecha Like'%" & fecha & "%'", Conexion.Conexion)



        da.Fill(dt)



        For Each row As DataRow In dt.Rows
            Dim appDay As DateTime = DateTime.Parse(row("Fecha"))
            Dim link As New LinkLabel With {
                .Tag = row("ID"),
                .Name = $"link{row("ID")}",
                .Text = row("Paciente")
            }
            AddHandler link.Click, AddressOf ShowAppointmentDetail
            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
        Next
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)

        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        DateTimePicker1.Text = startDate
        DateTimePicker2.Text = endDate


        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        DateTimePicker1.Text = startDate
        DateTimePicker2.Text = endDate

        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        DateTimePicker1.Text = startDate
        DateTimePicker2.Text = endDate
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel With {
                .Name = $"flDay{i}",
                .Size = New Size(128, 99),
                .BackColor = Color.White,
                .BorderStyle = BorderStyle.FixedSingle,
                .Cursor = Cursors.Hand,
                .AutoScroll = True
            }
            AddHandler fl.Click, AddressOf AddNewAppointment
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub

    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label With {
                .Name = $"lblDay{i}",
                .AutoSize = False,
                .TextAlign = ContentAlignment.MiddleRight,
                .Size = New Size(110, 22),
                .Text = i,
                .Font = New Font("Microsoft Sans Serif", 12)
            }
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Aqua
            End If

        Next
    End Sub

    Private Sub BtnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click

        PrevMonth()
    End Sub

    Private Sub BtnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub

    Private Sub BtnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Today()
    End Sub

    Private Sub F_Calendario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()


    End Sub
End Class