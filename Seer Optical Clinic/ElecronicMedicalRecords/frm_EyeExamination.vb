Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization
Public Class frm_EyeExamination
    Private Const kur As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
                                        <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub frm_AddNewPrescript_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_AddNewPrescript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        'Load patients
        'LoadPatient()
        'LoadFeatures()
        'LoadPres()
        'frm_appointment.loadDataView(appointmentid)
        'cmbPatientName.SelectedIndex = -1
        'frm_appointment.loadDataView()
    End Sub
    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtSph.Text = String.Empty Then
                MsgBox("Please Input SPHERE", vbExclamation, "Required missing field")
                txtSph.Select()
                Return
            End If
            If txtCyl.Text = String.Empty Then
                MsgBox("Please Input CYLINDER", vbExclamation, "Required missing field")
                txtCyl.Select()
                Return
            End If
            If txtAxis.Text = String.Empty Then
                MsgBox("Please Input Patient Name", vbExclamation, "Required missing field")
                txtAxis.Select()
                Return
            End If
            If txtVa.Text = String.Empty Then
                MsgBox("Please Input VA", vbExclamation, "Required missing field")
                txtVa.Select()
                Return
            End If
            If txtSEGHT.Text = String.Empty Then
                MsgBox("Please Input SEGHT", vbExclamation, "Required missing field")
                txtSEGHT.Select()
                Return
            End If
            If Sph.Text = String.Empty Then
                MsgBox("Please Input SPHERE", vbExclamation, "Required missing field")
                Sph.Select()
                Return
            End If
            If Cyl.Text = String.Empty Then
                MsgBox("Please Input CYLINDER", vbExclamation, "Required missing field")
                Cyl.Select()
                Return
            End If
            If Axis.Text = String.Empty Then
                MsgBox("Please Input AXIS", vbExclamation, "Required missing field")
                Axis.Select()
                Return
            End If
            If Va.Text = String.Empty Then
                MsgBox("Please Input Va", vbExclamation, "Required missing field")
                Va.Select()
                Return
            End If
            If Verht.Text = String.Empty Then
                MsgBox("Please Input VERHT", vbExclamation, "Required missing field")
                Verht.Select()
                Return
            End If
            If txtPD.Text = String.Empty Then
                MsgBox("Please Input Patient Name", vbExclamation, "Required missing field")
                txtPD.Select()
                Return
            End If
            ' Open the connection
            connect()

            ' Define the insert command
            Dim query As String = "INSERT INTO tbl_prescription (patientid, doE, sphright , cylright, axisright, axisleft, varight, addright, monoright, sight, verht, sphleft, cylleft, valeft, addleft, monoleft, pd, remark, isdeleted) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As New Odbc.OdbcCommand(query, con)

            ' Add parameters to the command
            With cmd.Parameters
                .AddWithValue("?", txtpatientid.Text)
                .AddWithValue("?", DateofExam.Value.Date)
                .AddWithValue("?", txtSph.Text)
                .AddWithValue("?", txtCyl.Text)
                .AddWithValue("?", txtAxis.Text)
                .AddWithValue("?", txtVa.Text)
                .AddWithValue("?", txtAdd.Text)
                .AddWithValue("?", txtMono.Text)
                .AddWithValue("?", txtSEGHT.Text)
                .AddWithValue("?", Verht.Text)
                .AddWithValue("?", Sph.Text)
                .AddWithValue("?", Cyl.Text)
                .AddWithValue("?", Axis.Text)
                .AddWithValue("?", Va.Text)
                .AddWithValue("?", Add.Text)
                .AddWithValue("?", Mono.Text)
                .AddWithValue("?", txtPD.Text)
                .AddWithValue("?", txtremarks.Text)
                .AddWithValue("?", CBool(checkboxStatus.Checked))
            End With

            'Dim query As String = "INSERT INTO tbl_lensandframe (lensType, lensSide, lensFor, trans, polar, uv, photoromic, scratch, reflective, lensPrice, frameType, brand, model, fcolor, addPrice, framePrice, subtotal, isdeleted) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?"
            'Dim cmd As New Odbc.OdbcCommand(query, con)

            'With cmd.Parameters
            '    .AddwithValue("?", cmbtype.Text)
            '    .AddwithValue("?", cmbside.Text)
            '    .AddwithValue("?", cmbfor.Text)
            '    .AddwithValue("?", cbtrans.Text)
            '    .AddwithValue("?", cbpola.Text)
            '    .AddwithValue("?", cbuv.Text)
            '    .AddwithValue("?", cbphoto.Text)
            '    .AddwithValue("?", cbscratch.Text)
            '    .AddwithValue("?", cbref.Text)
            '    .AddwithValue("?", txtLensprice.Text)
            '    .AddwithValue("?", cmbtypef.Text)
            '    .AddwithValue("?", cmbbrand.Text)
            '    .AddwithValue("?", cmbmodel.Text)
            '    .AddwithValue("?", cmbfcolor.Text)
            '    .AddwithValue("?", txtaddprice.Text)
            '    .AddwithValue("?", txtframeprice.Text)
            '    .AddwithValue("?", txttotal.Text)
            '    .AddwithValue("?", CBool(isdeleted.Checked))
            'End With


            ' Execute the insert command
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Saved", vbInformation, "Save!")
            frm_appointment.LoadAppointment()
            frm_electronicmedicalrecords.LoadPres()
            Me.Dispose()


            connect()
            ' Update the status in tbl_addappointment
            Dim updateQuery As String = "UPDATE tbl_addappointment SET status = 'Success' WHERE appointmentid = ?"
            cmd = New Odbc.OdbcCommand(updateQuery, con)
            cmd.Parameters.AddWithValue("?", txtappointmentid.Text)

            ' Execute the update command
            cmd.ExecuteNonQuery()
            frm_appointment.LoadAppointment()
            con.Close()


            connect()
            Dim updateQuerys As String = "UPDATE tbl_addpatient SET isnot = 1 WHERE patientid = ?"
            cmd = New Odbc.OdbcCommand(updateQuerys, con)
            cmd.Parameters.AddWithValue("?", txtpatientid.Text)
            ' Execute the update command
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Error")
        Finally
            ' Ensure the connection is closed
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        'connect()
        'cmd = New Odbc.OdbcCommand("UPDATE tbl_addappointment SET status = 'Success'", con)
        'cmd.Parameters.AddWithValue("?", id)
        'cmd.ExecuteNonQuery()
        'con.Close()

        'Catch ex As Exception
        '    MessageBox.Show("Error occurred while saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub btncancel_Click_1(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
