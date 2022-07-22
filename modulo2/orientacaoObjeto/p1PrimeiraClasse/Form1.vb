Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "p1-primeiraClasse"
        Label1.Text = "projeto1-PrimeiraClasse"
        Button1.Text = "resultado"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ContaCorrente1 As New ContaCorrente
        ContaCorrente1.Titular = "Renata Eugênia"
        ContaCorrente1.Agencia = 7590
        ContaCorrente1.Conta = 96857
        ContaCorrente1.Saldo = 125.52
        MsgBox($"O saldo da conta corrente {ContaCorrente1.Conta} é {ContaCorrente1.Saldo}")

    End Sub
End Class
