Public Class frm_reports

    Private Sub frm_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connect()
        'dgv.RowTemplate.Height = 40
        'frm_Payment.LoadPayment()
    End Sub

    'Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
    '    'Dim sql As String
    '    Dim cmd As Odbc.OdbcCommand
    '    Dim colName As String = dgv.Columns(e.ColumnIndex).Name
    '    'frm_AddNewPrescript.lbladdpres.Visible = False
    '    'frm_AddNewPrescript.lbleditpres.Visible = True
    '    If colName = "colEdit" Then
    '        Try
    '            With frm_Payment
    '                connect()
    '                cmd = New Odbc.OdbcCommand("SELECT payID, duedate, fullname, optometrist, frameprice, lensprice, addprice, subtotal, deposit, total, status FROM tbl_payment WHERE payID like '" & dgv.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
    '                'cmd.Parameters.AddWithValue("@presID", dgrid.Rows(e.RowIndex).Cells("presID").Value.ToString())
    '                dr = cmd.ExecuteReader
    '                While dr.Read
    '                    .txtpayID.Text = dr.GetInt32(0)
    '                    .DateTimePicker5.Value = dr.GetString(1)
    '                    .txtfullname.Text = dr.GetString(2)
    '                    .txtOptomet.Text = dr.GetString(3)
    '                    .txtFrameprice.Text = dr.GetDecimal(4).ToString
    '                    .txtLensprice.Text = dr.GetDecimal(5).ToString
    '                    .txtAddprice.Text = dr.GetDecimal(6).ToString
    '                    .txtSubtotal.Text = dr.GetDecimal(7).ToString
    '                    .txtDeposit.Text = dr.GetDecimal(8).ToString
    '                    .txtTotal.Text = dr.GetDecimal(9).ToString
    '                    .cmbstat.Text = dr.GetString(10).ToString
    '                End While
    '                .Label7.Visible = False
    '                .DateTimePicker5.CustomFormat = "hh:mm tt"
    '                .btnsave.Visible = False
    '                .txtfullname.BackColor = Color.FromArgb(232, 244, 248)
    '                .txtOptomet.BackColor = Color.FromArgb(232, 244, 248)

    '                'Peachy
    '                '.txtlname.BackColor = Color.FromArgb(254, 250, 224)
    '                '.txtfname.BackColor = Color.FromArgb(254, 250, 224)
    '                '.txtmname.BackColor = Color.FromArgb(254, 250, 224)
    '                '.txtsuffix.BackColor = Color.FromArgb(254, 250, 224)
    '                '.txtmobile.BackColor = Color.FromArgb(254, 250, 224)
    '                '.txtemail.BackColor = Color.FromArgb(254, 250, 224)
    '                '.txtemergency.BackColor = Color.FromArgb(254, 250, 224)
    '                '.txtaddress.BackColor = Color.FromArgb(254, 250, 224)
    '                dr.Close()
    '                con.Close()
    '                .ShowDialog()
    '            End With
    '        Catch ex As Exception
    '            MsgBox(ex.Message.ToString)
    '        Finally
    '            con.Close()
    '        End Try
    '    End If
    'End Sub
End Class