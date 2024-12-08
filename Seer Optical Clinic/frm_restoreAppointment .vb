Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization
Public Class frm_restoreAppointment
    Public _restore As String
    Private Const kur As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
                                        <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub frm_restoreAppointment_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgv.RowTemplate.Height = 40
        restoreAppointment()
    End Sub
    Private Sub frm_restoreAppointment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_restoreAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        SendMessage(txtsearch.Handle, kur, 0, " Search")
        restoreAppointment()
        dgv.RowTemplate.Height = 40
    End Sub

    Sub restoreAppointment()
        dgv.Rows.Clear()
        Try
            connect()
            'SELECT a.appointmentid, p.patientid, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status FROM tbl_addpatient p LEFT JOIN tbl_addappointment a ON a.patientid = p.patientid WHERE p.isdeleted = 1 ORDER BY fullname
            cmd = New Odbc.OdbcCommand("SELECT p.patientid, " & _
                                "CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, " & _
                                "a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status " & _
                                "FROM tbl_addpatient p " & _
                                "LEFT JOIN tbl_addappointment a ON a.patientid = p.patientid " & _
                                "WHERE a.patientid AND a.isdeleted = 0  ORDER by fullname", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'frm_patient.dgv.Rows.Add(frm_patient.dgv.Rows.Count + 1, dr.Item("id"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("gender"), dr.Item("phone"), dr.Item("emergency"), dr.Item("email"), dr.Item("address"))
                dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("patientid"), dr.Item("fullname"), dr.Item("dateofapp"), dr.Item("stime"), dr.Item("assisted"), dr.Item("optomet"), dr.Item("service"), dr.Item("status"))
            End While
            'frm_patient.lblReportCount.Text = "Record count (" & frm_patient.dgv.RowCount & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        'If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
        '    lblRecentlyDeleted.Text = dgv.Rows(e.RowIndex).Cells("ID").Value
        'End If
    End Sub
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim cmd As Odbc.OdbcCommand
        Dim colName As String = dgv.Columns(e.ColumnIndex).Name

        If colName = "colRestore" Then
            If MsgBox("Do you want to restore this record?", vbYesNo + vbQuestion, "Restore") = vbYes Then
                lblRecentlyDeleted.Text = dgv.Rows(e.RowIndex).Cells("ID").Value.ToString()
                Try
                    connect()
                    cmd = New Odbc.OdbcCommand("UPDATE tbl_addappointment SET isdeleted=1 WHERE appointmentid=?", con)
                    cmd.Parameters.AddWithValue("patientid", lblRecentlyDeleted.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("The record was restored successfully!", vbInformation, "Restore")
                    frm_appointment.LoadAppointment()
                    restoreAppointment()
                    lblRecentlyDeleted.ResetText()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub
    'Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
    '    dgv.Rows.Clear()
    '    Try
    '        connect()
    '        cmd = New Odbc.OdbcCommand("SELECT id, CONCAT(UPPER(lname),', ',fname,' ', mname,' ', suffix) as fullname, dob, gender, emergency, email, services, oras, CONCAT((region), ', ', province, ' ',  municip, ' ',  brgy, ' ', address) AS address, phone, TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age FROM tbl_addappointment WHERE isdeleted=0 AND (id like '%" & txtsearch.Text &
    '                                   "%' or CONCAT(UPPER(lname),', ',fname,' ', mname,' ', suffix) like '%" & txtsearch.Text &
    '                                   "%' or phone like '%" & txtsearch.Text &
    '                                   "%' or address like '%" & txtsearch.Text &
    '                                   "%' or gender like '%" & txtsearch.Text &
    '                                   "%' or dob like '%" & txtsearch.Text &
    '                                   "%' or emergency like '%" & txtsearch.Text &
    '                                   "%' or email like '%" & txtsearch.Text &
    '                                   "%' or services like '%" & txtsearch.Text &
    '                                   "%' or oras like '%" & txtsearch.Text &
    '                                   "%' or CONCAT((region), ', ', province, ' ',  municip, ' ',  brgy, ' ', address) like '%" & txtsearch.Text &
    '                                   "%' or TIMESTAMPDIFF(YEAR, dob, CURDATE()) like '%" & txtsearch.Text & "%') ORDER BY fullname", con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            Dim address As String = dr.Item("address").ToString()

    '            Dim textInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo
    '            Dim capitalizedAddress As String = String.Join(" ", address.Split(" ").
    '             Select(Function(word) If(HasParentheses(word), word.ToUpper(), textInfo.ToTitleCase(word.ToLower()))))

    '            dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("id"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("gender"), dr.Item("phone"), dr.Item("emergency"), dr.Item("email"), dr.Item("services"), dr.Item("oras"), capitalizedAddress)
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub
End Class