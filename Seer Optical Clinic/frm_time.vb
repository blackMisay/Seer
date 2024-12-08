Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Public Class frm_time

    Private Sub frm_Category_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Dispose()
    End Sub
    Private Sub frm_Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Me.Show()
        txttime.Select()
        Me.KeyPreview = True
    End Sub
    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    If txttime.Text = String.Empty Then
    '        MsgBox("Please input time", vbExclamation, "Required missing field")
    '        Return
    '    End If
    '    Try
    '        connect()
    '        cmd = New Odbc.OdbcCommand("INSERT INTO tbl_time (oras) VALUES(?)", con)
    '        With cmd.Parameters
    '            .AddWithValue("?", txttime.Text)
    '        End With
    '        cmd.ExecuteNonQuery()
    '        MsgBox("Time saved successfully", vbInformation, "Success")
    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    End Try
    '    'frm_addAppointment.loadtime()
    '    txttime.Clear()
    '    Me.Dispose()
    'End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
    Private Sub txttime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttime.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub
End Class