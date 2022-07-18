Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Label1.Text = "4 - Controle de Fluxo"
        Button1.Text = "Permissão de Entrada"
        Me.Text = "4 - controleDeFluxo"

        'inicialização dos componentes da aplicação

        Label2.Text = "Idade"
        Label3.Text = "Resultado"
        Label4.Text = "Esta acompanhado de uma pessoa maior de idade? S ou N"









    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        TextBox2.Text = ""



        Dim idade As Integer
        idade = TextBox1.Text

        Dim acompanhante As String
        acompanhante = TextBox3.Text



        If (idade >= 18) Then
            TextBox2.Text = "Entrada liberada!"

        Else

            If acompanhante = "S" And idade >= 16 Then

                TextBox2.Text = "Entrada liberada! voce tem entre 16 e 18 anos e esta acompanhado de uma pessoa maior de idade!"

            Else


                If acompanhante = "N" And idade >= 16 Then

                    TextBox2.Text = "Entrada negada! voce tem entre 16 e 18 anos, mas não esta acompanhado de uma pessoa maior de idade!"

                Else
                    TextBox2.Text = "Entrada negada! voce é menor de idade!"

                End If

            End If

        End If




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
