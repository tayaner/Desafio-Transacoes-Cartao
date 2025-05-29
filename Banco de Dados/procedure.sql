CREATE PROCEDURE CalculaTotaisTransacoes_sp
	@Data_Inicial DATETIME,
	@Data_Final DATETIME,
	@Status_Transacao VARCHAR(20)

AS
BEGIN
	SET NOCOUNT ON

	SELECT
		Numero_Cartao,
		SUM(Valor_Transacao) AS Valor_Total,
		COUNT(*) AS Quantidade_Transacoes,
		Status_Transacao
	FROM transacoes_tb
	WHERE Data_Transacao BETWEEN @Data_Inicial AND @Data_Final
	AND Status_Transacao = @Status_Transacao
	GROUP BY
		Numero_Cartao, Status_Transacao

END



