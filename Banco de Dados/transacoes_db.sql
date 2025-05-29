USE CartaoCredito_db
GO

CREATE TABLE transacoes_tb (
	 Id_Transacao INT IDENTITY (1,1) PRIMARY KEY
	,Numero_Cartao VARCHAR(16) NOT NULL
	,Valor_transacao DECIMAL (18,2) NOT NULL CHECK (Valor_Transacao > 0)
	,Data_Transacao DATETIME NOT NULL
	,Descricao VARCHAR (255) NOT NULL
	,Status_Transacao VARCHAR (20) NOT NULL CHECK (Status_Transacao IN ('Aprovada', 'Pendente', 'Cancelada'))
	);

GO
