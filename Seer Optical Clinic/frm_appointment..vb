Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization
Public Class frm_appointment

   Private Sub frm_appointment_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'LoadAppointment()
    End Sub

    Private Sub frm_appointment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        dgv_app.RowTemplate.Height = 40
        LoadAppointment()
        'Call loadrecord()
        RoundButton(btn_addpres)
        RoundButton(btnsuccess)
    End Sub
    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btn_addpres.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddLine(btnsuccess.Width, 20, btn.Width, btn.Height - 10)
        'Raduis.AddLine(btnEdit.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btn_addpres.Region = New Region(Raduis)
        btnsuccess.Region = New Region(Raduis)
        'btnEdit.Region = New Region(Raduis)
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If frm_Callendar IsNot Nothing Then
            frm_Callendar.Dispose()
        End If
        With frm_Callendar
            .TopLevel = False
            panelCon.Controls.Add(frm_Callendar)
            .BringToFront()
            .Dock = DockStyle.Fill
            .Show()
        End With
        Panel3.Visible = False
    End Sub
    Sub LoadAppointment()
        dgv_app.Rows.Clear()
        Try
            connect()
            Dim cmd As New Odbc.OdbcCommand("SELECT a.appointmentid, p.patientid, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status, a.isdeleted, p.isactive, p.isback FROM tbl_addpatient p LEFT JOIN tbl_addappointment a ON a.patientid = p.patientid WHERE a.isdeleted = 1 AND a.status <> 'Success' AND a.isactive = 1 ORDER BY a.dateofapp, a.stime", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_app.Rows.Add(dgv_app.Rows.Count + 1, dr.Item("appointmentid"), dr.Item("patientid"), dr.Item("fullname"), dr.Item("dateofapp"), dr.Item("stime"), dr.Item("assisted"), dr.Item("optomet"), dr.Item("service"), dr.Item("status"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgv_app_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_app.CellContentClick
        Dim sql As String
        Dim cmd As Odbc.OdbcCommand
        Dim colName As String = dgv_app.Columns(e.ColumnIndex).Name
        Dim dateValue As Date
        frm_addAppointment.txtfullname.Visible = True
        frm_addAppointment.lbladd.Visible = False
        frm_addAppointment.lbledit.Visible = True

        If colName = "colUpdate" Then
            Try
                With frm_addAppointment
                    connect()
                    cmd = New Odbc.OdbcCommand("SELECT p.patientid, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status FROM tbl_addpatient p LEFT JOIN tbl_addappointment a ON a.patientid = p.patientid WHERE a.patientid like '" & dgv_app.Rows(e.RowIndex).Cells(2).Value.ToString & "'", con)
                    dr = cmd.ExecuteReader
                    While dr.Read
                        .txtpatientid.Text = dr.GetInt32(0)
                        .txtfullname.Text = dgv_app.Rows(e.RowIndex).Cells(3).Value.ToString
                        '.cmbfullname.Text = dr.GetInt32(1)
                        If Date.TryParse(dgv_app.Rows(e.RowIndex).Cells(4).Value.ToString(), dateValue) Then
                            .dateofapp.Value = dateValue
                        End If
                        '.cmboras.Text = dr.GetString(3)

                        .txtassisted.Text = dr.GetString(4)
                        .cmboptomet.Text = dr.GetString(5)
                        .cmbservices.Text = dr.GetString(6)
                    End While
                    .cmboras.Enabled = False
                    .txtfullname.Visible = True
                    .btnsave.Visible = False
                    .cmbfullname.Visible = False
                    .lbladd.Visible = False
                    .lbledit.Visible = True
                    dr.Close()
                    con.Close()
                    .ShowDialog()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                con.Close()
            End Try
        End If
        If colName = "colTrash" Then
            'frm_addAppointment.cmbfullname.Visible = True
            'frm_addAppointment.lbladd.Visible = True
            'frm_addAppointment.lbledit.Visible = False
            'frm_addAppointment.lbladd.Visible = True
            If MsgBox("Are you sure you want to cancel this appointment?", vbQuestion + vbYesNo, "CANCELED") = vbYes Then
                Try

                    connect()
                    sql = "DELETE FROM tbl_addappointment WHERE patientid = ?"
                    cmd = New Odbc.OdbcCommand(sql, con)
                    'cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("?", dgv_app.Rows(e.RowIndex).Cells("Column1").Value.ToString())
                    i = cmd.ExecuteNonQuery()
                    MsgBox("Appointment marked as canceled successfully!", MsgBoxStyle.Information, "Delete")
                    LoadAppointment()
                    con.Close()

                    connect()
                    sql = "UPDATE tbl_addpatient SET isnot=1 WHERE patientid = ?"
                    cmd = New Odbc.OdbcCommand(sql, con)
                    'cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("?", dgv_app.Rows(e.RowIndex).Cells("Column1").Value.ToString())
                    i = cmd.ExecuteNonQuery()
                    LoadAppointment()
                    frm_restoreAppointment.restoreAppointment()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                End Try
            End If
        End If
    End Sub

    Private Sub dgv_app_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.RowIndex >= 0 Then
            If e.ColumnIndex >= 0 AndAlso dgv_app.Columns(e.ColumnIndex).Name = "colTrash" Then
                dgv_app.Rows(e.RowIndex).Cells("colTrash").ToolTipText = "CANCEL"
            ElseIf e.ColumnIndex >= 0 AndAlso dgv_app.Columns(e.ColumnIndex).Name = "colUpdate" Then
                dgv_app.Rows(e.RowIndex).Cells("colUpdate").ToolTipText = "UPDATE"
            End If
        End If
    End Sub

    Private Sub dgv_app_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_app.CellClick
        Try
            dgv_app.Tag = dgv_app.Item(2, e.RowIndex).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_addpres_Click(sender As Object, e As EventArgs) Handles btn_addpres.Click
        If dgv_app.Tag IsNot Nothing AndAlso dgv_app.Tag.ToString() <> "0 Then" Then
            loadDataView(dgv_app.Tag)
            dgv_app.Tag = "0" ' Reset the tag after processing
        Else
            MsgBox("Please select a record to Add Prescription", vbCritical)
        End If
    End Sub

    Private Sub loadDataView(id As String)
        Dim dt As New DataTable()
        Dim sql As String = "SELECT a.appointmentid, p.patientid, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, p.dob, TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age, p.gender, p.phone, p.email, p.address, a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status FROM tbl_addpatient p JOIN tbl_addappointment a ON a.patientid = p.patientid WHERE p.patientid = ?"
        connect()  ' Ensure the connection is open

        Using cmd As New Odbc.OdbcCommand(sql, con)
            'MsgBox(id)
            cmd.Parameters.AddWithValue("?", id)

            Using da As New Odbc.OdbcDataAdapter(cmd)
                Try
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Dim viewsForm As New frm_EyeExamination()
                        With viewsForm
                            .txtappointmentid.Text = dt.Rows(0)("appointmentid").ToString()
                            .txtpatientid.Text = dt.Rows(0)("patientid").ToString()
                            .txtfullname.Text = dt.Rows(0)("fullname").ToString()
                            .txtdob.Text = dt.Rows(0)("dob").ToString()
                            .txtage.Text = dt.Rows(0)("age").ToString()
                            .txtgender.Text = dt.Rows(0)("gender").ToString()
                            .txtPhone.Text = dt.Rows(0)("phone").ToString()
                            .txtemail.Text = dt.Rows(0)("email").ToString()
                            Dim dob As DateTime
                            If DateTime.TryParse(dt.Rows(0)("dob").ToString(), dob) Then
                                .txtdob.Text = dob.ToString("MM/dd/yyyy")
                            Else
                                .txtdob.Text = String.Empty ' Or handle the error appropriately
                            End If
                            .txtopto.Text = dt.Rows(0)("optomet").ToString()
                            .txtservices.Text = dt.Rows(0)("service").ToString()
                            .ShowDialog()
                        End With
                    Else
                        MsgBox("No record found.", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    GC.Collect()
                End Try
            End Using
        End Using '
    End Sub

    Private Sub btnarchive_Click(sender As Object, e As EventArgs) Handles btnarchive.Click
        With frm_restoreAppointment
            .ShowDialog()
        End With
    End Sub

    Private Sub btnpatient_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        dgv_app.Rows.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT p.patientid, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status FROM tbl_addpatient p JOIN tbl_addappointment a ON p.patientid = a.patientid WHERE a.isdeleted = 1 AND (appointmentid like '%" & txtsearch.Text &
                                       "%' or CONCAT(UPPER(lname),', ',fname,' ', mname,' ', suffix) like '%" & txtsearch.Text &
                                       "%' or dateofapp like '%" & txtsearch.Text &
                                       "%' or service like '%" & txtsearch.Text & "%') ORDER BY fullname", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_app.Rows.Add(dgv_app.Rows.Count + 1, dr.Item("patientid"), dr.Item("fullname"), dr.Item("dateofapp"), dr.Item("stime"), dr.Item("assisted"), dr.Item("optomet"), dr.Item("service"), dr.Item("status"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnsuccess_Click(sender As Object, e As EventArgs) Handles btnsuccess.Click
        frm_success.ShowDialog()
    End Sub
End Class