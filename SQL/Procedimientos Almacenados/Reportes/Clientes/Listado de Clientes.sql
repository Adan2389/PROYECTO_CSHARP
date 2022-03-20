


-- Devulve la lista de clientes

CREATE PROCEDURE SP_RPT_LISTAR_CLIENTES
(
	
	@TextoBuscar varchar(50)
)
AS
BEGIN
	
	SELECT * 
	FROM CLIENTES
	WHERE IDENTIDAD LIKE '%'+@TextoBuscar+'%' OR 
		  NOMBRE LIKE '%'+@TextoBuscar+'%' OR 
		  CORREO LIKE '%'+@TextoBuscar+'%' OR 
		  DIRECCION LIKE '%'+@TextoBuscar+'%'
END

GO 

