Imports System.Data.Odbc.OdbcConnection
Imports System.IO

Public Class frm_Payment

    Private Sub frm_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        'SendMessage(txtSubtotal.Handle, kur, 0, "( Sub-Total is automatically computed )")
    End Sub
    Sub LoadPayment()
        frm_TransactionModule.dgv.Rows.Clear()
        Try
            connect()
            cmd = New Odbc.OdbcCommand("SELECT payID, transno, duedate, fullname, optometrist, frameprice, lensprice, addprice, subtotal, deposit, gcash, refno, total, status FROM tbl_payment; ", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'frm_patient.dgv.Rows.Add(frm_patient.dgv.Rows.Count + 1, dr.Item("id"), dr.Item("fullname"), dr.Item("dob"), dr.Item("age"), dr.Item("gender"), dr.Item("phone"), dr.Item("emergency"), dr.Item("email"), dr.Item("address

                frm_TransactionModule.dgv.Rows.Add(frm_TransactionModule.dgv.Rows.Count + 1, dr.Item("payID"), dr.Item("transno"), dr.Item("duedate"), dr.Item("fullname"), dr.Item("optometrist"), dr.Item("frameprice"), dr.Item("lensprice"), dr.Item("addprice"), dr.Item("subtotal"), dr.Item("deposit"), dr.Item("gcash"), dr.Item("refno"), dr.Item("total"), dr.Item("status"))
            End While
            'frm_patient.lblReportCount.Text = "Record count (" & frm_patient.dgv.RowCount & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    'Sub LensAndFrames()
    '    Try
    '        connect()
    '        cmd = New Odbc.OdbcCommand("SELECT ID, lensType, lensSide, lensFor, features, occuLens, digiLens, driveLens, singLens, lensPrice, brand, frameType, model, fColor, addPrice, subTotal WHERE isdeleted = 1", con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("ID"), dr.Item("lensType"), dr.Item("lensSide"), dr.Item("lensFor"), dr.Item("features"), dr.Item("occuLens"), dr.Item("digiLens"), dr.Item("driveLens"), dr.Item("singLens"), dr.Item("lensPrice"), dr.Item("brand"), dr.Item("frametype"), dr.Item("model"), dr.Item("fColor"), dr.Item("addPrice"), dr.Item("subTotal"), dr.Item("isdeleted"))
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    End Try
    'End Sub
    Private Sub getTotal()
        Try
            Dim framePrice As Double = Val(txtFrameprice.Text)
            Dim lensPrice As Double = Val(txtLensprice.Text)
            Dim addPrice As Double = Val(txtAddprice.Text)
            Dim deposit As Double = Val(txtDeposit.Text)
            Dim gcash As Double = Val(txt_Gcash.Text)

            Dim subtotal As Double = framePrice + lensPrice + addPrice
            Dim change As Double = subtotal - deposit - gcash

            If change < 0 Then
                txtTotal.Text = "₱0.00"
            Else
                'txtSubtotal.Text = Format(subtotal, "₱#,##0.00")
                txtTotal.Text = Format(change, "₱#,##0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            'txtSubtotal.Text = "₱0.00"
            txtTotal.Text = "₱0.00"
            txtFrameprice.Text = ""
            txtLensprice.Text = ""
            txtAddprice.Text = ""
            txtDeposit.Text = ""
            txt_Gcash.Text = ""
        End Try
    End Sub
    'Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
    '    Dim fields() As Control = {txtFrameprice, txtLensprice}
    '    Dim labels() As String = {"Frame Price", "Lens Price"}

    '    For i As Integer = 0 To fields.Length - 1
    '        If fields(i).Text = String.Empty Then
    '            MsgBox("Please input " & labels(i), vbExclamation, "Required missing field")
    '            fields(i).Select()
    '            Return
    '        End If
    '    Next

    '    Try
    '        connect()

    '        ' Format the textboxes and assign the formatted values back
    '        txtSubtotal.Text = Format(CDbl(txtSubtotal.Text), "₱#,##0.00")
    '        txtTotal.Text = Format(CDbl(txtTotal.Text), "₱#,##0.00")

    '        If btnsave.Tag = 0 Then
    '            ' Construct the SQL query for tbl_payment
    '            Dim paymentQuery As String = "INSERT INTO tbl_payment (duedate, fullname, optometrist, frameprice, lensprice, addprice, subtotal, deposit, gcash, refno, total, status) VALUES(?,?,?,?,?,?,?,?,?,?,?,?)"
    '            Dim cmdPayment As New Odbc.OdbcCommand(paymentQuery, con)

    '            With cmdPayment
    '                .Parameters.AddWithValue("?", DateTimePicker5.Value.ToString("yyyy-MM-dd"))
    '                .Parameters.AddWithValue("?", txtfullname.Text)
    '                .Parameters.AddWithValue("?", txtOptomet.Text)
    '                .Parameters.AddWithValue("?", Val(txtFrameprice.Text))
    '                .Parameters.AddWithValue("?", Val(txtLensprice.Text))
    '                .Parameters.AddWithValue("?", Val(txtAddprice.Text))
    '                .Parameters.AddWithValue("?", CDbl(txtSubtotal.Text))
    '                .Parameters.AddWithValue("?", Val(txtDeposit.Text))
    '                .Parameters.AddWithValue("?", Val(txt_Gcash.Text))
    '                .Parameters.AddWithValue("?", txtRefNo.Text)
    '                .Parameters.AddWithValue("?", CDbl(txtTotal.Text))
    '                .Parameters.AddWithValue("?", cmbstat.Text)
    '            End With

    '            cmdPayment.ExecuteNonQuery()

    '            ' Construct the SQL query for tbl_lensandframe
    '            Dim lensAndFrameQuery As String = "INSERT INTO tbl_lensandframe (lensType, lensSide, lensFor, features, occuLens, digiLens, driveLens, singLens, lensPrice, brand, frameType, model, fColor, framePrice, addReq, addPrice, subTotal, isdeleted) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
    '            Dim cmdLensAndFrame As New Odbc.OdbcCommand(lensAndFrameQuery, con)

    '            With cmdLensAndFrame.Parameters
    '                .AddWithValue("?", cmbtype.Text)
    '                .AddWithValue("?", cmbside.Text)
    '                .AddWithValue("?", cmbfor.Text)
    '                .AddWithValue("?", cmbFeatures.Text)
    '                .AddWithValue("?", cmbOccu.Text)
    '                .AddWithValue("?", cmbDIgi.Text)
    '                .AddWithValue("?", cmbDrive.Text)
    '                .AddWithValue("?", cmbSing.Text)
    '                .AddWithValue("?", Val(txtLensprice.Text))
    '                .AddWithValue("?", cmbbrand.Text)
    '                .AddWithValue("?", cmbtypef.Text)
    '                .AddWithValue("?", cmbModel.Text)
    '                .AddWithValue("?", cmbfColor.Text)
    '                .AddWithValue("?", Val(txtFrameprice.Text))
    '                .AddWithValue("?", txtaddreq.Text)
    '                .AddWithValue("?", Val(txtAddprice.Text))
    '                .AddWithValue("?", CDbl(txtTotal.Text))
    '                .AddWithValue("?", CBool(checkboxdeleted.Checked))
    '            End With

    '            cmdLensAndFrame.ExecuteNonQuery()

    '            MsgBox("Payment Added Successfully", vbInformation, "Success")
    '            Me.Dispose()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        con.Close()
    '        LoadPayment()
    '    End Try
    'End Sub

    'Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
    '    Try
    '        connect()
    '        cmd = New Odbc.OdbcCommand("UPDATE tbl_payment SET duedate=?, fullname=?, optometrist=?, frameprice=?, lensprice=?, addprice=?, subtotal=?, deposit=?, gcash=?, refno=?, total=?, status=? WHERE payID=?", con)
    '        With cmd.Parameters
    '            .AddWithValue("?", DateTimePicker5.Value)
    '            .AddWithValue("?", txtfullname.Text)
    '            .AddWithValue("?", txtOptomet.Text)
    '            .AddWithValue("?", txtFrameprice.Text)
    '            .AddWithValue("?", txtLensprice.Text)
    '            .AddWithValue("?", txtAddprice.Text)
    '            .AddWithValue("?", txtSubtotal.Text)
    '            .AddWithValue("?", txtDeposit.Text)
    '            .AddWithValue("?", txt_Gcash.Text)
    '            .AddWithValue("?", txtRefNo.Text)
    '            .AddWithValue("?", txtTotal.Text)
    '            .AddWithValue("?", cmbstat.Text)

    '            .AddWithValue("?", txtpayID.Text)
    '        End With
    '        i = cmd.ExecuteNonQuery()
    '        If i > 0 Then
    '            MsgBox("Payment successfully", vbInformation, "Update")
    '            LoadPayment()
    '            Me.Dispose()
    '        Else
    '            MsgBox("Payment update failed", vbExclamation, "Failed")
    '        End If
    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    End Try
    'End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtFrameprice_TextChanged(sender As Object, e As EventArgs) Handles txtFrameprice.TextChanged
        getTotal()

    End Sub

    Private Sub txtLensprice_TextChanged(sender As Object, e As EventArgs) Handles txtLensprice.TextChanged
        getTotal()
    End Sub

    Private Sub txtAddprice_TextChanged(sender As Object, e As EventArgs) Handles txtAddprice.TextChanged
        getTotal()

    End Sub

    Private Sub txtDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged
        getTotal()

    End Sub
    Private Sub txtFrameprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFrameprice.KeyDown
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
    Private Sub txtLensprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLensprice.KeyDown
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

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_Gcash_TextChanged(sender As Object, e As EventArgs) Handles txt_Gcash.TextChanged
        getTotal()
    End Sub
End Class