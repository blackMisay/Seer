Imports System.Data.Odbc.OdbcConnection
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frm_ChangePassword

    Private Sub frm_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        roundCorners(Me)
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

    Private Sub btnLoginExit_Click(sender As Object, e As EventArgs) Handles btnLoginExit.Click
        Me.Dispose()
    End Sub
End Class