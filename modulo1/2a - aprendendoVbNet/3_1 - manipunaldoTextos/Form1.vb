Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("3_1 - Manipulando textos...")

        Dim primeiraLetra As Char = "a"
        MsgBox("a variavel primeira letra é : " + primeiraLetra)

        Dim numeroChar As Integer
        numeroChar = 66
        Dim segundaLetra As Char = Chr(numeroChar)

        MsgBox("a variavel numero char armazena : " + segundaLetra)






    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numeroChar As Integer = Val(TextBox1.Text)
        Dim terceiraLetra As Char = Chr(numeroChar)

        MsgBox(" o caracter para o numero " + numeroChar.ToString + " é " + terceiraLetra)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
