create procedure dbo.eliminar_Rol
	@Id_Rol int
AS
	delete from dbo.Rol_X_Usuario
	where Rol_X_Usuario_Rol = @Id_Rol and @Id_Rol <> '1';
	delete from dbo.Roles
	where Rol_Id = @Id_Rol and @Id_Rol <> '1';
GO