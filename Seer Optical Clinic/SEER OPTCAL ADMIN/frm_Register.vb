Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frm_Register
    Public _user As String
    Private Const kur As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
                                        <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub frm_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txtLoginName.Select()
        'btnCancel.Select()
        Me.KeyPreview = True
        'Me.Location = New Point(560, 405)
        SendMessage(txtLoginName.Handle, kur, 1, "Type your name")
        SendMessage(txtPass.Handle, kur, 1, "Type your password")
        SendMessage(txtUser.Handle, kur, 1, "Type your username")
        'comboRule.AutoCompleteMode = AutoCompleteMode.Append
        'comboRule.DropDownStyle = ComboBoxStyle.DropDown
        'comboRule.AutoCompleteSource = AutoCompleteSource.ListItems
        RoundButton(btnRegister)
        'RoundButton(btnCancel)
        'btnC.Dispose()
        RoundButton(btnC)
        roundCorners(Me)
        Call connect()
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
        Raduis.AddLine(btnRegister.Width, 20, btn.Width, btn.Height - 10)
        'Raduis.AddLine(btnCancel.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddLine(btnEdit.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddLine(btnC.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddLine(btnChange.Width, 20, btn.Width, btn.Height - 10)
        Raduis.AddLine(btnLoginExit.Width, 20, btn.Width, btn.Height - 10)

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
        btnRegister.Region = New Region(Raduis)
        'btnCancel.Region = New Region(Raduis)
        btnEdit.Region = New Region(Raduis)
        btnC.Region = New Region(Raduis)
        btnChange.Region = New Region(Raduis)
        btnLoginExit.Region = New Region(Raduis)

    End Sub

    Private Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub
    Sub clear()
        txtLoginName.Clear()
        txtUser.Clear()
        txtPass.Clear()
        comboRule.SelectedIndex = -1
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        If txtLoginName.Text = String.Empty Then
            MsgBox("Please input your name!", vbExclamation, "Required missing field!")
            txtLoginName.Select()
            Return
        End If
        If txtUser.Text = String.Empty Then
            MsgBox("Please input your username!", vbExclamation, "Required missing field!")
            txtUser.Select()
            Return
        End If
        If txtPass.Text = String.Empty Then
            MsgBox("Please input your password!", vbExclamation, "Required missing field!")
            txtPass.Select()
            Return
        End If
        If comboRule.Text = String.Empty Then
            MsgBox("Please select role!", vbExclamation, "Required missing field!")
            comboRule.Select()
            Return
        End If
        If DataValidation(pnlData) Then
            Try
                connect()
                cmd = New Odbc.OdbcCommand("SELECT * FROM tbl_users WHERE name='" & txtLoginName.Text & "'", con)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MsgBox("The name already exists!", vbExclamation, "Duplicate entry")
                    txtLoginName.Clear()
                    txtLoginName.Select()
                    dr.Close()
                    Return
                End If
                connect()
                cmd = New Odbc.OdbcCommand("SELECT * FROM tbl_users WHERE username='" & txtUser.Text & "'", con)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MsgBox("The username already exists!", vbExclamation, "Duplicate entry")
                    txtUser.Clear()
                    txtUser.Select()
                    dr.Close()
                    Return
                End If
                connect()
                sql = "INSERT INTO tbl_users (name,username,password,role) VALUES (?,?,sha2(?,224),?)"
                cmd = New Odbc.OdbcCommand(sql, con)
                With cmd.Parameters
                    .AddWithValue("?", (txtLoginName.Text))
                    .AddWithValue("?", (txtUser.Text))
                    .AddWithValue("?", (txtPass.Text))
                    .AddWithValue("?", (comboRule.Text))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("New users successfully register!", MsgBoxStyle.Information, "Success")
                'AuditTrail("Register a new users; " & "Name: " & txtLoginName.Text & ", Role: " & comboRule.SelectedItem)
                clear()
                'Call clean(pnlData)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical + vbOKOnly, "Error Save")
            Finally
                con.Close()
                txtLoginName.Focus()
            End Try
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim cmd As Odbc.OdbcCommand
        Dim sql As String
        If DataValidation(pnlData) Then
            Try
                connect()
                cmd = New Odbc.OdbcCommand("SELECT * FROM tbl_users WHERE name='" & txtLoginName.Text & "'", con)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MsgBox("The name already exists!", vbExclamation, "Duplicate entry")
                    Me.Dispose()
                    txtLoginName.Clear()
                    dr.Close()
                    Return
                End If
                connect()
                sql = "UPDATE tbl_users SET name=?, role=? WHERE name=?"
                cmd = New Odbc.OdbcCommand(sql, con)
                With cmd.Parameters
                    .AddWithValue("?", (txtLoginName.Text))
                    .AddWithValue("?", (comboRule.Text))
                    .AddWithValue("?", (_user))
                End With
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("The user account was updated successfully!", vbInformation, "Success")
                    frm_Maintenance.loadUser()
                    txtLoginName.Clear()
                    Me.Dispose()
                Else
                    MsgBox("The user account update failed!", vbExclamation, "Failed")
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub checkHideEye_CheckedChanged(sender As Object, e As EventArgs) Handles checkHideEye.CheckedChanged
        If checkHideEye.Tag = 0 Then
            txtPass.Select()
            checkHideEye.Tag = 1
            txtPass.UseSystemPasswordChar = False
            checkHideEye.Visible = False
        Else
            txtPass.Select()
            checkHideEye.Tag = 0
        End If
    End Sub
    Private Sub checkHide_CheckedChanged(sender As Object, e As EventArgs) Handles checkHide.CheckedChanged
        If checkHide.Tag = 0 Then
            txtPass.Select()
            checkHide.Tag = 1
            txtPass.UseSystemPasswordChar = True
            checkHideEye.Visible = True
            SendMessage(txtPass.Handle, kur, 1, "Type your password")
        Else
            txtPass.Select()
            checkHide.Tag = 0
        End If
    End Sub

    Private Sub btnLoginExit_Click(sender As Object, e As EventArgs) Handles btnLoginExit.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "Exit") = vbYes Then
            Me.Dispose()
        Else
            Return
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Me.Dispose()
    End Sub


    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        frm_ChangePassword.ShowDialog()
    End Sub

    Private Sub comboRule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboRule.SelectedIndexChanged

    End Sub
End Class