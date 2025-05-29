INSERT INTO transacoes_tb (Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao)
VALUES 
('1234567812345678', 150.00, GETDATE(), 'Compra no mercado', 'Aprovada'),
('8765432187654321', 1200.00, GETDATE(), 'Pagamento de serviço', 'Pendente'),
('1111222233334444', 3000.50, GETDATE(), 'Compra online', 'Cancelada'),
('9999888877776666', 500.00, GETDATE(), 'Assinatura streaming', 'Pendente');
