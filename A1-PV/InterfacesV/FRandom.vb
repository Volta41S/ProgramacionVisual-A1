Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FRandom
    'No se que hace esto'
    Private Sub FRandom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Limpia cajas y va al menu'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FMenu.Show()
        TextBox1.Text = ""
        TextBox3.Text = ""
        Me.Hide()
    End Sub

    'Llamar a la funcion'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProbarSuerte()
    End Sub

    'Funcion Probar suerte'
    Private Sub ProbarSuerte()
        Dim Valor1, NRamdom As Integer
        Dim resultado As String

        NRamdom = Int((20 * Rnd()) + 1)
        If NRamdom = Valor1 Then
            resultado = "Tuvo suerte."
        Else
            resultado = ($"No tuvo suerte, el numero aleatorio fue {NRamdom}.")
        End If

        TextBox3.Text = resultado

    End Sub

    'Limpia la caja de resultado
    Private Sub Limpiar(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = ""
    End Sub

    'Evita que se añada texto en las cajas
    Private Sub txtlevantamiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class