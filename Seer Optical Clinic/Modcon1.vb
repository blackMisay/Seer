Module Modcon1
    Public con As Odbc.OdbcConnection
    Public da As Odbc.OdbcDataAdapter
    Public dr As Odbc.OdbcDataReader
    Public cmd As Odbc.OdbcCommand
    Public ds As New DataSet
    Public dt As New DataTable
    Public i As Integer
    Public names, username, password, role As String
    Public id As String
    Public ids As String

    Public Sub connect()
        Try
            con = New Odbc.OdbcConnection("DSN=seeroptical_db")
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub loadDGV(ByVal sql As String, ByVal dgv As DataGridView)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable
        Try
            Call connect()
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            dgv.DataSource = dt
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub loadcbo(ByVal sql As String, ByVal cbo As ComboBox, ByVal display As String, ByVal value As String)
        Dim da As Odbc.OdbcDataAdapter
        Dim dt As New DataTable

        Try
            da = New Odbc.OdbcDataAdapter(sql, con)
            da.Fill(dt)
            cbo.DataSource = dt
            cbo.DisplayMember = display
            cbo.ValueMember = value
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            GC.Collect()
            con.Close()

        End Try
    End Sub

    Public Sub reaload(ByVal sql As String, ByVal dgv As Object)
        Try
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dgv.datasource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
            da.Dispose()
        End Try
        'Public Sub loadDGV(ByVal sql As String, ByVal dgv As DataGridView)
        '    Dim da As Odbc.OdbcDataAdapter
        '    Dim dt As New DataTable
        '    Try
        '        Call connect()
        '        da = New Odbc.OdbcDataAdapter(sql, con)
        '        da.Fill(dt)
        '        dgv.DataSource = dt
        '        da.Dispose()
        '    Catch ex As Exception
        '        MsgBox(ex.Message.ToString)
        '    End Try
    End Sub
    Public Function DataValidation(ByVal pnl As Panel) As Boolean
        Dim obj As Object
        For Each obj In pnl.Controls
            If TypeOf obj Is TextBox And obj.tag = "" Then
                If Len(obj.text) = 0 Then
                    DataValidation = False
                    MessageBox.Show("Required Missing Field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Function
                End If
            End If
        Next
        DataValidation = True
    End Function
    Public Sub clean(ByVal pnl As Panel)
        For Each obje As Control In pnl.Controls
            If TypeOf obje Is TextBox Then
                obje.Text = String.Empty
            End If
            If TypeOf obje Is ComboBox Then
                obje.Text = String.Empty
            End If
        Next
    End Sub
    Public Sub Log(ByVal ptype As String)
        'Dim id As String
        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        Try
            If ptype = "IN" Then
                connect()
                cmd = New Odbc.OdbcCommand("INSERT INTO tbl_log(role, user, sdate, timein) VALUES(?,?,?,?)", con)
                With cmd.Parameters
                    .AddWithValue("?", role)
                    .AddWithValue("?", names)
                    .AddWithValue("?", sdate)
                    .AddWithValue("?", Now.ToString("hh:mm:ss tt"))
                End With
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                connect()
                cmd = New Odbc.OdbcCommand("SELECT max(id) as id from tbl_log WHERE role=? and user=? and sdate=?", con)
                With cmd.Parameters
                    .AddWithValue("?", role)
                    .AddWithValue("?", names)
                    .AddWithValue("?", sdate)
                End With
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then id = dr.Item("id").ToString
                con.Close()

                connect()
                cmd = New Odbc.OdbcCommand("UPDATE tbl_log SET status = 'Offline', timeout = '" & Now.ToString("hh:mm:ss tt") & "' WHERE id like '" & id & "'", con)
                cmd.ExecuteNonQuery()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Dim da As New Odbc.OdbcDataAdapter(sql, con)
        Dim ds As New DataSet

        da.Fill(ds, "Result")
        Return ds.Tables("Result")
    End Function
End Module
