Imports System.Data.Odbc
Imports System.IO

Public Class frm_Main

    Private Sub frm_Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        connect()
        Me.KeyPreview = True
        UpdateRecordCount() ' Call UpdateRecordCount method to display count when form loads
        AppCount()
    End Sub
    Private Sub btn_logOut_Click(sender As Object, e As EventArgs) Handles btn_logOut.Click
        If MsgBox("Are you sure you want to Log Out?", vbQuestion + vbYesNo, "Log Out") = vbYes Then
            Me.Dispose()
            Log("OUT")
            'AuditTrail("Log Out")
            'With frm_Login
            '    'GetSettings()
            '    '.lblShop.Text = _systemtitle
            '    .Show()
            'End With
            Call frm_Login.txtUsername.Focus()
            With frm_Login
                .txtUsername.Clear()
                .txtPassword.Clear()
            End With
        Else
            Return
        End If
    End Sub
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Me.KeyPreview = True
        UpdateRecordCount() ' Call UpdateRecordCount method to display count when form loads
        AppCount()
    End Sub
    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        If frm_patient IsNot Nothing Then
            frm_patient.Dispose()
        End If
        With frm_patient
            .TopLevel = False
            controlPanel.Controls.Add(frm_patient)
            .BringToFront()
            .Show()
            '.Refresh()
        End With
    End Sub
    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        If frm_appointment IsNot Nothing Then
            frm_appointment.Dispose()
        End If
        With frm_appointment
            .TopLevel = False
            controlPanel.Controls.Add(frm_appointment)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnEMR_Click(sender As Object, e As EventArgs) Handles btnEMR.Click
        If frm_electronicmedicalrecords IsNot Nothing Then
            frm_electronicmedicalrecords.Dispose()
        End If
        With frm_electronicmedicalrecords
            .TopLevel = False
            controlPanel.Controls.Add(frm_electronicmedicalrecords)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        With frm_TransactionModule
            .ShowDialog()
        End With
    End Sub
    Private Sub btninventory_Click_1(sender As Object, e As EventArgs) Handles btninventory.Click
        With frm_Inventory2
            '.TopLevel = False
            'controlPanel.Controls.Add(frm_Inventory2)
            '.BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        frm_reports.ShowDialog()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        frm_Maintenance.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub UpdateRecordCount()
        Dim recordCount As Integer = GetRecordCount()
        lblpatientcount.Text = recordCount.ToString()
    End Sub

    Private Function GetRecordCount() As Integer
        Dim count As Integer = 0
        Dim sql As String = "SELECT COUNT(*) FROM tbl_addpatient WHERE isdeleted = 1"
        Try
            Using cmd As New OdbcCommand(sql, con)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        Return count
    End Function

    Private Sub AppCount()
        Dim appCount As Integer = GetAppCount()
        lblappcount.Text = appCount.ToString()
    End Sub

    Private Function GetAppCount() As Integer
        Dim totalCount As Integer = 0
        Dim successCount As Integer = 0
        Dim sqlTotal As String = "SELECT COUNT(*) FROM tbl_addappointment WHERE isdeleted = 1"
        Dim sqlSuccess As String = "SELECT COUNT(*) FROM tbl_addappointment WHERE status = 'Success' AND isdeleted = 1"

        Try
            ' Ensure the connection is open
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ' Get the total count of appointments where isdeleted = 1
            Using cmdTotal As New OdbcCommand(sqlTotal, con)
                totalCount = Convert.ToInt32(cmdTotal.ExecuteScalar())
            End Using

            ' Get the count of successful appointments (status = 'Success')
            Using cmdSuccess As New OdbcCommand(sqlSuccess, con)
                successCount = Convert.ToInt32(cmdSuccess.ExecuteScalar())
            End Using

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        Finally
            ' Ensure the connection is closed after the operation
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' Subtract the number of successful appointments from the total count
        Dim appCount As Integer = totalCount - successCount

        ' Ensure count does not go below 0
        If appCount < 0 Then
            appCount = 0
        End If

        Return appCount
    End Function


    Private Sub btnsave_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnMaintenance_Click_2(sender As Object, e As EventArgs)
        With frm_Maintenance
            .ShowDialog()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        frm_reports.Show()
    End Sub

    Private Sub controlPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frm_patient.Close()
        frm_electronicmedicalrecords.Close()
        frm_appointment.Close()
    End Sub
End Class
