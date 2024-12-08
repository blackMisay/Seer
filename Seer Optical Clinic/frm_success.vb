Public Class frm_success

    Private Sub frm_success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_app.RowTemplate.Height = 40
        loadDGV()
    End Sub

    Private Sub loadDGV()
        dgv_app.Rows.Clear()
        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        Try
            connect()
            Dim cmd As New Odbc.OdbcCommand("SELECT p.patientid, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status FROM tbl_addpatient p LEFT JOIN tbl_addappointment a ON a.patientid = p.patientid WHERE a.status = 'Success' AND dateofapp between '" & sdate & "' and '" & sdate & "' ORDER BY fullname", con)
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

    Private Sub btn_Filter_Click_1(sender As Object, e As EventArgs) Handles btn_Filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        dgv_app.Rows.Clear()
        Try
            connect()
            Dim cmd As New Odbc.OdbcCommand("SELECT p.patientid, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, a.dateofapp, a.stime, a.assisted, a.optomet, a.service, a.status FROM tbl_addpatient p LEFT JOIN tbl_addappointment a ON a.patientid = p.patientid WHERE a.status = 'Success' AND a.dateofapp between '" & date1 & "' and '" & date2 & "'  ORDER BY fullname", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_app.Rows.Add(dgv_app.Rows.Count + 1, dr.Item("patientid"), dr.Item("fullname"), dr.Item("dateofapp"), dr.Item("stime"), dr.Item("assisted"), dr.Item("optomet"), dr.Item("service"), dr.Item("status"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
