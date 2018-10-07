CREATE DATABASE PersonasDb
GO
USE PersonasDb
GO
CREATE TABLE Personas
(
	PersonaId int primary key identity(1,1),
	Nombre varchar(30),
	Cedula varchar(13),
	Direccion varchar(max),
	FechaNacimiento datetime
);