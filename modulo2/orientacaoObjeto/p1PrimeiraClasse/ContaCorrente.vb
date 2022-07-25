
Public Class ContaCorrente

    Public Titular As String
    Public Agencia As Integer
    Public Conta As Integer
    Public Saldo As Double = 100

    Public Function Sacar(valor As Double) As Boolean

        Dim retorno As Boolean

        If Saldo <= valor Then
            retorno = False
        Else
            Saldo -= valor
            retorno = True
        End If
        Return retorno
    End Function

End Class