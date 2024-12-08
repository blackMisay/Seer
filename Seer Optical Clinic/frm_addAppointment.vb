Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization

Public Class frm_addAppointment
    Public _patient As String

    Private Sub frm_addAppointment_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        frm_appointment.LoadAppointment()
    End Sub

    Private Sub frm_addAppointment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frm_addAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        'checkboxactive.Checked = True
        frm_appointment.LoadAppointment()
        LoadAvailableTimes()
        PopulateCMB()
        cmbfullname.SelectedIndex = -1
        loadservices()
        loadOptometrist()
        roundCorner(Me)
    End Sub
    Private Sub roundCorner(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub

    Sub loadOptometrist()
        cmboptomet.Items.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT optoId, CONCAT(UPPER(lname), ', ', fname, ' ', mname, ' ', suffix) AS fullname FROM optometrist WHERE isActive = 1", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cmboptomet.Items.Add(dr.Item("fullname").ToString)
            End While
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub loadservices()
        cmbservices.Items.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT * FROM tbl_services", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cmbservices.Items.Add(dr.Item("services").ToString)
            End While
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub LoadAvailableTimes()
        ' Clear the current items in the combo box
        cmboras.Items.Clear()

        ' Define all possible appointment times (for example, every half hour from 9 AM to 5 PM)
        Dim allTimes As List(Of String) = New List(Of String) From {
            "8:30 AM", "9:00 AM", "9:30 AM",
            "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "1:00 PM", "1:30 PM",
            "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", "4:00 PM"
        }

        ' Get the selected date
        Dim selectedDate As DateTime = dateofapp.Value.Date

        ' Query the database for existing appointment times on the selected date
        connect()
        cmd = New Odbc.OdbcCommand("SELECT stime FROM tbl_addappointment WHERE dateofapp = ?", con)
        cmd.Parameters.AddWithValue("?", selectedDate)
        Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()

        ' Create a list to store taken times
        Dim takenTimes As New List(Of String)

        ' Read the times from the database
        While reader.Read()
            takenTimes.Add(reader("stime").ToString())
        End While

        reader.Close()
        con.Close()

        ' Filter the available times by removing taken times
        For Each time As String In allTimes
            If Not takenTimes.Contains(time) Then
                cmboras.Items.Add(time)
            End If
        Next

        ' Optionally, set the default selected item
        If cmboras.Items.Count > 0 Then
            cmboras.SelectedIndex = 0
        End If
    End Sub
    Private Sub dateofapp_ValueChanged(sender As Object, e As EventArgs) Handles dateofapp.ValueChanged
        LoadAvailableTimes()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cmbfullname.Text = String.Empty Then
            MsgBox("Please Select Patient Name", vbExclamation, "Required missing field")
            cmbfullname.Select()
            Return
        End If
        If cmboptomet.Text = String.Empty Then
            MsgBox("Please Select The Optometrist", vbExclamation, "Required missing field")
            cmboptomet.Select()
            Return
        End If
        If cmbservices.Text = String.Empty Then
            MsgBox("Please Select Services", vbExclamation, "Required missing field")
            cmbservices.Select()
            Return
        End If
        Try
            connect()
            If btnsave.Tag = 0 Then
                ' Check if an appointment already exists for the same patient, date, and time
                cmd = New Odbc.OdbcCommand("SELECT COUNT(*) FROM tbl_addappointment WHERE patientid = ? AND dateofapp = ? AND stime = ?", con)
                With cmd.Parameters
                    .AddWithValue("?", txtpatientid.Text)
                    .AddWithValue("?", dateofapp.Value.Date)
                    .AddWithValue("?", cmboras.Text)
                End With

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count = 0 Then
                    ' No duplicate found, proceed with the insert
                    cmd = New Odbc.OdbcCommand("INSERT INTO tbl_addappointment (patientid, dateofapp, stime, assisted, optomet, service, isdeleted, isactive) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", con)
                    With cmd.Parameters
                        .AddWithValue("?", txtpatientid.Text)
                        .AddWithValue("?", dateofapp.Value.Date)
                        .AddWithValue("?", cmboras.Text)
                        .AddWithValue("?", txtassisted.Text)
                        .AddWithValue("?", cmboptomet.Text)
                        .AddWithValue("?", cmbservices.Text)
                        .AddWithValue("?", CBool(CheckBox1.Checked))
                        .AddWithValue("?", CBool(checkboxactive.Checked))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Appointemnt added successfully", vbInformation, "Success")
                    frm_appointment.LoadAppointment()
                End If
            End If
            connect()
            Dim updateQuery As String = "UPDATE tbl_addpatient SET isnot = 0 WHERE patientid = ?"
            cmd = New Odbc.OdbcCommand(updateQuery, con)
            cmd.Parameters.AddWithValue("?", txtpatientid.Text)

            ' Execute the update command
            cmd.ExecuteNonQuery()
            con.Close()

            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error occurred while saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
            GC.Collect()
        End Try
    End Sub
    Private Function RoundToNearest30Minutes(ByVal dt As DateTime) As DateTime
        Dim minutes As Integer = dt.Minute
        If minutes < 30 Then
            dt = dt.AddMinutes(30 - minutes)
        Else
            dt = dt.AddMinutes(60 - minutes)
        End If
        Return dt
    End Function

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            connect()
            cmd = New Odbc.OdbcCommand("UPDATE tbl_addappointment SET dateofapp=?, assisted=?, optomet=?, service=? WHERE patientid=?", con)
            With cmd.Parameters
                .AddWithValue("?", dateofapp.Value)
                .AddWithValue("?", txtassisted.Text)
                .AddWithValue("?", cmboptomet.Text)
                .AddWithValue("?", cmbservices.Text)
                .AddWithValue("?", txtpatientid.Text)
            End With
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Appointment updated successfully", vbInformation, "Update")
                frm_appointment.LoadAppointment()
                Me.Dispose()
            Else
                MsgBox("Appointment update failed", vbExclamation, "Failed")
            End If
            'connect()
            'cmd = New Odbc.OdbcCommand("UPDATE tbl_addappointment SET status = 'Success' WHERE patientid=?", con)
            'cmd.Parameters.AddWithValue("?", id)
            'cmd.ExecuteNonQuery()
            'con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Sub PopulateCMB()
        cmbfullname.Items.Clear()
        connect()
        Try
            Dim adapter As New Odbc.OdbcDataAdapter("SELECT patientid, CONCAT(UPPER(lname), ', ', fname, ' ', mname, ' ', suffix) AS fullname FROM tbl_addpatient WHERE isactive = 1 AND isnot = 1 AND isback = 0", con)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbfullname.DisplayMember = "fullname"
            cmbfullname.ValueMember = "patientid"
            cmbfullname.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
            GC.Collect()
        End Try
    End Sub
    Private Sub cmbfullname_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbfullname.SelectionChangeCommitted
        If cmbfullname.SelectedValue IsNot Nothing Then
            txtpatientid.Text = cmbfullname.SelectedValue.ToString()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnaddservices_Click(sender As Object, e As EventArgs) Handles btnaddservices.Click
        frm_services.ShowDialog()
    End Sub

    Private Sub cmbservices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbservices.SelectedIndexChanged

    End Sub

    Private Sub btnaddtime_Click(sender As Object, e As EventArgs) Handles btnaddtime.Click
        frm_ManageDoctor.ShowDialog()
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        If cmboptomet.Text = String.Empty Then
            MsgBox("Please Select The Optometrist", vbExclamation, "Required missing field")
            cmboptomet.Select()
            Return
        End If
        If cmbservices.Text = String.Empty Then
            MsgBox("Please Select Services", vbExclamation, "Required missing field")
            cmbservices.Select()
            Return
        End If
        Try
            connect()
            If btnsave.Tag = 0 Then
                ' Check if an appointment already exists for the same patient, date, and time
                cmd = New Odbc.OdbcCommand("SELECT COUNT(*) FROM tbl_addappointment WHERE patientid = ? AND dateofapp = ? AND stime = ?", con)
                With cmd.Parameters
                    .AddWithValue("?", txtpatientid.Text)
                    .AddWithValue("?", dateofapp.Value.Date)
                    .AddWithValue("?", cmboras.Text)
                End With

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count = 0 Then
                    ' No duplicate found, proceed with the insert
                    cmd = New Odbc.OdbcCommand("INSERT INTO tbl_addappointment (patientid, dateofapp, stime, assisted, optomet, service, isdeleted, isactive) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", con)
                    With cmd.Parameters
                        .AddWithValue("?", txtpatientid.Text)
                        .AddWithValue("?", dateofapp.Value.Date)
                        .AddWithValue("?", cmboras.Text)
                        .AddWithValue("?", txtassisted.Text)
                        .AddWithValue("?", cmboptomet.Text)
                        .AddWithValue("?", cmbservices.Text)
                        .AddWithValue("?", CBool(CheckBox1.Checked))
                        .AddWithValue("?", CBool(checkboxactive.Checked))
                    End With
                    cmd.ExecuteNonQuery()
                    frm_appointment.LoadAppointment()
                End If
            End If
            connect()
            Dim updateQuery As String = "UPDATE tbl_addpatient SET isnot = 0 WHERE patientid = ?"
            cmd = New Odbc.OdbcCommand(updateQuery, con)
            cmd.Parameters.AddWithValue("?", txtpatientid.Text)

            ' Execute the update command
            cmd.ExecuteNonQuery()
            con.Close()

            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error occurred while saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
            GC.Collect()
        End Try
    End Sub
End Class
