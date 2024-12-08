Public Class frm_ManageDoctor

    Private Sub frm_ManageDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Me.Show()
        Me.KeyPreview = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtlname.Text = String.Empty Then
            MsgBox("Please input your Last Name", vbExclamation, "Required missing field")
            Return
        End If
        If txtfname.Text = String.Empty Then
            MsgBox("Please input your First Name", vbExclamation, "Required missing field")
            Return
        End If
        Try
            connect()
            cmd = New Odbc.OdbcCommand("INSERT INTO optometrist (lname, fname, mname, suffix) VALUES(?,?,?,?)", con)
            With cmd.Parameters
                .AddWithValue("?", txtlname.Text)
                .AddWithValue("?", txtfname.Text)
                .AddWithValue("?", txtmname.Text)
                .AddWithValue("?", cmbsuffix.Text)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Optometrist saved successfully", vbInformation, "Success")
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
        frm_addAppointment.loadOptometrist()
        txtlname.Clear()
        txtfname.Clear()
        txtmname.Clear()
        Me.Dispose()
    End Sub

    Private Sub txtlname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlname.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub txtlname_TextChanged(sender As Object, e As EventArgs) Handles txtlname.TextChanged

    End Sub
End Class