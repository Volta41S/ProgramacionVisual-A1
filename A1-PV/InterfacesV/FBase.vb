Imports System.Windows

Public Class FBase
    'Realiza la operacion para tabla de multiplicar'
    Private Sub RTablaMultiplicar()
        Dim Valor1, Valor2, i As Integer
        Dim resultado As String
        resultado = ""
        Valor1 = CInt(TextBox1.Text)
        Valor2 = CInt(TextBox2.Text)
        TextBox3.Text = ""
        For i = 1 To Valor2
            resultado += ($"{Valor1} x {i} = ") + CStr(i * Valor1) + vbNewLine
        Next
        TextBox3.Text = resultado
    End Sub

    'Cierra la ventana, limpia las cajas y va al menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FMenu.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Me.Hide()
    End Sub

    'Llama a la funcion para realizar la tabla de multiplicacion
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RTablaMultiplicar()
    End Sub

    'Limpia la caja de resultado
    Private Sub Limpiar(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = ""
    End Sub

    'Evita que se añada texto en las cajas
    Private Sub txtlevantamiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class