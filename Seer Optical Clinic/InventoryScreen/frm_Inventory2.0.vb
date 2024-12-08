Imports System.Data.Odbc.OdbcConnection
Imports System.IO

Public Class frm_Inventory2

    Private Sub frm_Inventory2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProd.RowTemplate.Height = 40
        dgvProdList.RowTemplate.Height = 40
        loadInventory()
        loadProdDetails()
        auto_prodCode()
        loadcategory()
        'loadframe()
        'loadColor()
        'loadBrand()
        'loadDesc()
    End Sub

    Sub loadInventory()
        dgvProd.Rows.Clear()
        Try
            Call connect()
            Dim cmd = New Odbc.OdbcCommand("SELECT i.invID, i.prodcode, c.categname AS CategoryName, COALESCE(f.ftype, ltype) AS ItemsType, COALESCE(f.fbrand, l.lbrand) AS Brand, COALESCE(f.fdesc, l.ldesc) AS Description, COALESCE(f.fcolor, l.lcolor) AS Color, i.quantity, i.price, i.prodstatus FROM inventory i LEFT JOIN categories c ON i.categID = c.categID LEFT JOIN framestock f ON i.categID = f.frameID LEFT JOIN lensstock l ON i.categID = l.lensID WHERE i.isDeleted = 0", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                dgvProd.Rows.Add(dgvProd.Rows.Count + 1,
                                 dr.Item("invID"),
                                 dr.Item("prodCode"),
                                 dr.Item("CategoryName"),
                                 dr.Item("ItemsType"),
                                 dr.Item("Brand"),
                                 dr.Item("Description"),
                                 dr.Item("Color"),
                                 dr.Item("quantity"),
                                 dr.Item("price"),
                                 dr.Item("prodStatus"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Sub loadProdDetails()
        dgvProdList.Rows.Clear()

        Try
            ' Ensure connection is established
            Call connect()
            If con.State = ConnectionState.Closed Then con.Open()

            ' Define the query
            Dim query As String = "SELECT * FROM vw_prodDetails ORDER by CategoryName"

            Using cmd As New Odbc.OdbcCommand(query, con)
                Using dr As Odbc.OdbcDataReader = cmd.ExecuteReader()
                    ' Read each record and add it to the DataGridView
                    While dr.Read()
                        dgvProdList.Rows.Add(dgvProdList.Rows.Count + 1,
                                         dr.Item("categID"),
                                         dr.Item("CategoryName"),
                                         dr.Item("ItemType"),
                                         dr.Item("Brand"),
                                         dr.Item("Description"),
                                         dr.Item("Color"))
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error loading product details: " & ex.Message, vbCritical, "Error")
        Finally
            ' Ensure the connection is properly closed
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Sub auto_prodCode()
        Try
            Call connect()
            cmd = New Odbc.OdbcCommand("SELECT * FROM inventory ORDER BY prodCode desc", con) ' Get the last product code
            dr = cmd.ExecuteReader
            If dr.Read() Then
                txt_prodCode.Text = (CInt(dr.Item("prodCode")) + 1).ToString() ' Increment the product code by 1
            Else
                txt_prodCode.Text = Date.Now.ToString("yyyyMM") & "001" ' Start with a new format if no records found
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' Ensure a new product code is generated
        auto_prodCode()

        Try
            connect()
            Using transaction = con.BeginTransaction()
                ' Check if product type already exists in inventory
                Dim queryCheck As String = "SELECT * FROM inventory WHERE categID = ? AND prodCode = ?"
                Using cmdCheck As New Odbc.OdbcCommand(queryCheck, con, transaction)
                    cmdCheck.Parameters.AddWithValue("?", combocategory.SelectedValue)
                    cmdCheck.Parameters.AddWithValue("?", txt_prodCode.Text)

                    Using dr = cmdCheck.ExecuteReader()
                        If dr.Read() Then
                            MsgBox("This Type of Product already exists", vbExclamation, "Duplicate Entry")
                            dr.Close()
                            Return
                        End If
                    End Using
                End Using

                ' Insert into inventory table
                Dim queryInsert As String = "INSERT INTO inventory (invID, prodCode, categID, quantity, price, prodStatus, isDeleted) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Using cmdInsert As New Odbc.OdbcCommand(queryInsert, con, transaction)
                    With cmdInsert.Parameters
                        .AddWithValue("?", ID.Text)
                        .AddWithValue("?", txt_prodCode.Text)
                        .AddWithValue("?", combocategory.SelectedValue)
                        .AddWithValue("?", CInt(txtQuan.Text))
                        .AddWithValue("?", CDbl(Trim(txt_price.Text)))
                        .AddWithValue("?", Toggle3.Checked)
                        .AddWithValue("?", CheckBoxStatus.Checked)
                    End With
                    cmdInsert.ExecuteNonQuery()
                End Using

                ' Insert into framestock table
                Dim queryFrame As String = "INSERT INTO framestock (ftype, fbrand, fdesc, fcolor, categID) VALUES (?, ?, ?, ?, ?)"
                Using cmdFrame As New Odbc.OdbcCommand(queryFrame, con, transaction)
                    With cmdFrame.Parameters
                        .AddWithValue("?", txttype.Text)
                        .AddWithValue("?", txtbrand.Text)
                        .AddWithValue("?", txtdesc.Text)
                        .AddWithValue("?", txtcolor.Text)
                        .AddWithValue("?", combocategory.SelectedValue)
                    End With
                    cmdFrame.ExecuteNonQuery()
                End Using

                ' Insert into lensstock table
                Dim queryLens As String = "INSERT INTO lensstock (ltype, lbrand, ldesc, lcolor, categID) VALUES (?, ?, ?, ?, ?)"
                Using cmdLens As New Odbc.OdbcCommand(queryLens, con, transaction)
                    With cmdLens.Parameters
                        .AddWithValue("?", txttype.Text)
                        .AddWithValue("?", txtbrand.Text)
                        .AddWithValue("?", txtdesc.Text)
                        .AddWithValue("?", txtcolor.Text)
                        .AddWithValue("?", combocategory.SelectedValue)
                    End With
                    cmdLens.ExecuteNonQuery()
                End Using

                ' Commit the transaction
                transaction.Commit()

                ' Notify success
                MsgBox("Product added successfully", MsgBoxStyle.Information, "Success")
                auto_prodCode() ' Regenerate product code after successful insert
                loadInventory() ' Refresh DataGridView to show the new product
                loadProdDetails()
                clear() ' Clear the form for the next entry
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Ensure the connection is closed
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
            GC.Collect()
        End Try
    End Sub

    Sub clear()
        combocategory.SelectedValue = -1
        txttype.Clear()
        txtbrand.Clear()
        txtdesc.Clear()
        txtcolor.Clear()
        txtQuan.Clear()
        txt_price.Clear()
        Toggle3.Checked = False
    End Sub

    Sub loadcategory()
        Try
            Call connect()
            Dim sql = "SELECT categID, categname FROM categories"
            Dim cmd = New Odbc.OdbcCommand(sql, con)
            Dim dt As New DataTable
            Dim da As New Odbc.OdbcDataAdapter(cmd)
            da.Fill(dt)

            ' Bind ComboBox
            combocategory.DataSource = dt
            combocategory.DisplayMember = "categname" ' What the user sees
            combocategory.ValueMember = "categID" ' What gets stored in the database (ID)
            combocategory.SelectedIndex = -1 ' Optionally reset selection
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        With frm_addFeature
            Me.Show()
            .btnEdit.Visible = False
            .btnSave.Enabled = True
            .btnSave.Visible = True
        End With
        frm_addFeature.ShowDialog()
    End Sub

End Class