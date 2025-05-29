Imports Microsoft.Data.SqlClient


Module ModConexao

    ' String de conexão
    ' String de conexão - Ajuste seu servidor e banco se necessário
    Public conexao As New SqlConnection("Data Source=CHOPPER\SQLEXPRESS;Initial Catalog=CartaoCredito_db;Trusted_Connection=True;TrustServerCertificate=True")


    ' Abrir conexão
    Public Sub AbrirConexao()
        If conexao.State = ConnectionState.Closed Then
            conexao.Open()
        End If
    End Sub

    ' Fechar conexão
    Public Sub FecharConexao()
        If conexao.State = ConnectionState.Open Then
            conexao.Close()
        End If
    End Sub

End Module
