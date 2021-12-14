


-- Inserta un nuevo cliente

ALTER PROCEDURE SP_INSERTAR_CLIENTES
(
	@prmIdentidad varchar(50),
	@prmNombre nvarchar(350),
	@prmDireccion varchar(500),
	@prmTelefono varchar(50),
	@prmCorreo varchar(100),
	@prmMunicipio varchar(100),
	@prmFechaNacimiento date,
	@prmUsuario varchar(50), 

	@Result int = NULL output 
)
AS
BEGIN
	
	BEGIN TRY
		BEGIN TRANSACTION 
		Declare @newID int =0
		SELECT @newID = ISNULL(MAX(ID),0)+1 FROM CLIENTES

		INSERT INTO CLIENTES(ID, IDENTIDAD, NOMBRE, DIRECCION, TELEFONO, CORREO, MUNICIPIO, FECHA_NACIMIENTO, FECHA_CREACION, USUARIO_CREACION, ACTIVO )
		VALUES (@newID, @prmIdentidad, @prmNombre, @prmDireccion, @prmTelefono, @prmCorreo, @prmMunicipio, @prmFechaNacimiento, GETDATE(), @prmUsuario, 1 )
		COMMIT
		Set @Result = 1
	END TRY
	BEGIN CATCH
		ROLLBACK	
		Set @Result = 0
	END CATCH

	RETURN @Result

END

GO 



-- Modifica/Actualizar un  cliente

CREATE PROCEDURE SP_ACTUALIZAR_CLIENTES
(
	@prmId int,
	@prmIdentidad varchar(50),
	@prmNombre nvarchar(350),
	@prmDireccion varchar(500),
	@prmTelefono varchar(50),
	@prmCorreo varchar(100),
	@prmMunicipio varchar(100),
	@prmFechaNacimiento date,
	@prmUsuario varchar(50), 
	@Result int = NULL output 
)
AS
BEGIN
	
	Set @Result = 0

	UPDATE CLIENTES SET  IDENTIDAD = @prmIdentidad, NOMBRE =@prmNombre , DIRECCION=@prmDireccion, TELEFONO=@prmTelefono, CORREO=@prmCorreo, 
							MUNICIPIO=@prmMunicipio, FECHA_NACIMIENTO=@prmFechaNacimiento,  FECHA_MODIFICACION = GETDATE(), 
							USUARIO_MODIFICACION =  @prmUsuario
	WHERE ID = @prmId

	Set @Result = 1

	RETURN @Result

END

GO 


-- Marca como anulado un  cliente

CREATE PROCEDURE SP_ANULAR_CLIENTES
(
	@prmId int,
	@Result int = NULL output 
)
AS
BEGIN
	
	Set @Result = 0

	UPDATE CLIENTES SET  ACTIVO = 0
	WHERE ID = @prmId

	Set @Result = 1

	RETURN @Result

END

GO 



-- Devulve la lista de clientes

CREATE PROCEDURE SP_LISTAR_CLIENTES
AS
BEGIN
	
	SELECT * FROM CLIENTES
END

GO 





