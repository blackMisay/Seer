Imports System.Data.Odbc.OdbcConnection
Imports System.IO

Public Class frm_addFeature

    Private Sub frm_addFeature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect() ' Assuming this establishes the connection
        Me.Show()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String

        Try
            connect()
            ' Check if product type already exists in tbl_addType
            cmd = New Odbc.OdbcCommand("SELECT * FROM categories WHERE categID='" & txtCategory.Text & "'", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                MsgBox("Product type already exists!", vbExclamation, "Duplicate entry")
                txtCategory.Clear()
                txtCategory.Select()
                dr.Close()
                Return
            End If
            ' Insert new product type into tbl_addType
            connect()
            sql = "INSERT INTO categories (categname) VALUES(?)"
            cmd = New Odbc.OdbcCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("?", txtCategory.Text)
            End With
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("The new Category was added successfully!", vbInformation, "Success")
                txtCategory.Clear()
                frm_Inventory2.loadcategory()
                Me.Close()
            Else
                MsgBox("Failed to add Category.", vbExclamation, "Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    'Private Sub btnExit_Click(sender As Object, e As EventArgs)
    '    Me.Dispose()
    'End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        txtCategory.Clear()
    End Sub

End Class
