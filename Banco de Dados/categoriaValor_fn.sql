CREATE FUNCTION dbo.CategoriaValor_fn(@Valor Decimal(18,2))
RETURNS VARCHAR(10)
AS
BEGIN
 DECLARE @Categoria Varchar(10);

 IF @Valor > 2000
	SET @Categoria = 'Premium'
 ELSE IF @Valor >=1000 AND @Valor <= 2000
   SET @Categoria = 'Alta'
 ElSE if @Valor >= 500 AND @Valor < 1000
   SET @Categoria = 'Média'
 ELSE
   SET @Categoria = 'Baixa'

 RETURN @Categoria

END