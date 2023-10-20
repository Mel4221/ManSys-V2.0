
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


