Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Public Class frm_services

    Private Sub frm_Category_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Dispose()
    End Sub
    Private Sub frm_Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Me.Show()
        txtservices.Select()
        Me.KeyPreview = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtservices.Text = String.Empty Then
            MsgBox("Please input services", vbExclamation, "Required missing field")
            Return
        End If
        Try
            connect()
            cmd = New Odbc.OdbcCommand("INSERT INTO tbl_services (services) VALUES(?)", con)
            With cmd.Parameters
                .AddWithValue("?", txtservices.Text)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Sevices saved successfully", vbInformation, "Success")
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
        'frm_addAppointment.loadservices()
        txtservices.Clear()
        Me.Dispose()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Private Sub txtservices_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtservices.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub pnlTopCat_Paint(sender As Object, e As PaintEventArgs) Handles pnlTopCat.Paint

    End Sub
End Class