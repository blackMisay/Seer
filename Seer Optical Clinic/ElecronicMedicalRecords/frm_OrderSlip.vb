Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Public Class frm_OrderSlip

    Private Sub frm_OrderSlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        frm_Payment.LoadPayment()
    End Sub
    '' ''Sub loadStatus()
    '' ''    dgv.Rows.Clear()
    '' ''    Try
    '' ''        connect()
    '' ''        ' Assuming subtotal, deposit, and total are fields in the tbl_payment table
    '' ''        cmd = New Odbc.OdbcCommand("SELECT * FROM `tbl_payment` WHERE duedate BETWEEN ? AND ? ORDER BY CASE WHEN status='PAID' THEN 0 ELSE 1 END", con)
    '' ''        'cmd.Parameters.AddWithValue("?", DateTimePicker3.Value.ToString("yyyy-MM-dd"))
    '' ''        'cmd.Parameters.AddWithValue("?", DateTimePicker4.Value.ToString("yyyy-MM-dd"))
    '' ''        dr = cmd.ExecuteReader
    '' ''        While dr.Read
    '' ''            dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("payID"), dr.Item("refno"), dr.Item("duedate"), dr.Item("fullname"), dr.Item("optometrist"), dr.Item("frame"), dr.Item("lens"), dr.Item("addprice"), dr.Item("deposit"), dr.Item("balance"), dr.Item("total"), dr.Item("status"))
    '' ''        End While
    '' ''        'lblLog.Text = "Record count (" & dgv.RowCount & ")"
    '' ''    Catch ex As Exception
    '' ''        MsgBox("Error occurred while loading status: " & ex.Message)
    '' ''    Finally
    '' ''        If Not dr Is Nothing Then
    '' ''            dr.Close()
    '' ''        End If
    '' ''        con.Close()
    '' ''    End Try
    '' ''End Sub

    '' ''Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
    '' ''    If e.ColumnIndex = 7 AndAlso e.RowIndex >= 0 Then
    '' ''        Dim cellValue As String = dgv.Rows(e.RowIndex).Cells(7).Value.ToString()
    '' ''        If cellValue = "Online" Then
    '' ''            ' Set the font color to green for the "Online" status
    '' ''            e.CellStyle.ForeColor = Color.Green
    '' ''        Else
    '' ''            ' Set the font color to your desired default color for other statuses
    '' ''            e.CellStyle.ForeColor = dgv.DefaultCellStyle.ForeColor
    '' ''        End If
    '' ''    End If
    '' ''End Sub
    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        ' Dim sql As String
        Dim cmd As Odbc.OdbcCommand
        Dim colName As String = dgv.Columns(e.ColumnIndex).Name
        'frm_AddNewPrescript.lbladdpres.Visible = False
        'frm_AddNewPrescript.lbleditpres.Visible = True
        If colName = "colEdit" Then
            Try
                With frm_Payment
                    connect()
                    cmd = New Odbc.OdbcCommand("SELECT payID, duedate, fullname, optometrist, frame, lens, addprice, subtotal, deposit, total, status FROM tbl_payment WHERE payID like '" & dgv.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    'cmd.Parameters.AddWithValue("@presID", dgrid.Rows(e.RowIndex).Cells("presID").Value.ToString())
                    dr = cmd.ExecuteReader
                    While dr.Read
                        .txtpayID.Text = dr.GetInt32(0)
                        .DateTimePicker5.Value = dr.GetString(1)
                        .txtfullname.Text = dr.GetString(2)
                        .txtOptomet.Text = dr.GetString(3)
                        .txtFrameprice.Text = dr.GetDecimal(4).ToString
                        .txtLensprice.Text = dr.GetDecimal(5).ToString
                        .txtAddprice.Text = dr.GetDecimal(6).ToString
                        '.txtSubtotal.Text = dr.GetDecimal(7).ToString
                        .txtDeposit.Text = dr.GetDecimal(8).ToString
                        .txtTotal.Text = dr.GetDecimal(9).ToString
                        .lblstatus.Text = dr.GetString(10).ToString
                    End While
                    .DateTimePicker5.CustomFormat = "hh:mm tt"
                    '.btnsave.Visible = False
                    '.txtage.ReadOnly = True
                    '.btnsearch.Visible = False
                    '.txtsearch.Visible = False
                    '.btnsearch.Visible = False
                    .txtfullname.BackColor = Color.FromArgb(232, 244, 248)
                    .txtOptomet.BackColor = Color.FromArgb(232, 244, 248)
                    '.txtage.BackColor = Color.FromArgb(232, 244, 248)
                    '.cmbsex.BackColor = Color.FromArgb(232, 244, 248)
                    '.DateTimePicker2.BackColor = Color.FromArgb(232, 244, 248)

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
    End Sub
End Class
