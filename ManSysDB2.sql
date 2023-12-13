create database ManSysDB





USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Gestion_de_Usuarios]    Script Date: 12/7/2023 3:47:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Gestion_de_Usuarios](
	[EmpleadoId] [int] NOT NULL,
	[Empleado] [varchar](100) NOT NULL,
	[Contra] [varchar](50) NOT NULL
) ON [PRIMARY]
GO



USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Impuestos]    Script Date: 12/7/2023 3:47:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Impuestos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Porcentage] [float] NOT NULL,
 CONSTRAINT [PK_Impuesto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Incidencias]    Script Date: 12/7/2023 3:47:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Incidencias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Duracion] [varchar](50) NOT NULL,
	[Observacion] [varchar](50) NOT NULL,
	[EmpleadoID] [int] NOT NULL,
	[Nombre_de_Empleado] [varchar](100) NOT NULL,
	[Posicion] [varchar](50) NOT NULL,
	[Departamento] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Posiciones]    Script Date: 12/7/2023 3:47:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posiciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Posiciones] PRIMARY KEY CLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Gestion_de_Jornada]    Script Date: 12/7/2023 3:47:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Gestion_de_Jornada](
	[EmpleadoId] [int] NOT NULL,
	[Empleado] [varchar](100) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[Entrada] [varchar](50) NOT NULL,
	[Salida] [varchar](50) NOT NULL,
	[HorasTrabajadas] [float] NOT NULL
) ON [PRIMARY]
GO


USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Gestion_de_Empresas]    Script Date: 12/7/2023 3:46:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Gestion_de_Empresas](
	[Nombre] [varchar](50) NOT NULL,
	[RNC] [varchar](50) NOT NULL,
	[Sector_de_Empresa] [varchar](50) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Pais] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Gestion_de_Empresas] PRIMARY KEY CLUSTERED 
(
	[RNC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Empleados]    Script Date: 12/7/2023 3:46:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Empleados](
	[Id] [int] IDENTITY(1000,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [varchar](50) NULL,
	[Fecha_de_Ingreso] [varchar](50) NULL,
	[Puesto_Ocupado] [varchar](50) NULL,
	[Departamento] [varchar](50) NULL,
	[CEDULA] [varchar](50) NULL,
	[Salario_Base] [varchar](100) NULL,
	[Tipo_de_Cobro] [varchar](50) NULL,
	[Turno] [varchar](50) NULL
) ON [PRIMARY]
GO


USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Departamentos]    Script Date: 12/7/2023 3:46:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Departamentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Deducciones]    Script Date: 12/7/2023 3:46:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Deducciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Cantidad] [float] NOT NULL
) ON [PRIMARY]
GO


USE [ManSysDB]
GO

/****** Object:  Table [dbo].[Bonificaciones]    Script Date: 12/7/2023 3:46:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bonificaciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoId] [int] NOT NULL,
	[Empleado] [varchar](100) NOT NULL,
	[Tipo_de_Bonificacion] [varchar](50) NOT NULL,
	[Monto] [float] NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[Fecha_de_Applicacion] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

USE [ManSysDB]
GO

/****** Object:  StoredProcedure [dbo].[GetDB_Mantenimiento_de_Empleados]    Script Date: 12/7/2023 4:23:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[GetDB_Mantenimiento_de_Empleados]
as
begin
select * from dbo.Empleados
end

GO




USE [ManSysDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_Insert_Mantenimiento_de_Empleados]    Script Date: 12/7/2023 4:23:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[SP_Insert_Mantenimiento_de_Empleados]
	@Nombre varchar(50) null,
	@Apellido varchar(50) null,
	@Direccion varchar(100) null,
	@Telefono varchar(50) null,
	@Fecha_de_Ingreso varchar(50) null,
	@Puesto_Ocupado varchar(50) null,
	@Departamento varchar(50) null,
	@CEDULA varchar(50) null,
	@Salario_Base varchar(100) null,
	@Tipo_de_Cobro varchar(50) null,
	@Turno varchar(50) null

as begin
	insert into [dbo].[Empleados]
	 (
		Nombre, Apellido, Direccion, Telefono, Fecha_de_Ingreso, Puesto_Ocupado, Departamento, CEDULA, Salario_Base, Tipo_de_Cobro, Turno
	 )values(
	@Nombre ,
	@Apellido ,
	@Direccion,
	@Telefono ,
	@Fecha_de_Ingreso ,
	@Puesto_Ocupado ,
	@Departamento ,
	@CEDULA ,
	@Salario_Base,
	@Tipo_de_Cobro,
	@Turno 
	 )
	 end


GO





USE [ManSysDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_Update_Mantenimiento_de_Empleados]    Script Date: 12/7/2023 4:23:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Update_Mantenimiento_de_Empleados]
	@Id int,
	@Nombre varchar(50) null,
	@Apellido varchar(50) null,
	@Direccion varchar(100) null,
	@Telefono varchar(50) null,
	@Fecha_de_Ingreso varchar(50) null,
	@Puesto_Ocupado varchar(50) null,
	@Departamento varchar(50) null,
	@CEDULA varchar(50) null,
	@Salario_Base varchar(100) null,
	@Tipo_de_Cobro varchar(50) null,
	@Turno varchar(50) null
as begin 
UPDATE [dbo].[Empleados]
SET Nombre = @Nombre,
	Apellido = @Apellido,
	Direccion = @Direccion,
	Telefono = @Telefono,
	Fecha_de_Ingreso = @Fecha_de_Ingreso,
	Puesto_Ocupado = @Puesto_Ocupado,
	Departamento = @Departamento,
	CEDULA = @CEDULA,
	Salario_Base = @Salario_Base ,
	Tipo_de_Cobro = @Tipo_de_Cobro, 
	Turno = @Turno
WHERE Id = @Id;
end
GO





USE [ManSysDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_Verificar]    Script Date: 12/7/2023 4:23:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


--SELECT * FROM [dbo].[Empleados]

create procedure [dbo].[SP_Verificar]
	@Nombre varchar(50),
	@Apellido varchar(50),
	@CEDULA varchar(50)
as
select * from [dbo].[Empleados]  where Nombre = @Nombre  AND Apellido = @Apellido OR CEDULA = @CEDULA

GO



