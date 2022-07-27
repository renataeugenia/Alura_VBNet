Public Class Form2

    Dim ContaCorrente1 As New ContaCorrente
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Label1.Text = "p1PrimeiraClasse"


        Label2.Text = "Saldo Atual"
        Label3.Text = "Valor do Saque/Depósito"
        Button1.Text = "Efetuar Saque"
        Label4.Text = "Mensagem"
        Label5.Text = "Novo Saldo"
        GroupBox1.Text = "C/c"
        GroupBox2.Text = "C/c: Status Transação"
        Button2.Text = "Efetuar Depósito"
        GroupBox3.Text = "Extrato"

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True





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
            TextBox2.Text = TextBox5.Text
            ContaCorrente1.Extrato += Now.ToString + " Saque de R$  " + valor.ToString + " Saldo de R$  " + ContaCorrente1.Saldo.ToString + vbCrLf
            TextBox6.Text = ContaCorrente1.Extrato

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = ""
        TextBox5.Text = ""

        Dim valorDeposito As Double = Val(TextBox3.Text)
        ContaCorrente1.Depositar(valorDeposito)

        TextBox4.Text = "Depósito efetuado com sucesso!"
        TextBox5.Text = ($"{ContaCorrente1.Saldo}")
        TextBox2.Text = TextBox5.Text
        ContaCorrente1.Extrato += Now.ToString + " Depósito de R$  " + valorDeposito.ToString + " Saldo de R$  " + ContaCorrente1.Saldo.ToString + vbCrLf
        TextBox6.Text = ContaCorrente1.Extrato


    End Sub
End Class