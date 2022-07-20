Imports _3_1___manipunaldoTextos
Imports _4___controleDeFluxo
Imports _5___laçosDeRepetição
Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Projeto Principal"
        Button1.Text = " 3_1 Manipulando Textos"
        Button2.Text = " 4 - Controle de Fluxo"
        Button3.Text = " 5 - Laços de Repetição"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New
        f.Show
    End Sub
End Class
