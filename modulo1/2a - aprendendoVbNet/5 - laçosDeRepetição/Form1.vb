Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Label1.Text = "5- Laços de Repetição"
        Me.Text = "Projeto 5 - lacosDeRepeticao"
        Button1.Text = "Calcular c/ laço While"
        Label2.Text = "Valor Aplicado"
        Label3.Text = "Juros %"
        Label4.Text = "Periodo"
        Label5.Text = "Extrato da Aplicação"
        Button2.Text = "Calcular c/ laço For"
        Label6.Text = "Extrato da Aplicação"
        Grp_While_For.Text = "Laço While e For"
        Grp_For_Encadeado.Text = "Laço For Encadeado"
        Label7.Text = "Valor Aplicado"
        Label8.Text = "Juros %"
        Label9.Text = "Anos Aplicados"
        Label10.Text = "Acrescimo Juros %"
        Button3.Text = "Calcular"
        Label11.Text = "Extrato da Aplicação"







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valorAplicado As Double = Val(TextBox1.Text)
        Dim juros As Double = Val(TextBox2.Text)
        Dim periodo As Integer = Val(TextBox3.Text)
        Dim contador As Integer = 1
        Dim extrato As String = ""

        While contador <= periodo
            valorAplicado = (valorAplicado + (valorAplicado * (juros / 100)))
            extrato += "O saldo no mês : " + contador.ToString + " R$ " + valorAplicado.ToString + vbCrLf
            contador += 1
        End While
        TextBox4.Text = extrato





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valorAplicado As Double = Val(TextBox1.Text)
        Dim juros As Double = Val(TextBox2.Text)
        Dim periodo As Integer = Val(TextBox3.Text)
        Dim extrato As String = ""

        For i As Integer = 1 To periodo
            valorAplicado = (valorAplicado + (valorAplicado * (juros / 100)))
            extrato += "O saldo no mês : " + i.ToString + " R$ " + valorAplicado.ToString + vbCrLf

        Next
        TextBox5.Text = extrato


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valorAplicado As Double = Val(TextBox6.Text)
        Dim juros As Double = Val(TextBox7.Text)
        Dim anosAplicados As Integer = Val(TextBox8.Text)
        Dim acrescimoJuros As Double = Val(TextBox9.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1


        For i As Integer = 1 To anosAplicados
            For j As Integer = 1 To 12
                valorAplicado = (valorAplicado + (valorAplicado * (juros / 100)))
                extrato += "O saldo do investimento no mês : " + contador.ToString + " R$ " + valorAplicado.ToString + " com a taxa de: " + juros.ToString + " % mês " + vbCrLf
                contador += 1
            Next
            juros = juros + (juros * acrescimoJuros / 100)

        Next
        TextBox10.Text = extrato
    End Sub
End Class
