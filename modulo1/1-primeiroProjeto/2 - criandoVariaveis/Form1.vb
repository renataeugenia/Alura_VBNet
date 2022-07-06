Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim idade As Integer

        idade = 15

        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Critical)

        idade = 15 * 3

        MsgBox("O valor da idade multiplicado por 3 é " + idade.ToString, MsgBoxStyle.Critical)

        idade = (15 * 3) + 2

        MsgBox(" O valor da idade multiplicado por 2 e somado mais 2 é o valor atual da idade " + idade.ToString, MsgBoxStyle.Critical)

    End Sub
End Class
