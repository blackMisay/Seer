Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Public Class frm_TransactionModule
    Dim _clickCategory As String = ""

    Private Sub frm_TransactionModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        dgv.RowTemplate.Height = 40
        auto_Transno()
        'loadDesc()
        loadCategory()
        'orderslip()
        'auto_Transno()
        'loadCategory()
    End Sub
    'Sub loadType()
    '    Try
    '        Call connect()
    '        Dim dt As New DataTable
    '        Dim da As New Odbc.OdbcDataAdapter("SELECT categID, categname FROM categories", con)
    '        da.Fill(dt)

    '        ' Bind ComboBox
    '        combocateg.DataSource = dt
    '        combocateg.DisplayMember = "categname"
    '        combocateg.ValueMember = "categID"
    '        combocateg.SelectedIndex = -1
    '    Catch ex As Exception4
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub
    Sub auto_Transno()
        Try
            Call connect()
            cmd = New Odbc.OdbcCommand("SELECT * FROM `tbl_order` order by id desc", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                lblTransNo.Text = dr.Item("transno").ToString + 1
            Else
                lblTransNo.Text = Date.Now.ToString("yyyyMMdd") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    'Private Sub combobrand_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    ' Check if a brand is selected, then update the price
    '    If combobrand.SelectedIndex >= 0 Then
    '        UpdatePriceForSelectedBrand()
    '    End If
    'End Sub


    'Sub loadDesc()
    '    Try
    '        ' Ensure a type is selected in comboCateg
    '        If combocateg.SelectedValue IsNot Nothing AndAlso Integer.TryParse(combocateg.SelectedValue.ToString(), Nothing) Then
    '            Call connect()

    '            ' Define SQL query
    '            Dim sql = "SELECT i.prodCode, cat.categname AS ProductType, b.brandname, d.descrip, c.prodColor, i.quantity, i.price, i.prodStatus, i.isDeleted FROM inventory i LEFT JOIN categories cat ON i.categID = cat.categID LEFT JOIN prodbrand b ON i.brandID = b.brandID LEFT JOIN proddesc d ON i.descID = d.descID LEFT JOIN prodcolors c ON i.colorID = c.colorID WHERE i.categID = ?"
    '            Using cmd As New Odbc.OdbcCommand(sql, con)
    '                cmd.Parameters.AddWithValue("?", combocateg.SelectedValue)

    '                Dim dr = cmd.ExecuteReader()
    '                CheckedListBox1.Items.Clear()
    '                combobrand.Items.Clear()
    '                combocolor.Items.Clear()
    '                txtprice.Text = ""

    '                While dr.Read()
    '                    CheckedListBox1.Items.Add(dr("descrip").ToString())
    '                    combobrand.Items.Add(dr("brandname").ToString())
    '                    combocolor.Items.Add(dr("prodColor").ToString())
    '                End While
    '                dr.Close()
    '            End Using
    '        Else
    '            ' Clear if no type is selected
    '            CheckedListBox1.Items.Clear()
    '            combobrand.Items.Clear()
    '            combocolor.Items.Clear()
    '            txtprice.Text = ""
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub

    'Private Sub UpdatePriceForSelectedBrand()
    '    Try
    '        connect()
    '        If combobrand.SelectedIndex >= 0 Then
    '            ' Get the selected brand name
    '            Dim selectedBrand = combobrand.SelectedItem.ToString()

    '            ' SQL query to fetch the price for the selected brand
    '            Dim sql = "SELECT i.price FROM inventory i LEFT JOIN prodbrand b ON i.brandID = b.brandID WHERE b.brandname = ?"
    '            Using cmd As New Odbc.OdbcCommand(sql, con)
    '                cmd.Parameters.AddWithValue("?", selectedBrand)

    '                Dim dr = cmd.ExecuteReader()
    '                If dr.Read() Then
    '                    ' Set the price in the txtprice textbox
    '                    txtprice.Text = dr("price").ToString()
    '                End If
    '                dr.Close()
    '            End Using
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub



    'Public Class ListItem
    '    Public Property Text As String
    '    Public Property Value As Integer

    '    Public Sub New(ByVal text As String, ByVal value As String)
    '        Me.Text = text
    '        Me.Value = value
    '    End Sub

    '    Public Overrides Function ToString() As String
    '        Return Text
    '    End Function
    'End Class


    Sub loadCategory()
        Try
            Dim count As Integer = 0
            flcateg.AutoScroll = False
            flcateg.Controls.Clear()
            connect()

            ' Add an "ALL" button
            Dim btnAll As New Button()
            btnAll.Width = 87
            btnAll.Height = 48
            btnAll.Text = "ALL"
            btnAll.FlatStyle = FlatStyle.Flat
            btnAll.BackColor = Color.FromArgb(40, 40, 40)
            btnAll.ForeColor = Color.White
            btnAll.Cursor = Cursors.Hand
            btnAll.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            btnAll.TextAlign = ContentAlignment.MiddleCenter
            btnAll.Tag = -1 ' Tag as -1 for "ALL"
            flcateg.Controls.Add(btnAll)
            AddHandler btnAll.Click, AddressOf CategoryButton_Click

            ' Add other categories from database
            Dim cmd As New Odbc.OdbcCommand("SELECT * FROM categories ORDER BY categname", con)
            Dim dr As Odbc.OdbcDataReader = cmd.ExecuteReader()

            While dr.Read()
                ' Create a button for each category
                Dim btnCategory As New Button()
                btnCategory.Width = 87
                btnCategory.Height = 48
                btnCategory.Text = UCase(dr.Item("categname").ToString())
                btnCategory.FlatStyle = FlatStyle.Flat
                btnCategory.BackColor = Color.FromArgb(40, 40, 40)
                btnCategory.ForeColor = Color.White
                btnCategory.Cursor = Cursors.Hand
                btnCategory.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                btnCategory.TextAlign = ContentAlignment.MiddleCenter
                btnCategory.Tag = dr.Item("categID")
                flcateg.Controls.Add(btnCategory)
                AddHandler btnCategory.Click, AddressOf CategoryButton_Click
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

   Private selectedID As Integer = -1 ' Default to -1 (ALL category)

    Private Sub CategoryButton_Click(sender As Object, e As EventArgs)
        ' Clear combo boxes and list boxes
        combotype.Items.Clear()
        combobrand.Items.Clear()
        combocolor.Items.Clear()
        combotype2.Items.Clear()
        combobrand2.Items.Clear()
        combocolor2.Items.Clear()
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()

        ' Default selected category ID to -1 (ALL)
        selectedID = -1
        Dim showFrames As Boolean = False
        Dim showLenses As Boolean = False

        If sender IsNot Nothing AndAlso TypeOf sender Is Button Then
            Dim clickedButton As Button = DirectCast(sender, Button)
            selectedID = Convert.ToInt32(clickedButton.Tag) ' Get category ID from the clicked button

            ' Determine if the clicked button is for Frame, Lens, or All
            Select Case clickedButton.Text.ToUpper()
                Case "ALL"
                    showFrames = True
                    showLenses = True
                Case "FRAME"
                    showFrames = True
                Case "LENS"
                    showLenses = True
            End Select
        End If

        connect() ' Ensure the database connection is established.

        Try
            Dim frameQuery As String = ""
            Dim lensQuery As String = ""

            ' Prepare query for frames
            If showFrames Then
                frameQuery = "SELECT DISTINCT f.ftype AS ItemType, f.fbrand AS Brand, f.fcolor AS Color, f.fdesc AS Description " &
                             "FROM framestock f WHERE f.categID = 1"
            End If

            ' Prepare query for lenses
            If showLenses Then
                lensQuery = "SELECT DISTINCT l.ltype AS ItemType, l.lbrand AS Brand, l.lcolor AS Color, l.ldesc AS Description " &
                            "FROM lensstock l WHERE l.categID = 2"
            End If

            ' Populate both frame and lens data
            If showFrames Then
                PopulateControlsWithDupCheck(frameQuery, combotype, combobrand, combocolor, CheckedListBox1)
            End If
            If showLenses Then
                PopulateControlsWithDupCheck(lensQuery, combotype2, combobrand2, combocolor2, CheckedListBox2)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            con.Close() ' Always close the connection.
        End Try
    End Sub

    ' Helper function to populate controls and avoid duplicates
    Private Sub PopulateControlsWithDupCheck(query As String, comboType As ComboBox, comboBrand As ComboBox, comboColor As ComboBox, checkedListBox As CheckedListBox)
        Try
            Dim adapter As New Odbc.OdbcDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows
                ' Check and add ItemType
                If table.Columns.Contains("ItemType") AndAlso Not comboType.Items.Contains(row("ItemType").ToString()) Then
                    comboType.Items.Add(row("ItemType").ToString())
                End If
                ' Check and add Brand
                If table.Columns.Contains("Brand") AndAlso Not comboBrand.Items.Contains(row("Brand").ToString()) Then
                    comboBrand.Items.Add(row("Brand").ToString())
                End If
                ' Check and add Color
                If table.Columns.Contains("Color") AndAlso Not comboColor.Items.Contains(row("Color").ToString()) Then
                    comboColor.Items.Add(row("Color").ToString())
                End If
                ' Check and add Description
                If table.Columns.Contains("Description") AndAlso Not checkedListBox.Items.Contains(row("Description").ToString()) Then
                    checkedListBox.Items.Add(row("Description").ToString())
                End If
            Next
        Catch ex As Exception
            MsgBox("Error populating controls: " & ex.Message, vbCritical)
        End Try
    End Sub


    ' Helper function to populate controls
    Private Sub PopulateControls(query As String, comboType As ComboBox, comboBrand As ComboBox, comboColor As ComboBox, checkedListBox As CheckedListBox)
        Try
            Dim adapter As New Odbc.OdbcDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows
                If table.Columns.Contains("ItemType") Then comboType.Items.Add(row("ItemType").ToString())
                If table.Columns.Contains("Brand") Then comboBrand.Items.Add(row("Brand").ToString())
                If table.Columns.Contains("Color") Then comboColor.Items.Add(row("Color").ToString())
                If table.Columns.Contains("Description") Then checkedListBox.Items.Add(row("Description").ToString())
            Next
        Catch ex As Exception
            MsgBox("Error populating controls: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            connect() ' Ensure the connection is established

            If btnadd.Tag = 0 Then ' Check if the button tag indicates new entry
                Dim insertQuery As String = "INSERT INTO tbl_order (transno, category, prodtype, brand, orderdesc, color, price) " &
                                             "VALUES (?, ?, ?, ?, ?, ?, ?)"
                Dim cmd As New Odbc.OdbcCommand(insertQuery, con)

                ' Add parameters based on the selected data
                With cmd.Parameters
                    .AddWithValue("transno", lblTransNo.Text)
                    If combotype.SelectedItem IsNot Nothing Then
                        .AddWithValue("category", "Frame")
                        .AddWithValue("prodtype", combotype.SelectedItem)
                        .AddWithValue("brand", combobrand.SelectedItem)
                        .AddWithValue("orderdesc", CheckedListBox1.SelectedItem)
                        .AddWithValue("color", combocolor.SelectedItem)
                    Else
                        .AddWithValue("category", "Lens")
                        .AddWithValue("prodtype", combotype2.SelectedItem)
                        .AddWithValue("brand", combobrand2.SelectedItem)
                        .AddWithValue("orderdesc", CheckedListBox2.SelectedItem)
                        .AddWithValue("color", combocolor2.SelectedItem)
                    End If
                    .AddWithValue("price", txtprice.Text)
                End With

                cmd.ExecuteNonQuery()
                MsgBox("Order added successfully!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            con.Close() ' Ensure the connection is closed
        End Try
    End Sub





    'Private Sub CategoryButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        connect() ' Open your database connection

    '        ' Base SQL query to fetch inventory details
    '        Dim sql As String = "SELECT i.invID, i.prodcode, c.categname AS CategoryName, " & _
    '                            "COALESCE(f.ftype, ltype) AS ItemsType, " & _
    '                            "COALESCE(f.fbrand, l.lbrand) AS Brand, " & _
    '                            "COALESCE(f.fdesc, l.ldesc) AS Description, " & _
    '                            "COALESCE(f.fcolor, l.lcolor) AS Color, i.quantity, i.price, i.prodstatus " & _
    '                            "FROM inventory i " & _
    '                            "LEFT JOIN categories c ON i.categID = c.categID " & _
    '                            "LEFT JOIN framestock f ON i.categID = f.frameID " & _
    '                            "LEFT JOIN lensstock l ON i.categID = l.lensID"

    '        Dim clickedButton As Button = CType(sender, Button)
    '        Dim categoryID As Integer = CInt(clickedButton.Tag)

    '        ' Add a condition if a specific category is selected
    '        If categoryID <> -1 Then ' Assuming -1 is used for "All"
    '            sql &= " WHERE c.categID = ?"
    '        End If

    '        Using cmd As New Odbc.OdbcCommand(sql, con)
    '            ' Add parameter only if a specific category is selected
    '            If categoryID <> -1 Then
    '                cmd.Parameters.AddWithValue("?", categoryID)
    '            End If

    '            Using dr As Odbc.OdbcDataReader = cmd.ExecuteReader()
    '                ' Clear previous data in relevant controls
    '                ClearControls()

    '                ' Populate the controls with new filtered data
    '                While dr.Read()
    '                    Dim itemsType As String = If(dr("ItemsType") Is DBNull.Value, String.Empty, dr("ItemsType").ToString())
    '                    Dim brand As String = If(dr("Brand") Is DBNull.Value, String.Empty, dr("Brand").ToString())
    '                    Dim color As String = If(dr("Color") Is DBNull.Value, String.Empty, dr("Color").ToString())
    '                    Dim description As String = If(dr("Description") Is DBNull.Value, String.Empty, dr("Description").ToString())

    '                    ' Populate controls based on the category
    '                    If categoryID = 1 OrElse categoryID = -1 Then ' Frames or All
    '                        combotype2.Items.Add(itemsType)
    '                        combobrand2.Items.Add(brand)
    '                        combocolor2.Items.Add(color)
    '                        CheckedListBox2.Items.Add(description)
    '                    End If

    '                    If categoryID = 2 OrElse categoryID = -1 Then ' Lenses or All
    '                        combotype.Items.Add(itemsType)
    '                        combobrand.Items.Add(brand)
    '                        combocolor.Items.Add(color)
    '                        CheckedListBox1.Items.Add(description)
    '                    End If
    '                End While
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MsgBox("An error occurred: " & ex.Message)
    '    Finally
    '        If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    '    End Try
    'End Sub

    ' Helper method to clear controls
    Private Sub ClearControls()
        CheckedListBox2.Items.Clear()
        combotype2.Items.Clear()
        combobrand2.Items.Clear()
        combocolor2.Items.Clear()
        CheckedListBox1.Items.Clear()
        combotype.Items.Clear()
        combobrand.Items.Clear()
        combocolor.Items.Clear()
        txtprice.Text = String.Empty
    End Sub





    'Sub loadCategory()
    '    comboCategory.Items.Clear()
    '    Dim cmd As Odbc.OdbcCommand
    '    Dim sql As String
    '    Try
    '        Call connect()
    '        sql = "SELECT * FROM tbl_category"
    '        cmd = New Odbc.OdbcCommand(sql, con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read = True
    '            comboCategory.Items.Add(dr.Item("addCat").ToString)
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    con.Close()
    'End Sub

    'Sub loadDesc(selectedCategory As String)
    '    comboDesc.Items.Clear() ' Clear the comboDesc items before loading new ones
    '    Dim cmd As Odbc.OdbcCommand
    '    Dim sql As String
    '    Try
    '        Call connect() ' Establish database connection
    '        ' SQL query to select descriptions based on the selected category
    '        sql = "SELECT description FROM tbl_inventory WHERE category = ?"
    '        cmd = New Odbc.OdbcCommand(sql, con)
    '        cmd.Parameters.AddWithValue("?", selectedCategory) ' Add parameter to filter by category
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            comboDesc.Items.Add(dr.Item("description").ToString()) ' Add each description to comboDesc
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message) ' Display any error message
    '    End Try
    '    con.Close() ' Close the connection
    'End Sub


    'Sub LensAndFrames()
    '    dgv.Rows.Clear()
    '    ' Check if columns are already added to avoid duplicates
    '    If dgv.Columns.Count = 0 Then
    '        Dim columnNames As String() = {"No", "Trans No", "Lens Type", "Lens Side", "Lens For", "Features",
    '                                       "Occu Lens", "Digi Lens", "Drive Lens", "Sing Lens", "Lens Price",
    '                                       "Brand", "Frame Type", "Model", "Frame Color", "Frame Price",
    '                                       "Add Req", "Add Price", "SubTotal"}
    '        For i As Integer = 0 To columnNames.Length - 1
    '            dgv.Columns.Add("Column" & (i + 1).ToString(), columnNames(i))
    '        Next
    '    End If

    '    Try
    '        connect()
    '        cmd = New Odbc.OdbcCommand("SELECT transno, lensType, lensSide, lensFor, features, occuLens, digiLens, driveLens, singLens, lensPrice, Brand, frameType, model, fColor, framePrice, addReq, addPrice, subTotal FROM tbl_lensandframe WHERE isDeleted = 1", con)
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("patientid"), dr.Item("transno"), dr.Item("Brand"), dr.Item("fullname"), dr.Item("lensType"), dr.Item("lensSide"), dr.Item("lensFor"), dr.Item("features"), dr.Item("occuLens"), dr.Item("digiLens"), dr.Item("driveLens"), dr.Item("singLens"), dr.Item("lensPrice"), dr.Item("frameType"), dr.Item("model"), dr.Item("fcolor"), dr.Item("framePrice"), dr.Item("addreq"), dr.Item("addPrice"), dr.Item("subTotal"))
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    End Try
    'End Sub

    'Sub orderslip()
    '    Try
    '        connect()
    '        ' Update the SQL query to include joins and additional fields
    '        cmd = New Odbc.OdbcCommand("SELECT p.patientid, lf.transno, CONCAT(UPPER(p.lname), ', ', p.fname, ' ', p.mname, ' ', p.suffix) AS fullname, lf.lensType, lf.lensSide, lf.lensFor, lf.features, lf.occuLens, lf.digiLens, lf.driveLens, lf.singLens, lf.lensPrice, lf.Brand, lf.frameType, lf.model, lf.fColor, lf.framePrice, lf.addReq, lf.addPrice, lf.subTotal FROM tbl_lensandframe lf LEFT JOIN tbl_addpatient p ON lf.patientid = p.patientid WHERE lf.isDeleted = 1", con)
    '        dr = cmd.ExecuteReader

    '        ' Update dgv.Rows.Add to match the columns in your SQL query
    '        While dr.Read
    '            dgv.Rows.Add(dgv.Rows.Count + 1, dr.Item("patientid"), dr.Item("transno"), dr.Item("fullname"), dr.Item("Brand"), dr.Item("lensType"), dr.Item("lensSide"), dr.Item("lensFor"), dr.Item("features"), dr.Item("occuLens"), dr.Item("digiLens"), dr.Item("driveLens"), dr.Item("singLens"), dr.Item("lensPrice"), dr.Item("frameType"), dr.Item("model"), dr.Item("fcolor"), dr.Item("framePrice"), dr.Item("addreq"), dr.Item("addPrice"), dr.Item("subTotal"))
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    End Try
    'End Sub

    'Sub auto_Transno()
    '    Try
    '        Call connect()
    '        cmd = New Odbc.OdbcCommand("SELECT * FROM tbl_lensandframe order by lfID desc", con)
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        If dr.HasRows = True Then
    '            lblTransNo.Text = dr.Item("transno").ToString + 1

    '        Else
    '            lblTransNo.Text = Date.Now.ToString("yyyyMMdd") & "001"
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub

    Private Sub btn_Payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        frm_Payment.ShowDialog()
    End Sub

    'Private Sub getTotal()
    '    Try
    '        Dim framePrice As Double = 0
    '        Dim lensPrice As Double = 0
    '        Dim addPrice As Double = 0

    '        ' Validate each input field before attempting to calculate the subtotal
    '        If IsNumeric(txtFrameprice.Text) Then framePrice = Val(txtFrameprice.Text)
    '        If IsNumeric(txtLensprice.Text) Then lensPrice = Val(txtLensprice.Text)
    '        If IsNumeric(txtAddprice.Text) Then addPrice = Val(txtAddprice.Text)

    '        Dim subtotal As Double = framePrice + lensPrice + addPrice
    '        lbl_overallTotal.Text = Format(subtotal, "₱#,##0.00")

    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '        lbl_overallTotal.Text = "₱0.00"
    '    End Try
    'End Sub
    'Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
    '    Dim fields() As Control = {txtframeprice, txtLensprice}
    '    Dim labels() As String = {"Frame Price", "Lens Price"}

    '    For i As Integer = 0 To fields.Length - 1
    '        If fields(i).Text = String.Empty OrElse Not IsNumeric(fields(i).Text) Then
    '            MsgBox("Please input a valid " & labels(i), vbExclamation, "Required missing or invalid field")
    '            fields(i).Select()
    '            Return
    '        End If
    '    Next

    '    Try
    '        lbl_overallTotal.Text = Format(CDbl(lbl_overallTotal.Text.Replace("₱", "").Replace(",", "")), "₱#,##0.00")
    '        connect()

    '        If btnadd.Tag = 0 Then
    '            cmd = New Odbc.OdbcCommand("INSERT INTO tbl_lensandframe (patientid, Brand, lenstype, lensSide, lensFor, features, occuLens, digiLens, driveLens, singLens, lensPrice, frameType, model, fColor, framePrice, addReq, addPrice, subtotal, isdeleted) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", con)
    '            With cmd.Parameters
    '                .AddWithValue("?", txtpatientID.Text)
    '                .AddWithValue("?", cmbbrand.Text)
    '                .AddWithValue("?", cmbtype.Text)
    '                .AddWithValue("?", cmbside.Text)
    '                .AddWithValue("?", cmbfor.Text)
    '                .AddWithValue("?", cmbFeatures.Text)
    '                '.AddWithValue("?", cmbOccu.Text)
    '                '.AddWithValue("?", cmbDigi.Text)
    '                '.AddWithValue("?", cmbDrive.Text)
    '                '.AddWithValue("?", cmbSing.Text)
    '                .AddWithValue("?", Val(txtLensprice.Text))
    '                .AddWithValue("?", cmbtypef.Text)
    '                .AddWithValue("?", cmbmodel.Text)
    '                .AddWithValue("?", cmbfcolor.Text)
    '                .AddWithValue("?", Val(txtframeprice.Text))
    '                .AddWithValue("?", txtaddreq.Text)
    '                .AddWithValue("?", Val(txtaddprice.Text))
    '                .AddWithValue("?", CDbl(lbl_overallTotal.Text.Replace("₱", "").Replace(",", "")))
    '                .AddWithValue("?", CBool(checkboxdeleted.Checked))
    '            End With
    '            cmd.ExecuteNonQuery()
    '            MsgBox("Lens and Frames added successfuly", vbInformation, "Success")
    '            clear()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        con.Close()
    '        orderslip()
    '        GC.Collect()
    '        Me.Dispose()
    '    End Try
    'End Sub

    'Sub clear()
    '    cmbbrand.ResetText()
    '    cmbtype.ResetText()
    '    cmbside.ResetText()
    '    cmbfor.ResetText()
    '    cmbFeatures.ResetText()
    '    'cmbOccu.ResetText()
    '    'cmbDigi.ResetText()
    '    'cmbDrive.ResetText()
    '    'cmbSing.ResetText()
    '    txtLensprice.Clear()
    '    cmbtypef.ResetText()
    '    cmbmodel.ResetText()
    '    cmbfcolor.ResetText()
    '    txtframeprice.Clear()
    '    txtaddreq.Clear()
    '    txtaddprice.Clear()
    '    txtpatientID.Clear()
    '    lbl_overallTotal.Text = "₱00.00"
    'End Sub

    'Private Sub txtLensprice_TextChanged(sender As Object, e As EventArgs)
    '    getTotal()
    'End Sub

    'Private Sub txtframeprice_TextChanged(sender As Object, e As EventArgs) Handles txtframeprice.TextChanged
    '    getTotal()
    'End Sub

    'Private Sub txtaddprice_TextChanged(sender As Object, e As EventArgs)
    '    getTotal()
    'End Sub

    'Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    '    clear()
    'End Sub

    'Private Sub comboCategory_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    ' Call loadDesc method to load descriptions based on the selected category
    '    loadDesc(comboCategory.SelectedItem.ToString())
    'End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If dgv.RowCount > 0 Then
            MsgBox("Please settle the pending order!", vbExclamation, "Logout")
            Return
        Else

        End If
        If MsgBox("Are you sure you want to Log Out?", vbQuestion + vbYesNo, "Log Out") = vbYes Then
            Me.Dispose()

            If UCase(role) = "ADMIN" Then
                Log("OUT")
                'AuditTrail("Log Out")
            End If
            frm_Login.Show()
            Call frm_Login.txtUsername.Focus()
            With frm_Login
                .txtUsername.Clear()
                .txtPassword.Clear()
            End With
        Else
            Return
        End If
    End Sub

    'Private Sub comboCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocateg.SelectedIndexChanged
    '    combobrand.Items.Clear()
    '    combocolor.Items.Clear()
    '    txtprice.Text = ""
    '    combobrand.SelectedIndex = -1
    '    combocolor.SelectedIndex = -1
    '    loadDesc() ' Reload descriptions based on the selected category
    'End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub


End Class
