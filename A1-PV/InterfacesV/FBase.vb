Public Class FBase
    Public Function TablaMultiplicarON()
        GroupBox1.Show()

    End Function

    Public Function TablaMultiplicarOFF()
        GroupBox1.Hide()

    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FMenu.Show()
        Me.TablaMultiplicarOFF()
        Me.Hide()
    End Sub
End Class