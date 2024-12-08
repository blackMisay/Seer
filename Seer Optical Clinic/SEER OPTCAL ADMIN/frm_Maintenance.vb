Public Class frm_Maintenance
    Private Sub frm_Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLog.RowTemplate.Height = 40
        dgvUser.RowTemplate.Height = 40
        loadUser()
        loadLogHistory()
    End Sub
    Sub loadUser()
        Try
            dgvUser.Rows.Clear()
            Call connect()
            cmd = New Odbc.OdbcCommand("SELECT * FROM tbl_users WHERE name like '" & frm_Register.txtLoginName.Text & "%' ORDER BY name", con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                dgvUser.Rows.Add(dr.Item("name"), dr.Item("username"), dr.Item("password"), dr.Item("role").ToString)
            End While
            dr.Close()
            con.Close()
            'lblUserCount.Text = "Record count (" & dgvUser.RowCount & ")"
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub loadLogHistory()
        dgvLog.Rows.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT * FROM `tbl_log` WHERE id ORDER BY CASE WHEN status='Online' THEN 0 ELSE 1 END", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvLog.Rows.Add(dgvLog.Rows.Count + 1, dr.Item("id"), dr.Item("role"), dr.Item("user"), dr.Item("sdate"), dr.Item("timein"), dr.Item("timeout"), dr.Item("status"))
            End While
            'lblLog.Text = "Record count (" & dgvLog.RowCount & ")"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub dgvLog_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLog.CellFormatting
        If e.ColumnIndex = 7 AndAlso e.RowIndex >= 0 Then
            Dim cellValue As String = dgvLog.Rows(e.RowIndex).Cells(7).Value.ToString()
            If cellValue = "Online" Then
                ' Set the font color to green for the "Online" status
                e.CellStyle.ForeColor = Color.Green
            Else
                ' Set the font color to your desired default color for other statuses
                e.CellStyle.ForeColor = dgvLog.DefaultCellStyle.ForeColor
            End If
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        With frm_Register
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'Dim sql As String
        'Dim cmd As Odbc.OdbcCommand
        Dim colName As String = dgvUser.Columns(e.ColumnIndex).Name
        frm_Register.lblreg.Visible = False
        frm_Register.lblEdit.Visible = True
        If colName = "colEditsss" Then
            Try
                With frm_Register
                    ._user = dgvUser.Rows(e.RowIndex).Cells(0).Value.ToString
                    .txtLoginName.Text = dgvUser.Rows(e.RowIndex).Cells(0).Value.ToString
                    .comboRule.Text = dgvUser.Rows(e.RowIndex).Cells(3).Value.ToString
                    '.txtUser.Text = dgvUser.Rows(e.RowIndex).Cells(1).Value.ToString
                    .btnEdit.Visible = True
                    .txtPass.Enabled = False
                    .txtUser.Enabled = False
                    '.comboRule.Enabled = False
                    .btnC.Visible = True
                    .btnChange.Visible = False
                    '.btnRegister.Enabled = False
                    .btnRegister.Visible = False
                    .btnLoginExit.Visible = False
                    '.lblRegister.Visible = False
                    '.btn_close.Visible = False
                    .checkHide.Visible = False
                    .checkHideEye.Visible = False
                    .ShowDialog()
                End With
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
            '    End If
            '    If colName = "colDelete" Then
            '        If MsgBox("Are you sure you want to delete this patient?", vbQuestion + vbYesNo, "Delete") = vbYes Then
            '            Try
            '                Call connect()
            '                sql = "UPDATE tbl_addpatient SET isdeleted=0, isnot=0 WHERE patientid=?"
            '                cmd = New Odbc.OdbcCommand(sql, con)
            '                cmd.Parameters.Clear()
            '                cmd.Parameters.AddWithValue("patientid", dgv.CurrentRow.Cells(1).Value.ToString)
            '                i = cmd.ExecuteNonQuery
            '                If i > 0 Then
            '                    MsgBox("Patient deleted successfully!", MsgBoxStyle.Information, "Delete")
            '                    frm_restore.restore()
            '                    frm_addpatients.LoadPatients()
            '                    frm_restoreAppointment.restoreAppointment()
            '                    frm_appointment.LoadAppointment()
            '                Else
            '                    MsgBox("Patient Delete Failed!", MsgBoxStyle.Exclamation, "Failed")
            '                End If
            '            Catch ex As Exception
            '                MsgBox(ex.Message)
            '            Finally
            '                con.Close()
            '            End Try
            '        End If
        End If
    End Sub
End Class