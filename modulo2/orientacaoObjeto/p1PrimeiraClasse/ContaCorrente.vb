
Public Class ContaCorrente

    Public Titular As String
    Public Agencia As Integer
    Public Conta As Integer
    Public Saldo As Double = 100
    Public Extrato As String = ""

    Public Function Sacar(valor As Double) As Boolean

        Dim retorno As Boolean

        If Saldo < valor Or valor < 0 Then
            retorno = False
        Else
            Saldo -= valor
            retorno = True
        End If
        Return retorno
    End Function


    Public Function Transferir(valorTransfer As Double, ByRef destino As ContaCorrente) As Boolean
        Dim retorno As Boolean

        If Saldo < valorTransfer Or valorTransfer < 0 Then
            retorno = False
        Else
            Saldo -= valorTransfer
            destino.Depositar(valorTransfer)
            retorno = True
        End If
        Return retorno
    End Function


    Public Sub Depositar(valorDeposito As Double)

        Saldo += valorDeposito

    End Sub

End Class