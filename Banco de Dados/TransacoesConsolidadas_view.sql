CREATE VIEW TransacoesConsolidadas_View
AS
SELECT 
	Numero_Cartao,
	Status_Transacao,
	dbo.CategoriaValor_fn(SUM(Valor_Transacao)) As Categoria,
	COUNT(*) AS Quantidade_Transacoes,
	SUM(Valor_Transacao) AS Valor_Total
FROM transacoes_tb
GROUP BY
	Numero_Cartao,
	Status_Transacao


