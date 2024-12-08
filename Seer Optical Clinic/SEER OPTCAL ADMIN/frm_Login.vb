Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Public Class frm_Login
    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Me.Show()
        roundCorner(Me)
    End Sub
    Private Sub roundCorner(obj As Form)

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
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            connect()
            Dim found As Boolean = False
            cmd = New Odbc.OdbcCommand("SELECT * FROM `tbl_users` WHERE `username`='" & txtUsername.Text & "' AND `password`= sha2(?,224)", con)
            cmd.Parameters.AddWithValue("?", txtPassword.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                names = dr.Item("Name").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                role = dr.Item("Role").ToString
            Else
                found = False
                names = ""
                username = ""
                password = ""
                role = ""
            End If
            If found = True Then
                If StrComp(txtUsername.Text, username, CompareMethod.Binary) Or StrComp(txtPassword.Text, password, CompareMethod.Binary) Then
                    If UCase(role) = "ADMIN" Then
                        MsgBox("Admin " & names, vbInformation, "Welcome to SEER OPTICAL")
                        Log("IN")
                        'frm_appointment.btn_addpres.Dispose()
                        frm_Main.Show()
                        'Me.Hide()
                    ElseIf UCase(role) = "OPTOMETRIST" Then
                        MsgBox("Optometrist " & names, vbInformation, "Welcome to SEER OPTICAL")
                        Log("IN")
                        frm_Main.btnTrans.Enabled = False
                        frm_Main.btninventory.Enabled = False
                        frm_Main.btnMaintenance.Enabled = False
                        frm_Main.Show()
                        'Me.Hide
                    End If
                Else
                    MsgBox("Warning: Wrong Username or Password!", vbExclamation)
                    Return
                End If
            Else
                MsgBox("Wrong Username or Password!", vbExclamation, "Invalid")
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub login_Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure you want to Exit?", vbQuestion + vbYesNo, "Exit") = vbYes Then
                Me.Dispose()

            Else
                Return
            End If
        End If
    End Sub
    Private Sub btnLoginExit_Click(sender As Object, e As EventArgs) Handles btnLoginExit.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "Exit") = vbYes Then
            Me.Dispose()
        Else
            Return
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End If
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyData = Keys.Down Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.Enter Then
            'btnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
    Private Sub btnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            'btnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub frm_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class