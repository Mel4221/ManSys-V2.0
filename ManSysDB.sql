
--/*
--	Aqui estara todo el codigo con el fin de replicar la base de datos de el programa
--	ManSys
--*/

--create database ManSysDB

--/*
--Crear tabla de Empleados con sus siguientes propiedades: 

--  ID (C digo de Empleado)  Datos para registrar 
--  Nombre (s)  Datos para registrar 
--  Apellido (s)  Datos para registrar 
--  Direcci n  Datos para registrar 
--  Tel fono/Celular  Datos para registrar 
--  CEDULA  Datos para registrar 
--  Fecha de Ingreso  Datos para registrar 
--  Puesto Ocupado  Datos para registrar 
--  Departamento  Datos para registrar 
--  Salario base  Datos para registrar 
--  Tipo de Cobro  Datos para registrar 
--  Turno  Datos para registrar 

--*/
--USE [ManSysDB]
--GO
--/****** Object:  Table [dbo].[Empleados]    Script Date: 10/18/2023 12:13:23 PM ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--CREATE TABLE [dbo].[Empleados](
--	[Id] [int] IDENTITY(1000,1) NOT NULL,
--	[Nombre] [varchar](50) NULL,
--	[Apellido] [varchar](50) NULL,
--	[Direccion] [varchar](100) NULL,
--	[Telefono] [varchar](50) NULL,
--	[Fecha_de_Ingreso] [varchar](50) NULL,
--	[Puesto_Ocupado] [varchar](50) NULL,
--	[Departamento] [varchar](50) NULL,
--	[CEDULA] [varchar](50) NULL,
--	[Salario_Base] [varchar](100) NULL,
--	[Tipo_de_Cobro] [varchar](50) NULL,
--	[Turno] [varchar](50) NULL
--) ON [PRIMARY]
--GO


--USE [ManSysDB]
--GO

--/****** Object:  StoredProcedure [dbo].[SP_AddBook]    Script Date: 10/20/2023 3:44:01 PM ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

--create procedure [dbo].[SP_Insert_Mantenimiento_de_Empleados]
--	@Nombre varchar(50) null,
--	@Apellido varchar(50) null,
--	@Direccion varchar(100) null,
--	@Telefono varchar(50) null,
--	@Fecha_de_Ingreso varchar(50) null,
--	@Puesto_Ocupado varchar(50) null,
--	@Departamento varchar(50) null,
--	@CEDULA varchar(50) null,
--	@Salario_Base varchar(100) null,
--	@Tipo_de_Cobro varchar(50) null,
--	@Turno varchar(50) null

--as begin
--	insert into [dbo].[Empleados]
--	 (
--		Nombre, Apellido, Direccion, Telefono, Fecha_de_Ingreso, Puesto_Ocupado, Departamento, CEDULA, Salario_Base, Tipo_de_Cobro, Turno
--	 )values(
--	@Nombre ,
--	@Apellido ,
--	@Direccion,
--	@Telefono ,
--	@Fecha_de_Ingreso ,
--	@Puesto_Ocupado ,
--	@Departamento ,
--	@CEDULA ,
--	@Salario_Base,
--	@Tipo_de_Cobro,
--	@Turno 
--	 )
--	 end

--GO


--USE [ManSysDB]
--GO

--/****** Object:  StoredProcedure [dbo].[SP_Verificar]    Script Date: 10/20/2023 6:02:39 PM ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

----SELECT * FROM [dbo].[Empleados]

--create procedure [dbo].[SP_Verificar]
--	@Nombre varchar(50),
--	@Apellido varchar(50),
--	@CEDULA varchar(50)
--as
--select * from [dbo].[Empleados]  where Nombre = @Nombre  AND Apellido = @Apellido OR CEDULA = @CEDULA
--GO

--select * from dbo.Empleados

--create procedure SP_Update_Mantenimiento_de_Empleados
--	@Id int,
--	@Nombre varchar(50) null,
--	@Apellido varchar(50) null,
--	@Direccion varchar(100) null,
--	@Telefono varchar(50) null,
--	@Fecha_de_Ingreso varchar(50) null,
--	@Puesto_Ocupado varchar(50) null,
--	@Departamento varchar(50) null,
--	@CEDULA varchar(50) null,
--	@Salario_Base varchar(100) null,
--	@Tipo_de_Cobro varchar(50) null,
--	@Turno varchar(50) null

--as begin 
--UPDATE [dbo].[Empleados]
--SET Nombre = @Nombre,
--	Apellido = @Apellido,
--	Direccion = @Direccion,
--	Telefono = @Telefono,
--	Fecha_de_Ingreso = @Fecha_de_Ingreso,
--	Puesto_Ocupado = @Puesto_Ocupado,
--	Departamento = @Departamento,
--	CEDULA = @CEDULA,
--	Salario_Base = @Salario_Base ,
--	Tipo_de_Cobro = @Tipo_de_Cobro, 
--	Turno = @Turno
--WHERE Id = @Id;
--end

--create procedure GetDB_Mantenimiento_de_Empleados
--as
--begin
--select * from dbo.Empleados
--end
 
/*
	Corrige el sueldo base y los lleva al siguiente salario base 
	Agente = 50000
	Supervisor = 75000
	Calidad = 80000
	Manager = 100000
*/
--update dbo.Empleados
--set Salario_Base = 100000
--where Puesto_Ocupado = 'Manager'
--update dbo.Empleados
--set Salario_Base = 80000
--where Puesto_Ocupado = 'Calidad'
--update dbo.Empleados
--set Salario_Base = 75000
--where Puesto_Ocupado = 'Supervisor'
--update dbo.Empleados
--set Salario_Base = 50000
--where Puesto_Ocupado = 'Agente'
--select * from dbo.Empleados
