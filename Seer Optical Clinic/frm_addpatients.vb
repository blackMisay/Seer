Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization
Public Class frm_addpatients
    Private Const kur As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
                                        <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub frm_addpatients_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frm_addpatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        SendMessage(txtage.Handle, kur, 0, "( Age is automatically computed )")
        SendMessage(txtsearch.Handle, kur, 0, " Search")
        SendMessage(txtlname.Handle, kur, 0, " *")
        SendMessage(txtfname.Handle, kur, 0, " *")
        SendMessage(txtmobile.Handle, kur, 0, " *")
        SendMessage(txtoccupation.Handle, kur, 0, " *")
        SendMessage(txtemergency.Handle, kur, 0, " *")
        SendMessage(txtemail.Handle, kur, 0, " Optional")
        LoadPatients()
        checkboxdeleted.Checked = True
        txtage.ReadOnly = True
        'Call loadcbo("SELECT provCode, citymunDesc FROM refcitymun", cmbmunicip, "citymunDesc", "provCode")
        'Call loadcbo("SELECT provCode, brgyCode FROM refbrgy", cmbbrgy, "brgyDesc", "provCode")
    End Sub

    'Sub auto_refno()
    '    Try
    '        connect()
    '        cmd = New Odbc.OdbcCommand("SELECT * FROM `tbl_addpatient` order by refno desc", con)
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        If dr.HasRows = True Then
    '            txtref.Text = dr.Item("refno").ToString + 1
    '        Else
    '            txtref.Text = Date.Now.ToString("yyyyMM") & "001"
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    con.Close()
    'End Sub
   Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' Validate required fields
        If txtlname.Text = String.Empty Then
            MsgBox("Please input your Last Name", vbExclamation, "Required missing field")
            txtlname.Select()
            Return
        End If
        If txtfname.Text = String.Empty Then
            MsgBox("Please input your First Name", vbExclamation, "Required missing field")
            txtfname.Select()
            Return
        End If
        If txtmobile.Text = String.Empty Then
            MsgBox("Please input your Mobile Number", vbExclamation, "Required missing field")
            txtmobile.Select()
            Return
        End If
        If txtemergency.Text = String.Empty Then
            MsgBox("Please input your Emergency Contact", vbExclamation, "Required missing field")
            txtemergency.Select()
            Return
        End If
        If txtaddress.Text = String.Empty Then
            MsgBox("Please input your Address", vbExclamation, "Required missing field")
            txtaddress.Select()
            Return
        End If

        Try
            connect()

            ' Check if a patient already exists with the same Last Name, First Name, and DOB or Mobile number
            Dim checkCmd As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tbl_addpatient WHERE lname = ? AND fname = ? AND dob = ? OR phone = ?", con)
            With checkCmd.Parameters
                .AddWithValue("?", txtlname.Text)
                .AddWithValue("?", txtfname.Text)
                .AddWithValue("?", DateTimePicker1.Value)
                .AddWithValue("?", txtmobile.Text)
            End With

            Dim existingPatientCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If existingPatientCount > 0 Then
                MsgBox("A patient with the same Last Name, First Name, DOB, or Mobile Number already exists.", vbExclamation, "Duplicate Entry")
                Return
            End If

            ' Insert new patient data
            If btnsave.Tag = 0 Then
                cmd = New Odbc.OdbcCommand("INSERT INTO tbl_addpatient (lname, fname, mname, suffix, dob, gender, occupation, phone, guardian, emergency, email, region, province, municip, brgy, address, isdeleted, isactive, isnot) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", con)
                With cmd.Parameters
                    .AddWithValue("?", txtlname.Text)
                    .AddWithValue("?", txtfname.Text)
                    .AddWithValue("?", txtmname.Text)
                    .AddWithValue("?", cmbsuffix.Text)
                    .AddWithValue("?", DateTimePicker1.Value)
                    .AddWithValue("?", cmbgender.Text)
                    .AddWithValue("?", txtoccupation.Text)
                    .AddWithValue("?", txtmobile.Text)
                    .AddWithValue("?", txtguardian.Text)
                    .AddWithValue("?", txtemergency.Text)
                    .AddWithValue("?", txtemail.Text)
                    .AddWithValue("?", cmbregion.Text)
                    .AddWithValue("?", cmbprovince.Text)
                    .AddWithValue("?", cmbmunicip.Text)
                    .AddWithValue("?", cmbbrgy.Text)
                    .AddWithValue("?", txtaddress.Text)
                    .AddWithValue("?", CBool(checkboxdeleted.Checked.ToString))
                    .AddWithValue("?", CBool(checkboxactive.Checked.ToString))
                    .AddWithValue("?", CBool(checkboxisnot.Checked.ToString))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Patient added successfully", vbInformation, "Success")
                Me.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
            LoadPatients()
            GC.Collect()
        End Try
    End Sub

    Function HasParentheses(word As String) As Boolean
        Return word.Contains("(") AndAlso word.Contains(")")
    End Function
    Sub LoadPatients()
        frm_patient.dgv.Rows.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT patientid, CONCAT(UPPER(lname), ', ', fname, ' ', mname, ' ', suffix) AS fullname, dob, TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age, gender, occupation, phone, guardian, emergency, email, CONCAT((region), ', ', province, ' ',  municip, ' ',  brgy, ' ', address) AS address FROM tbl_addpatient WHERE isdeleted=1 ORDER BY fullname", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'frm_patient.dgv.Rows.Add(frm_patient.dgv.Rows.Count + 1, dr.Item("id"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("gender"), dr.Item("phone"), dr.Item("emergency"), dr.Item("email"), dr.Item("address"))
                Dim address As String = dr.Item("address").ToString()

                Dim textInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo
                Dim capitalizedAddress As String = String.Join(" ", address.Split(" ").
                 Select(Function(word) If(HasParentheses(word), word.ToUpper(), textInfo.ToTitleCase(word.ToLower()))))

                frm_patient.dgv.Rows.Add(frm_patient.dgv.Rows.Count + 1, dr.Item("patientid"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("gender"), dr.Item("occupation"), dr.Item("phone"), dr.Item("guardian"), dr.Item("emergency"), dr.Item("email"), capitalizedAddress)
            End While
            'frm_patient.lblReportCount.Text = "Record count (" & frm_patient.dgv.RowCount & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            connect()
            cmd = New Odbc.OdbcCommand("UPDATE tbl_addpatient SET  lname=?, fname=?, mname=?, suffix=?, dob=?, gender=?,  occupation=?, phone=?, guardian=?, emergency=?, email=?, region=?, province=?, municip=?, brgy=?, address=? WHERE patientid=?", con)
            With cmd.Parameters
                .AddWithValue("?", txtlname.Text)
                .AddWithValue("?", txtfname.Text)
                .AddWithValue("?", txtmname.Text)
                .AddWithValue("?", cmbsuffix.Text)
                .AddWithValue("?", DateTimePicker1.Value)
                .AddWithValue("?", cmbgender.Text)
                .AddWithValue("?", txtoccupation.Text)
                .AddWithValue("?", txtmobile.Text)
                .AddWithValue("?", txtguardian.Text)
                .AddWithValue("?", txtemergency.Text)
                .AddWithValue("?", txtemail.Text)
                .AddWithValue("?", cmbregion.Text)
                .AddWithValue("?", cmbprovince.Text)
                .AddWithValue("?", cmbmunicip.Text)
                .AddWithValue("?", cmbbrgy.Text)
                .AddWithValue("?", txtaddress.Text)
                .AddWithValue("?", txtpatientid.Text)
            End With
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Patient updated successfully", vbInformation, "Update")
                Me.Dispose()
            Else
                MsgBox("Patient update failed", vbExclamation, "Failed")
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
        LoadPatients()
    End Sub
    Private Sub cmbregion_Click(sender As Object, e As EventArgs) Handles cmbregion.Click
        Call loadcbo("SELECT regCode, regDesc FROM refregion ORDER BY regDesc", cmbregion, "regDesc", "regCode") 'Ito yung nag didisplay ng data sa combobox sa region
    End Sub
    Private Sub cmbregion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbregion.SelectionChangeCommitted
        Call loadcbo("SELECT provCode, provDesc FROM refprovince WHERE regCode = " + cmbregion.SelectedValue.ToString() + " ORDER BY provDesc", cmbprovince, "provDesc", "provCode")
    End Sub
    Private Sub cmbprovince_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbprovince.SelectionChangeCommitted
        loadcbo("SELECT provCode, citymunDesc FROM refcitymun WHERE provCode = '" & cmbprovince.SelectedValue.ToString() & "' ORDER BY citymunDesc", cmbmunicip, "citymunDesc", "provCode")
    End Sub
    Private Sub cmbmunicip_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbmunicip.SelectionChangeCommitted
        ' Assuming you want to filter by citymunCode, change "provCode" to "citymunCode"
        loadcbo("SELECT provCode, brgyDesc FROM refbrgy WHERE provCode = '" & cmbmunicip.SelectedValue.ToString() & "' ORDER BY brgyDesc", cmbbrgy, "brgyDesc", "provCode")
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()

    End Sub
    Private Sub txtlname_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtlname.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub
    Private Sub txtfname_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtfname_TextChanged(sender As Object, e As EventArgs)
        With txtfname
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub
    Private Sub txtmname_TextChanged(sender As Object, e As EventArgs)
        With txtmname
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub
    Private Sub txtlname_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtmname_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtmobile_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtoccupation_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtemail_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtguardian_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtemergency_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtemergency_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemergency.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        ElseIf txtemergency.Text.Length >= 11 AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmobile.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        ElseIf txtmobile.Text.Length >= 11 AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frm_addpatients_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub
    Private Sub txtaddress_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub
    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dob As Date = DateTimePicker1.Value
        Dim age As Integer = Date.Now.Year - dob.Year
        If Date.Now < dob.AddYears(age) Then
            age -= 1
        End If

        If age < 0 Then
            age = 0
        End If
        txtage.Text = age.ToString()
        txtage.ReadOnly = True
    End Sub
    Private Sub txtsuffix_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtsuffix_TextChanged(sender As Object, e As EventArgs)
        With cmbsuffix
            Dim ss As Integer = .SelectionStart
            Dim sl As Integer = .SelectionLength
            .Text = StrConv(.Text, VbStrConv.ProperCase)
            .SelectionStart = ss
            .SelectionLength = sl
        End With
    End Sub

    Private Sub cmbregion_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbprovince_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbmunicip_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub cmbbrgy_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtage_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub cmbprovince_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub cmbmunicip_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub cmbbrgy_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub cmbregion_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub checkboxisnot_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxisnot.CheckedChanged

    End Sub

End Class