﻿Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization
Public Class frm_electronicmedicalrecords
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
                                        <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub frm_patient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_electronicmedicalrecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        dgv.RowTemplate.Height = 40
        RoundButton(btnView)
        LoadPres()
        'RoundButton(btnpayment)
    End Sub
    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnView.Width, 20, btn.Width, btn.Height - 10)
        'Raduis.AddLine(btnpayment.Width, 20, btn.Width, btn.Height - 10)
        'Raduis.AddLine(btnEdit.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btnView.Region = New Region(Raduis)
        'btnpayment.Region = New Region(Raduis)
        'btnEdit.Region = New Region(Raduis)
    End Sub
    Sub LoadPres()
        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        dgv.Rows.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT pr.patientID, pr.doE, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, CONCAT('OD ', UPPER(pr.sphright), ' OS ', UPPER(pr.sphleft)) AS SPH, CONCAT('OD ', UPPER(pr.cylright), ' OS ', UPPER(pr.cylleft)) AS CYL, CONCAT('OD ', pr.axisright, ' OS ', pr.axisleft) AS AXIS, CONCAT('OD ', UPPER(pr.varight), ' OS ', UPPER(pr.valeft)) AS VA, CONCAT('OD ', UPPER(pr.addright), ' OS ', UPPER(pr.addleft)) AS ADDITIONAL, CONCAT('OD ', UPPER(pr.monoright), ' OS ', UPPER(pr.monoleft)) AS MONO, CONCAT('OD ', UPPER(pr.sight), ' OS ', UPPER(pr.verht)) AS SEGHTVERHT, pr.pd, pr.remark, a.dateofapp FROM tbl_addpatient p JOIN tbl_prescription pr JOIN tbl_addappointment a ON p.patientid = pr.patientID = a.appointmentid WHERE pr.doE between '" & sdate & "' and '" & sdate & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("patientID"), dr.Item("doE"), dr.Item("fullname"), dr.Item("SPH"), dr.Item("CYL"), dr.Item("AXIS"), dr.Item("VA"), dr.Item("ADDITIONAL"), dr.Item("MONO"), dr.Item("SEGHTVERHT"), dr.Item("pd"), dr.Item("remark"), dr.Item("dateofapp"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub loadDataView(id As String)
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM vwemr WHERE patientID = ?"
        connect()  ' Ensure the connection is open

        Using cmd As New Odbc.OdbcCommand(sql, con)
            'MsgBox(id)
            cmd.Parameters.AddWithValue("?", id)

            Using da As New Odbc.OdbcDataAdapter(cmd)
                Try
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Dim viewsForm As New frm_ViewMore()
                        With viewsForm
                            .txtpatientid.Text = dt.Rows(0)("patientid").ToString()
                            .txtfullname.Text = dt.Rows(0)("fullname").ToString()
                            .txtdob.Text = dt.Rows(0)("dob").ToString()
                            Dim dob As DateTime
                            If DateTime.TryParse(dt.Rows(0)("dob").ToString(), dob) Then
                                .txtdob.Text = dob.ToString("MM/dd/yyyy")
                            Else
                                .txtdob.Text = String.Empty ' Or handle the error appropriately
                            End If
                            .age.Text = dt.Rows(0)("age").ToString()
                            .txtgender.Text = dt.Rows(0)("gender").ToString()
                            .txtphone.Text = dt.Rows(0)("phone").ToString()
                            .email.Text = dt.Rows(0)("email").ToString()
                            .txtSph.Text = dt.Rows(0)("sphright").ToString()
                            .Sph.Text = dt.Rows(0)("sphleft").ToString()
                            .txtCyl.Text = dt.Rows(0)("cylright").ToString()
                            .Cyl.Text = dt.Rows(0)("cylleft").ToString()
                            .txtAxis.Text = dt.Rows(0)("axisright").ToString()
                            .Axis.Text = dt.Rows(0)("axisleft").ToString()
                            .txtVa.Text = dt.Rows(0)("varight").ToString()
                            .Va.Text = dt.Rows(0)("valeft").ToString()
                            .txtAdd.Text = dt.Rows(0)("addright").ToString()
                            .Add.Text = dt.Rows(0)("addleft").ToString()
                            .txtMono.Text = dt.Rows(0)("monoright").ToString()
                            .Mono.Text = dt.Rows(0)("monoleft").ToString()
                            .txtSEGHT.Text = dt.Rows(0)("sight").ToString()
                            .Verht.Text = dt.Rows(0)("verht").ToString()
                            .txtPD.Text = dt.Rows(0)("pd").ToString()
                            .txtremarks.Text = dt.Rows(0)("remark").ToString()
                            '.lbldateofapp.Text = dt.Rows(0)("dateofapp").ToString()
                            .cmbopto.Text = dt.Rows(0)("optomet").ToString()
                            '.lblservice.Text = dt.Rows(0)("service").ToString()
                            .ShowDialog()
                        End With
                    Else
                        MsgBox("No record found.", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                Finally
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    GC.Collect()
                End Try
            End Using
        End Using '
    End Sub
    Private Sub dgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim cmd As Odbc.OdbcCommand
        Dim colName As String = dgv.Columns(e.ColumnIndex).Name
        frm_EyeExamination.lbladdpres.Visible = False
        frm_EyeExamination.lbleditpres.Visible = True
        If colName = "colEdit" Then
            Try
                With frm_EyeExamination
                    connect()
                    cmd = New Odbc.OdbcCommand("SELECT pr.patientid, pr.doE, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, pr.sphright , pr.cylright, pr.axisright, pr.axisleft, pr.varight, pr.addright, pr.monoright, pr.sight, pr.verht, pr.sphleft, pr.cylleft, pr.valeft, pr.addleft, pr.monoleft, pr.pd, pr.remark, a.dateofapp FROM tbl_addpatient p JOIN tbl_prescription pr JOIN tbl_addappointment a ON p.patientid = pr.patientID = a.appointmentid WHERE pr.patientid like '" & dgv.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    dr = cmd.ExecuteReader
                    While dr.Read
                        .txtpatientid.Text = dr.GetInt32(0)
                        '.DateofExam.Value = DateTime.Parse(dgv.Rows(e.RowIndex).Cells(1).Value.ToString)
                        .txtSph.Text = dr.GetString(3)
                        .txtCyl.Text = dr.GetString(4)
                        .txtAxis.Text = dr.GetString(5)
                        .Axis.Text = dr.GetString(6)
                        .txtVa.Text = dr.GetString(7)
                        .txtAdd.Text = dr.GetString(8)
                        .txtMono.Text = dr.GetString(9)
                        .txtSEGHT.Text = dr.GetString(10)
                        .Verht.Text = dr.GetString(11)
                        .Sph.Text = dr.GetString(12)
                        .Cyl.Text = dr.GetString(13)
                        .Va.Text = dr.GetString(14)
                        .Add.Text = dr.GetString(15)
                        .Mono.Text = dr.GetDecimal(16)
                        .txtPD.Text = dr.GetString(17)
                        .txtremarks.Text = dr.GetString(18)
                    End While
                    .btnsave.Visible = False
                    .txtage.ReadOnly = True
                    '.btn_search.Visible = False
                    '.txtsearch.Visible = False
                    '.btnsearch.Visible = False
                    '.txtlname.BackColor = Color.FromArgb(232, 244, 248)
                    '.txtfname.BackColor = Color.FromArgb(232, 244, 248)
                    '.txtmname.BackColor = Color.FromArgb(232, 244, 248)
                    '.cmbsuffix.BackColor = Color.FromArgb(232, 244, 248)
                    '.txtmobile.BackColor = Color.FromArgb(232, 244, 248)
                    '.txtemail.BackColor = Color.FromArgb(232, 244, 248)
                    '.txtemergency.BackColor = Color.FromArgb(232, 244, 248)
                    '.txtaddress.BackColor = Color.FromArgb(232, 244, 248)

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
        If colName = "colAddLF" Then
            Try
                With frm_TransactionModule
                    connect()

                    'Prepare the SQL command with parameterized query
                    cmd = New Odbc.OdbcCommand("SELECT * FROM vwemr WHERE patientID = ?", con)

                    'Bind the parameter to the query (assuming the patientID is in the 2nd column (Cells(1)))
                    cmd.Parameters.AddWithValue("@patientID", dgv.Rows(e.RowIndex).Cells(1).Value.ToString())

                    'Execute the command
                    dr = cmd.ExecuteReader()

                    'Assuming dt is correctly populated elsewhere, fill the form fields
                    If dr.Read() Then
                        .txtpatientID.Text = dr("patientID").ToString
                        .lbloptomet.Text = dr("optomet").ToString()
                        Dim dateOfExam As DateTime
                        If DateTime.TryParse(dr("doE").ToString(), dateOfExam) Then
                            .lblDoe.Text = dateOfExam.ToString("dddd, dd, yyyy")
                        Else
                            .lblDoe.Text = dr("doE").ToString() ' In case parsing fails, fallback to the original value
                        End If
                        .lblfullname.Text = dr("fullname").ToString()
                        .lblphone.Text = dr("phone").ToString()
                        .lblemail.Text = dr("email").ToString()
                        .txtSph.Text = dr("sphright").ToString()
                        .Sph.Text = dr("sphleft").ToString()
                        .txtCyl.Text = dr("cylright").ToString()
                        .Cyl.Text = dr("cylleft").ToString()
                        .txtAxis.Text = dr("axisright").ToString()
                        .Axis.Text = dr("axisleft").ToString()
                        .txtVa.Text = dr("varight").ToString()
                        .Va.Text = dr("valeft").ToString()
                        .txtAdd.Text = dr("addright").ToString()
                        .Add.Text = dr("addleft").ToString()
                        .txtMono.Text = dr("monoright").ToString()
                        .Mono.Text = dr("monoleft").ToString()
                        .txtSEGHT.Text = dr("sight").ToString()
                        .Verht.Text = dr("verht").ToString()
                        .txtPD.Text = dr("pd").ToString()
                        .txtremarks.Text = dr("remark").ToString()
                    Else
                    End If
                    .ShowDialog()
                    .Dispose()
                End With
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                con.Close()
            End Try
        End If
        Try
            dgv.Tag = dgv.Item(1, e.RowIndex).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If dgv.Tag IsNot Nothing AndAlso dgv.Tag.ToString() <> "0" Then
            loadDataView(dgv.Tag)
            dgv.Tag = "0" ' Reset the tag after processing
        Else
            MsgBox("Please select a record to View Prescription", vbExclamation)
        End If
    End Sub
    Function HasParentheses(word As String) As Boolean
        Return word.Contains("(") AndAlso word.Contains(")")
    End Function
    Private Sub btn_Filter_Click(sender As Object, e As EventArgs) Handles btn_Filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        dgv.Rows.Clear()

        Try
            connect()
            Dim query As String = "SELECT pr.patientID, pr.doE, " & _
                                  "CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, " & _
                                  "CONCAT('OD ', UPPER(pr.sphright), ' OS ', UPPER(pr.sphleft)) AS SPH, " & _
                                  "CONCAT('OD ', UPPER(pr.cylright), ' OS ', UPPER(pr.cylleft)) AS CYL, " & _
                                  "CONCAT('OD ', pr.axisright, ' OS ', pr.axisleft) AS AXIS, " & _
                                  "CONCAT('OD ', UPPER(pr.varight), ' OS ', UPPER(pr.valeft)) AS VA, " & _
                                  "CONCAT('OD ', UPPER(pr.addright), ' OS ', UPPER(pr.addleft)) AS ADDITIONAL, " & _
                                  "CONCAT('OD ', UPPER(pr.monoright), ' OS ', UPPER(pr.monoleft)) AS MONO, " & _
                                  "CONCAT('OD ', UPPER(pr.sight), ' OS ', UPPER(pr.verht)) AS SEGHTVERHT, " & _
                                  "pr.pd, pr.remark, a.dateofapp " & _
                                  "FROM tbl_addpatient p " & _
                                  "JOIN tbl_prescription pr ON p.patientid = pr.patientID " & _
                                  "JOIN tbl_addappointment a ON p.patientid = a.patientid " & _
                                  "WHERE pr.doE BETWEEN ? AND ?"

            cmd = New Odbc.OdbcCommand(query, con)
            cmd.Parameters.AddWithValue("?", date1)
            cmd.Parameters.AddWithValue("?", date2)

            dr = cmd.ExecuteReader
            While dr.Read
                dgv.Rows.Add(dgv.Rows.Count + 1, dr("patientID"), dr("doE"), dr("fullname"),
                             dr("SPH"), dr("CYL"), dr("AXIS"), dr("VA"), dr("ADDITIONAL"),
                             dr("MONO"), dr("SEGHTVERHT"), dr("pd"), dr("remark"), dr("dateofapp"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        dgv.Rows.Clear()
        Try
            ' Ensure the connection is opened
            connect()

            ' Corrected SQL query with proper syntax
            Dim query As String = "SELECT pr.patientID, optomet, dateofapp, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age, p.gender, p.phone, p.email, CONCAT((p.region), ', ', p.province, ' ',  p.municip, ' ',  p.brgy, ' ', p.address) AS address, CONCAT('OD ', UPPER(pr.sphright), ' OS ', UPPER(pr.sphleft)) AS SPH, CONCAT('OD ', UPPER(pr.cylright), ' OS ', UPPER(pr.cylleft)) AS CYL, CONCAT('OD ', pr.axisright, ' OS ', pr.axisleft) AS AXIS, CONCAT('OD ', UPPER(pr.varight), ' OS ', UPPER(pr.valeft)) AS VA, CONCAT('OD ', UPPER(pr.addright), ' OS ', UPPER(pr.addleft)) AS ADDITIONAL, CONCAT('OD ', UPPER(pr.monoright), ' OS ', UPPER(pr.monoleft)) AS MONO, CONCAT('OD ', UPPER(pr.sight), ' OS ', UPPER(pr.verht)) AS SEGHTVERHT, pr.pd, pr.remark FROM tbl_addpatient p JOIN tbl_prescription pr ON p.patientid = pr.patientID JOIN tbl_addappointment a ON a.patientid = pr.patientID WHERE pr.isdeleted = 1 LIKE '%" & txtsearch.Text & "%' " & _
                                  "OR CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) LIKE '%" & txtsearch.Text & "%' " & _
                                  "OR p.dob LIKE '%" & txtsearch.Text & "%' " & _
                                  "OR p.email LIKE '%" & txtsearch.Text & "%' " & _
                                  "OR TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) LIKE '%" & txtsearch.Text & "%' "

            Dim cmd As New Odbc.OdbcCommand(query, con)
            Dim dr As Odbc.OdbcDataReader = cmd.ExecuteReader()

            While dr.Read()
                Dim address As String = dr.Item("address").ToString()
                Dim textInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo

                ' Capitalize each word in the address properly
                Dim capitalizedAddress As String = String.Join(" ", address.Split(" "c).Select(Function(word) textInfo.ToTitleCase(word.ToLower())))

                dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("patientID"), dr.Item("fullname"), dr.Item("SPH"), dr.Item("CYL"), dr.Item("AXIS"), dr.Item("VA"), dr.Item("ADDITIONAL"), dr.Item("MONO"), dr.Item("SEGHTVERHT"), dr.Item("pd"), dr.Item("remark"))
            End While

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ' Ensure the connection is closed
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv.Rows.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT pr.patientID, pr.doE, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, CONCAT('OD ', UPPER(pr.sphright), ' OS ', UPPER(pr.sphleft)) AS SPH, CONCAT('OD ', UPPER(pr.cylright), ' OS ', UPPER(pr.cylleft)) AS CYL, CONCAT('OD ', pr.axisright, ' OS ', pr.axisleft) AS AXIS, CONCAT('OD ', UPPER(pr.varight), ' OS ', UPPER(pr.valeft)) AS VA, CONCAT('OD ', UPPER(pr.addright), ' OS ', UPPER(pr.addleft)) AS ADDITIONAL, CONCAT('OD ', UPPER(pr.monoright), ' OS ', UPPER(pr.monoleft)) AS MONO, CONCAT('OD ', UPPER(pr.sight), ' OS ', UPPER(pr.verht)) AS SEGHTVERHT, pr.pd, pr.remark, a.dateofapp FROM tbl_addpatient p JOIN tbl_prescription pr JOIN tbl_addappointment a ON p.patientid = pr.patientID = a.appointmentid WHERE pr.patientid ORDER BY doE", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("patientID"), dr.Item("doE"), dr.Item("fullname"), dr.Item("SPH"), dr.Item("CYL"), dr.Item("AXIS"), dr.Item("VA"), dr.Item("ADDITIONAL"), dr.Item("MONO"), dr.Item("SEGHTVERHT"), dr.Item("pd"), dr.Item("remark"), dr.Item("dateofapp"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub
End Class