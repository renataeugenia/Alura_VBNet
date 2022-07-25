Public Class Form2

    Dim ContaCorrente1 As New ContaCorrente
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Label1.Text = "p1PrimeiraClasse"


        Label2.Text = "Saldo Atual"
        Label3.Text = "Valor do Saque"
        Button1.Text = "Efetuar Saque"
        Label4.Text = "Mensagem"
        Label5.Text = "Novo Saldo"
        GroupBox1.Text = "C/c"
        GroupBox2.Text = "C/c Saque"

        'inicializar os dados da classe
        ContaCorrente1.Titular = "Renata Eugênia"
        ContaCorrente1.Agencia = 8750
        ContaCorrente1.Conta = 75906

        TextBox1.Text = ($" Bem Vinda {ContaCorrente1.Titular} Agencia: {ContaCorrente1.Agencia} Conta Corrente: {ContaCorrente1.Conta} ")

        TextBox2.Text = ContaCorrente1.Saldo.ToString






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = ""
        TextBox5.Text = ""

        Dim valor As Double = Val(TextBox3.Text)

        Dim retornoSaque As Boolean = ContaCorrente1.Sacar(valor)

        If retornoSaque = False Then

            TextBox4.Text = "Saque negado! Saldo insuficiente!!!"

        Else
            TextBox4.Text = "Saque efetuado com sucesso!"
            TextBox5.Text = ($"{ContaCorrente1.Saldo}")

        End If


    End Sub
End Class