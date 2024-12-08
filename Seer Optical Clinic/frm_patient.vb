Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization
Public Class frm_patient
    Private Const kur As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
                                        <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub frm_patient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        dgv.Columns("Column7").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        SendMessage(txtsearch.Handle, kur, 0, " Search")
        dgv.RowTemplate.Height = 40
        frm_addpatients.LoadPatients()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        With frm_addpatients
            .cmbregion.Items.Add(" Select Region")
            .cmbregion.SelectedIndex = 0
            .cmbprovince.Items.Add(" Select Province")
            .cmbprovince.SelectedIndex = 0
            .cmbmunicip.Items.Add(" Select Municipality")
            .cmbmunicip.SelectedIndex = 0
            .cmbbrgy.Items.Add(" Select Barangay")
            .cmbbrgy.SelectedIndex = 0
            .txtlname.Select()
            .lbladd.Visible = True
            .lbledit.Visible = False
            .ShowDialog()
        End With
    End Sub
    'Sub loadCart()
    '    Dim _total As Double
    '    dgv.Rows.Clear()
    '    connect()
    '    cmd = New Odbc.OdbcCommand("SELECT a.id,CONCAT(UPPER(lname), ', ', fname, ' ', mname, ' ', suffix) AS fullname,p.fullname FROM tbl_addappointment as a inner join tbl_addpatient as p on a.id = p.id where a.id like '" & frm_addpatients.txtid.Text & "'", con)
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        _total += CDbl(dr.Item("total").ToString)
    '        dgv.Rows.Add(dr.Item("id").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)
    '    End While
    '    dr.Close()
    '    con.Close()
    '    'lbl_Total.Text = Format(_total, "₱##,##0.00")
    'End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim sql As String
        Dim cmd As Odbc.OdbcCommand
        Dim colName As String = dgv.Columns(e.ColumnIndex).Name
        frm_addpatients.lbladd.Visible = False
        frm_addpatients.lbledit.Visible = True
        If colName = "colEdit" Then
            Try
                With frm_addpatients
                    connect()
                    cmd = New Odbc.OdbcCommand("SELECT patientid, lname, fname, mname, suffix, dob, TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age, gender, occupation, phone, guardian, emergency, email, region, province, municip, brgy, address FROM tbl_addpatient WHERE patientid like '" & dgv.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    dr = cmd.ExecuteReader
                    While dr.Read
                        .txtpatientid.Text = dr.GetInt32(0)
                        .txtlname.Text = dr.GetString(1)
                        .txtfname.Text = dr.GetString(2)
                        .txtmname.Text = dr.GetString(3)
                        .cmbsuffix.Text = dr.GetString(4)
                        .cmbregion.Text = dr.GetString(13)
                        .cmbprovince.Text = dr.GetString(14)
                        .cmbmunicip.Text = dr.GetString(15)
                        .cmbbrgy.Text = dr.GetString(16)
                        .txtaddress.Text = dr.GetString(17)
                        .DateTimePicker1.Value = DateTime.Parse(dgv.Rows(e.RowIndex).Cells(3).Value.ToString)
                        .txtage.Text = dgv.Rows(e.RowIndex).Cells(4).Value.ToString
                        .cmbgender.Text = dgv.Rows(e.RowIndex).Cells(5).Value.ToString
                        .txtoccupation.Text = dgv.Rows(e.RowIndex).Cells(6).Value.ToString
                        .txtmobile.Text = dgv.Rows(e.RowIndex).Cells(7).Value.ToString
                        .txtemergency.Text = dgv.Rows(e.RowIndex).Cells(9).Value.ToString
                        .txtemail.Text = dgv.Rows(e.RowIndex).Cells(10).Value.ToString
                        .txtguardian.Text = dgv.Rows(e.RowIndex).Cells(8).Value.ToString
                    End While
                    .btnsave.Visible = False
                    .txtage.ReadOnly = True
                    .btn_search.Visible = False
                    .txtsearch.Visible = False
                    .btnsearch.Visible = False
                    .txtlname.BackColor = Color.FromArgb(232, 244, 248)
                    .txtfname.BackColor = Color.FromArgb(232, 244, 248)
                    .txtmname.BackColor = Color.FromArgb(232, 244, 248)
                    .cmbsuffix.BackColor = Color.FromArgb(232, 244, 248)
                    .txtmobile.BackColor = Color.FromArgb(232, 244, 248)
                    .txtemail.BackColor = Color.FromArgb(232, 244, 248)
                    .txtemergency.BackColor = Color.FromArgb(232, 244, 248)
                    .txtaddress.BackColor = Color.FromArgb(232, 244, 248)

                    'Peachy
                    '.txtlname.BackColor = Color.FromArgb(254, 250, 224)
                    '.txtfname.BackColor = Color.FromArgb(254, 250, 224)
                    '.txtmname.BackColor = Color.FromArgb(254, 250, 224)
                    '.txtsuffix.BackColor = Color.FromArgb(254, 250, 224)
                    '.txtmobile.BackColor = Color.FromArgb(254, 250, 224)
                    '.txtemail.BackColor = Color.FromArgb(254, 250, 224)
                    '.txtemergency.BackColor = Color.FromArgb(254, 250, 224)
                    '.txtaddress.BackColor = Color.FromArgb(254, 250, 224)
                    dr.Close()
                    con.Close()
                    .ShowDialog()
                End With
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End If
        If colName = "colDelete" Then
            If MsgBox("Are you sure you want to delete this patient?", vbQuestion + vbYesNo, "Delete") = vbYes Then
                Try
                    Call connect()
                    sql = "UPDATE tbl_addpatient SET isdeleted=0, isnot=0 WHERE patientid=?"
                    cmd = New Odbc.OdbcCommand(sql, con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("patientid", dgv.CurrentRow.Cells(1).Value.ToString)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Patient deleted successfully!", MsgBoxStyle.Information, "Delete")
                        frm_restore.restore()
                        frm_addpatients.LoadPatients()
                        frm_restoreAppointment.restoreAppointment()
                        frm_appointment.LoadAppointment()
                    Else
                        MsgBox("Patient Delete Failed!", MsgBoxStyle.Exclamation, "Failed")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            End If
        End If
        Try
            frm_addAppointment.cmbfullname.Dispose()
            If colName = "colAppointment" Then
                connect()
                Dim patientId As String = dgv.Rows(e.RowIndex).Cells(1).Value.ToString()
                Dim queryCheckAppointment As String = "SELECT COUNT(*) FROM tbl_addappointment WHERE patientid = ? AND status = 'Pending'"

                Using cmdCheckAppointment As New Odbc.OdbcCommand(queryCheckAppointment, con)
                    cmdCheckAppointment.Parameters.AddWithValue("?", patientId)
                    Dim appointmentCount As Integer = CInt(cmdCheckAppointment.ExecuteScalar())

                    ' If there is a pending appointment, disable editing of colAppointment
                    If appointmentCount > 0 Then
                        dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
                        MessageBox.Show("This patient already has a pending appointment", "Appointment Exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        With frm_addAppointment
                            connect()
                            cmd = New Odbc.OdbcCommand("SELECT patientid, lname, fname, mname, suffix FROM tbl_addpatient WHERE patientid like '" & dgv.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                            dr = cmd.ExecuteReader
                            While dr.Read
                                ._patient = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
                                .txtpatientid.Text = dr.GetInt32(0)
                                .txtfullname.Text = dgv.Rows(e.RowIndex).Cells(2).Value.ToString
                            End While
                            frm_addAppointment.btnsave.Visible = False
                            frm_addAppointment.btnedit.Visible = False
                            dr.Close()
                            con.Close()
                            .ShowDialog()
                        End With
                    End If
                End Using
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Function HasParentheses(word As String) As Boolean
        Return word.Contains("(") AndAlso word.Contains(")")
    End Function
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        dgv.Rows.Clear()
        If txtsearch.Text.Contains(";") Or txtsearch.Text.Contains("""") Then
            MessageBox.Show("Not Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ' Exit the sub to prevent further execution
        End If
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT patientid, CONCAT(UPPER(lname), ', ', fname, ' ', mname, ' ', suffix) AS fullname, dob, TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age, gender, occupation, phone, guardian, emergency, email, CONCAT((region), ', ', province, ' ',  municip, ' ',  brgy, ' ', address) AS address FROM tbl_addpatient WHERE isdeleted=1 AND (patientid like '%" & txtsearch.Text &
                                       "%' or CONCAT(UPPER(lname),', ',fname,' ', mname,' ', suffix) like '%" & txtsearch.Text &
                                       "%' or phone like '%" & txtsearch.Text &
                                       "%' or dob like '%" & txtsearch.Text &
                                       "%' or occupation like '%" & txtsearch.Text &
                                       "%' or email like '%" & txtsearch.Text &
                                       "%' or TIMESTAMPDIFF(YEAR, dob, CURDATE()) like '%" & txtsearch.Text & "%') ORDER BY fullname", con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim address As String = dr.Item("address").ToString()

                Dim textInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo
                Dim capitalizedAddress As String = String.Join(" ", address.Split(" ").
                 Select(Function(word) If(HasParentheses(word), word.ToUpper(), textInfo.ToTitleCase(word.ToLower()))))
                dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("patientid"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("occupation"), dr.Item("gender"), dr.Item("phone"), dr.Item("guardian"), dr.Item("emergency"), dr.Item("email"), capitalizedAddress)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        If e.RowIndex >= 0 Then
            If e.ColumnIndex >= 0 AndAlso dgv.Columns(e.ColumnIndex).Name = "colEdit" Then
                dgv.Rows(e.RowIndex).Cells("colEdit").ToolTipText = "EDIT"
            ElseIf e.ColumnIndex >= 0 AndAlso dgv.Columns(e.ColumnIndex).Name = "colDelete" Then
                dgv.Rows(e.RowIndex).Cells("colDelete").ToolTipText = "DELETE"
            ElseIf e.ColumnIndex >= 0 AndAlso dgv.Columns(e.ColumnIndex).Name = "colAppointment" Then
                dgv.Rows(e.RowIndex).Cells("colAppointment").ToolTipText = "ADD"
            End If
        End If
    End Sub
    Private Sub dgv_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        'If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 AndAlso dgv.Columns(e.ColumnIndex).DefaultCellStyle.WrapMode = DataGridViewTriState.True Then
        '    If e.Value IsNot Nothing Then
        '        e.PaintBackground(e.CellBounds, True)
        '        Dim textSize As SizeF = e.Graphics.MeasureString(e.Value.ToString(), e.CellStyle.Font)
        '        Dim textX As Single = e.CellBounds.Left
        '        Dim textY As Single = e.CellBounds.Bottom - textSize.Height
        '        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Black, textX, textY)
        '        e.Handled = True
        '    End If
        'End If
    End Sub
    Private Sub btnarchive_Click(sender As Object, e As EventArgs) Handles btnarchive.Click
        With frm_restore
            .ShowDialog()
        End With
    End Sub
    Private Sub btnappointment_Click_1(sender As Object, e As EventArgs)
        frm_appointment.Dispose()
        frm_appointment.Show()
        Me.Dispose()
    End Sub

    Private Sub btnemr_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        frm_electronicmedicalrecords.Show()
    End Sub

    Private Sub btninventory_Click(sender As Object, e As EventArgs)

    End Sub
End Class
