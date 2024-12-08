Imports System.Data.Odbc.OdbcConnection
Imports System.IO

Public Class frm_Callendar
    Private listflDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today

    Private Sub frm_Callendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        GenerateDayPanel(42) ' Generate 42 day panels (for 6 weeks, 7 days each)
        DisplayCurrentDate()
    End Sub

    Sub DisplayAppointment(ByVal startDayAtFlNumber As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
        Dim maxAppointmentsPerDay As Integer = 5 ' Set the threshold for maximum appointments per day

        Try
            connect()
            Dim sql As String = "SELECT a.appointmentid, p.patientid, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status, a.isdeleted, p.isactive, p.isback FROM tbl_addpatient p LEFT JOIN tbl_addappointment a ON a.patientid = p.patientid WHERE a.isdeleted = 1 AND dateofapp BETWEEN '" & startDate.ToString("yyyy-MM-dd") & "' AND '" & endDate.ToString("yyyy-MM-dd") & "'"
            Dim dt As DataTable = QueryAsDataTable(sql)

            ' Dictionary to count appointments per day
            Dim appointmentCount As New Dictionary(Of Integer, Integer)

            For Each row As DataRow In dt.Rows
                ' Create a new LinkLabel for each appointment
                Dim link As New LinkLabel()
                link.Name = "link" & row("patientid").ToString()
                link.Text = row("fullname").ToString()
                link.Font = New Font("Arial", 10, FontStyle.Bold)

                ' Calculate the day from the appointment date
                Dim appointmentDay As Integer = CDate(row("dateofapp")).Day

                ' Initialize appointment count for the day if it doesn't exist
                If Not appointmentCount.ContainsKey(appointmentDay) Then
                    appointmentCount(appointmentDay) = 0
                End If

                ' Increment the appointment count for the day
                appointmentCount(appointmentDay) += 1

                ' Add the LinkLabel to the appropriate FlowLayoutPanel
                If appointmentDay + (startDayAtFlNumber - 1) < listflDay.Count Then
                    Dim fl As FlowLayoutPanel = listflDay(appointmentDay + (startDayAtFlNumber - 1))

                    ' Add the LinkLabel to the FlowLayoutPanel
                    fl.Controls.Add(link)

                    ' Check if the appointment count exceeds the maximum allowed for the day
                    If appointmentCount(appointmentDay) >= maxAppointmentsPerDay Then
                        fl.BackColor = Color.Red ' Set the panel background color to red if full
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox("Error in DisplayAppointment: " & ex.Message)
        End Try
    End Sub
    Private Sub AddNewAppointment(sender As Object, e As EventArgs)
        Dim panel As FlowLayoutPanel = CType(sender, FlowLayoutPanel)
        With frm_addAppointment
            .ShowDialog()
            .btnsave.Visible = True
            .btnedit.Visible = False
        End With
        DisplayCurrentDate()
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As New DateTime(currentDate.Year, currentDate.Month, 1)
        Return CInt(firstDayOfMonth.DayOfWeek) ' Return DayOfWeek where Sunday = 0, Monday = 1, etc.
    End Function

    Private Function GetTotalDayOfWeekCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New DateTime(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAnYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim TotalDay As Integer = GetTotalDayOfWeekCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, TotalDay)
        DisplayAppointment(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        Try
            FlowLayoutPanel1.Controls.Clear() ' Clear existing controls in FlowLayoutPanel1
            listflDay.Clear() ' Clear the list to avoid duplication

            ' Set FlowLayoutPanel1 properties
            FlowLayoutPanel1.WrapContents = True ' Allow wrapping of panels to next line

            ' Generate the specified number of day panels (42 in this case, to represent a full calendar view with 6 weeks)
            For i As Integer = 1 To totalDays
                Dim fl As New FlowLayoutPanel
                fl.Name = String.Format("flDay{0}", i) ' Naming the panels
                fl.Size = New Size(200, 160)
                fl.BackColor = Color.White ' Set background color
                fl.BorderStyle = BorderStyle.FixedSingle ' Add border
                fl.Cursor = Cursors.Hand
                fl.Margin = New Padding(10, 10, 10, 10) ' Left, Top, Right, Bottom
                AddHandler fl.Click, AddressOf AddNewAppointment
                ' Add the day panel to the FlowLayoutPanel1
                FlowLayoutPanel1.Controls.Add(fl)
                listflDay.Add(fl) ' Add each panel to the list
            Next
        Catch ex As Exception
            MsgBox("Error in GenerateDayPanel: " & ex.Message)
        End Try
    End Sub

    Private Sub AddLabelDayToFlDay(ByVal startDayAtflNumber As Integer, ByVal totalDaysInMonth As Integer)
        Try
            ' Clear all day labels from the panels
            For Each panel As FlowLayoutPanel In listflDay
                panel.Controls.Clear()
                panel.Tag = 0
                panel.BackColor = Color.White ' Default background for all days
            Next

            ' Loop through and add a label to each day panel, starting at startDayAtflNumber
            For i As Integer = 1 To totalDaysInMonth
                ' Calculate the panel index
                Dim panelIndex As Integer = startDayAtflNumber + (i - 1)

                ' Ensure the panelIndex is within the bounds of listflDay
                If panelIndex < listflDay.Count Then
                    Dim fl As FlowLayoutPanel = listflDay(panelIndex)

                    ' Create a label to display the day number
                    Dim lblDay As New Label
                    lblDay.Text = i.ToString() ' Display day number
                    lblDay.AutoSize = False
                    lblDay.TextAlign = ContentAlignment.MiddleRight
                    lblDay.Size = New Size(150, 50)

                    ' Add the label to the corresponding panel
                    fl.Controls.Add(lblDay)

                    ' Set the panel's tag to the day number for future reference
                    fl.Tag = i

                    ' Calculate the panel date (current year, month, and the day represented by 'i')
                    Dim panelDate As New DateTime(currentDate.Year, currentDate.Month, i)

                    ' Change background color based on date comparison
                    If panelDate < Date.Today Then
                        ' If the day is in the past, set the background color to grey
                        fl.BackColor = Color.WhiteSmoke
                    ElseIf panelDate = Date.Today Then
                        ' If it's today, set the background color to Aqua
                        fl.BackColor = Color.Aqua
                    Else
                        ' For future dates, leave the background color as white
                        fl.BackColor = Color.White
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error in AddLabelDayToFlDay: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        PrevMonth()
    End Sub

    Private Sub btntoday_Click(sender As Object, e As EventArgs) Handles btntoday.Click
        Today()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NextMonth()
    End Sub
End Class
