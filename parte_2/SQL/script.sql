

CREATE DATABASE bd_Alumnos

GO

USE bd_Alumnos

GO

CREATE TABLE Alumnos
(
	Id INT PRIMARY KEY IDENTITY(1,1) ,
	Nombre VARCHAR(100),
	Nota DECIMAL(18,2)
)