Imports System.Diagnostics.Eventing.Reader

Public Class FBase2
    'Limpia cajas y cambia a la interfaz de menu'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FMenu.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Me.Hide()
    End Sub

    'Funcion de potenciar numero'
    Private Sub Potenciar()
        Dim Valor1, Valor2, i, resultado As Integer


        Valor1 = CInt(TextBox1.Text)
        Valor2 = CInt(TextBox2.Text)
        TextBox3.Text = ""
        resultado = Valor1
        If Valor2 > 1 Then 'Si es mayor a uno entonces'
            For i = 2 To Valor2
                resultado = resultado * Valor1
            Next
        Else
            If Valor2 = 1 Then 'Si es igual a 1'

                resultado = Valor1
            Else  'Si es 0'
                resultado = 0
            End If
        End If
        TextBox3.Text = ($"El numero {Valor1} elevado a la {Valor2} es igual a: {resultado}") + vbNewLine
    End Sub

    'Llamar a la funcion'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Potenciar()
    End Sub

    'Limpia la caja de resultado'
    Private Sub Limpiar(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = ""
    End Sub

    'Evita que se añada texto en las cajas'
    Private Sub txtlevantamiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'No estoy seguro que hace esto'
    Private Sub FBase2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class