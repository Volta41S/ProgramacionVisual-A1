Imports System.Drawing.Text

Public Class FMenu
    Private Sub BtnRepetitiva1_Click(sender As Object, e As EventArgs)
        FBase.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FBase2.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FRandom.Show()
        Me.Hide()
    End Sub


End Class
