CREATE FUNCTION dbo.TransacoesComCategoria_fn
(
	@Data_Inicial DATETIME,
	@Data_Final DATETIME

)
 RETURNS TABLE
 AS
 RETURN
(

	SELECT
		Id_Transacao,
		Numero_Cartao,
		Valor_transacao,
		dbo.CategoriaValor_fn(Valor_Transacao) As Categoria, 	
		Data_Transacao,
		Status_Transacao,
		Descricao
	FROM transacoes_tb
	WHERE Data_Transacao BETWEEN @Data_Inicial AND @Data_Final

)



