Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization
Public Class frm_restore
    Public _restore As String
    Private Const kur As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
                                        <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub frm_restore_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_restore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        SendMessage(txtsearch.Handle, kur, 0, " Search")
        dgv.RowTemplate.Height = 40
        restore()
    End Sub
    Sub restore()
        dgv.Rows.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT patientid, CONCAT(UPPER(lname), ', ', fname, ' ', mname, ' ', suffix) AS fullname, dob, TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age, gender, phone, guardian, emergency, email, CONCAT((region), ', ', province, ' ',  municip, ' ',  brgy, ' ', address) AS address, isdeleted FROM tbl_addpatient WHERE isdeleted=0 ORDER BY fullname", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'frm_patient.dgv.Rows.Add(frm_patient.dgv.Rows.Count + 1, dr.Item("id"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("gender"), dr.Item("phone"), dr.Item("emergency"), dr.Item("email"), dr.Item("address"))
                Dim address As String = dr.Item("address").ToString()

                Dim textInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo
                Dim capitalizedAddress As String = String.Join(" ", address.Split(" ").
                 Select(Function(word) If(HasParentheses(word), word.ToUpper(), textInfo.ToTitleCase(word.ToLower()))))

                dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("patientid"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("gender"), dr.Item("phone"), dr.Item("guardian"), dr.Item("emergency"), dr.Item("email"), capitalizedAddress, dr.Item("isdeleted"))
            End While
            'frm_patient.lblReportCount.Text = "Record count (" & frm_patient.dgv.RowCount & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub
    Function HasParentheses(word As String) As Boolean
        Return word.Contains("(") AndAlso word.Contains(")")
    End Function
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
        '    lblRecentlyDeleted.Text = dgv.Rows(e.RowIndex).Cells("ID").Value
        'End If
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        dgv.Rows.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT id, refno, CONCAT(UPPER(lname),', ',fname,' ', mname,' ', suffix) as fullname, dob, gender, emergency, email, refno, assisted, CONCAT((region), ', ', province, ' ',  municip, ' ',  brgy, ' ', address) AS address, phone, TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age FROM tbl_addpatient WHERE isdeleted=0 AND (id like '%" & txtsearch.Text &
                                       "%' or CONCAT(UPPER(lname),', ',fname,' ', mname,' ', suffix) like '%" & txtsearch.Text &
                                       "%' or refno like '%" & txtsearch.Text &
                                       "%' or phone like '%" & txtsearch.Text &
                                       "%' or address like '%" & txtsearch.Text &
                                       "%' or gender like '%" & txtsearch.Text &
                                       "%' or dob like '%" & txtsearch.Text &
                                       "%' or emergency like '%" & txtsearch.Text &
                                       "%' or email like '%" & txtsearch.Text &
                                       "%' or assisted like '%" & txtsearch.Text &
                                       "%' or CONCAT((region), ', ', province, ' ',  municip, ' ',  brgy, ' ', address) like '%" & txtsearch.Text &
                                       "%' or TIMESTAMPDIFF(YEAR, dob, CURDATE()) like '%" & txtsearch.Text & "%') ORDER BY fullname", con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim address As String = dr.Item("address").ToString()

                Dim textInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo
                Dim capitalizedAddress As String = String.Join(" ", address.Split(" ").
                 Select(Function(word) If(HasParentheses(word), word.ToUpper(), textInfo.ToTitleCase(word.ToLower()))))

                dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("id"), dr.Item("refno"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("gender"), dr.Item("phone"), dr.Item("emergency"), dr.Item("email"), dr.Item("assisted"), capitalizedAddress)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgv_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim colName As String = dgv.Columns(e.ColumnIndex).Name
        If colName = "colRestore" Then
            If MsgBox("Do you want to restore this patient?", vbYesNo + vbQuestion, "Restore") = vbYes Then
                If colName = "colRestore" Then
                    lblRecentlyDeleted.Text = dgv.Rows(e.RowIndex).Cells("ID").Value
                    Try
                        connect()
                        cmd = New Odbc.OdbcCommand("UPDATE tbl_addpatient SET isdeleted=1, isnot=1 WHERE patientid='" & lblRecentlyDeleted.Text & "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("The record was restored successfully!", vbInformation, "Restore")
                        frm_addpatients.LoadPatients()
                        restore()
                        lblRecentlyDeleted.ResetText()
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    Finally
                        con.Close()
                    End Try
                End If
            End If
        End If
    End Sub
End Class