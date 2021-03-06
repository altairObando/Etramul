USE [master]
GO
/****** Object:  Database [Etramulv2]    Script Date: 09/01/2018 06:06:49 p.m. ******/
CREATE DATABASE [Etramulv2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Etramulv2', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Etramulv2.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Etramulv2_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Etramulv2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Etramulv2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Etramulv2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Etramulv2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Etramulv2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Etramulv2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Etramulv2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Etramulv2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Etramulv2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Etramulv2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Etramulv2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Etramulv2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Etramulv2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Etramulv2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Etramulv2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Etramulv2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Etramulv2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Etramulv2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Etramulv2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Etramulv2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Etramulv2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Etramulv2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Etramulv2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Etramulv2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Etramulv2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Etramulv2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Etramulv2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Etramulv2] SET  MULTI_USER 
GO
ALTER DATABASE [Etramulv2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Etramulv2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Etramulv2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Etramulv2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Etramulv2]
GO
/****** Object:  User [altair]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE USER [altair] FOR LOGIN [altair] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [altair]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [altair]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [altair]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [altair]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [altair]
GO
ALTER ROLE [db_datareader] ADD MEMBER [altair]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [altair]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [altair]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [altair]
GO
/****** Object:  StoredProcedure [dbo].[CarrerasEntreFechas]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CarrerasEntreFechas]
(
	@Inicio datetime,
	@Fin datetime
)
AS
	SET NOCOUNT ON;
SELECT DISTINCT 
                         a.Id_carrera, a.No_transaccion, RTRIM(g.Nombres) + SPACE(2) + LTRIM(g.Apellidos) AS Conductor, e.Placa, a.HoraSalida, a.HoraLlegada, a.FechaCarrera, 
                         c.Cantidad AS Ingreso, a.Vuelta_Completa AS Completa
FROM            CarreraSet AS a INNER JOIN
                         TransaccionSet AS b ON a.No_transaccion = b.IdTransaccion INNER JOIN
                         DetalleSet AS c ON b.IdTransaccion = c.IdTransaccion INNER JOIN
                         TipoDetalleSet AS d ON c.TipoDetalle = d.IdTipoDetalle INNER JOIN
                         VehiculoSet AS e ON a.Id_vehiculo = e.Id_Vehiculo INNER JOIN
                         PersonasSet AS g ON a.Id_conductor = g.Id_persona
WHERE        (c.TipoTransaccion = 1) AND (a.FechaCarrera BETWEEN @Inicio AND @Fin + 1)
GO
/****** Object:  StoredProcedure [dbo].[carrerasPorDia]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[carrerasPorDia]
(
	@Fecha datetime,
	@Placa nvarchar(MAX)
)
AS
	SET NOCOUNT ON;
SELECT        a.Placa, b.FechaCarrera, c.FechaTransaccion, d.Descripcion, d.Cantidad
FROM            TransaccionSet AS c INNER JOIN
                         CarreraSet AS b ON c.IdTransaccion = b.No_transaccion INNER JOIN
                         VehiculoSet AS a ON b.Id_vehiculo = a.Id_Vehiculo INNER JOIN
                         DetalleSet AS d ON c.IdTransaccion = d.IdTransaccion
WHERE        (d.TipoTransaccion = 1) AND (c.FechaTransaccion = @Fecha) AND (a.Placa = @Placa)
GO
/****** Object:  StoredProcedure [dbo].[Conductores_Activos]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Conductores_Activos]
AS
	SET NOCOUNT ON;
SELECT        PersonasSet.Nombres, PersonasSet.Apellidos, PersonasSet.Telefono, ConductorSet.Licencia
FROM            PersonasSet INNER JOIN
                         ConductorSet ON PersonasSet.Id_persona = ConductorSet.Id_conductor
WHERE        (PersonasSet.Activo = 1)



GO
/****** Object:  StoredProcedure [dbo].[DetalleDeTransaccion]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DetalleDeTransaccion]
(
	@codigo int
)
AS
	SET NOCOUNT ON;
SELECT        DetalleSet.IdTransaccion, Transaccion = CASE TipoTransaccion WHEN 1 THEN 'Ingreso' ELSE 'Egreso' END, TipoDetalleSet.Descripcion, DetalleSet.Descripcion AS Detalle, DetalleSet.Cantidad
FROM            DetalleSet INNER JOIN
                         TipoDetalleSet ON DetalleSet.TipoDetalle = TipoDetalleSet.IdTipoDetalle
WHERE        (DetalleSet.IdTransaccion = @codigo)

GO
/****** Object:  StoredProcedure [dbo].[Egresos_Dia]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Egresos_Dia]
(
	@id_vehiculo int,
	@fecha datetime
)
AS
	SET NOCOUNT ON;
SELECT  a.Id_Vehiculo, a.IdTransaccion as 'No Factura',a.FechaTransaccion ,b.TipoDetalle as 'Codigo', c.Descripcion, b.Cantidad
FROM TransaccionSet as a, DetalleSet as b, TipoDetalleSet as c
WHERE Id_Vehiculo = @id_vehiculo AND FechaTransaccion = @fecha
AND a.IdTransaccion = b.IdTransaccion AND b.Activo = 1 AND b.TipoTransaccion = 0
AND b.TipoDetalle = c.IdTipoDetalle
GO
/****** Object:  StoredProcedure [dbo].[EgresosDetallePorRubro]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		NOEL OBANDO
-- Create date: 01/01/2018
-- Description:	OBTENER EL DETALLE DE LOS EGRESOS POR UN RUBRO EN ESPECIFICO
-- =============================================
CREATE PROCEDURE [dbo].[EgresosDetallePorRubro] 
	@id_rubro int,
	@id_vehiculo int,
	@fecha datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.IdTransaccion,a.FechaTransaccion, a.Activo, b.Placa, c.Cantidad, d.Descripcion
	FROM TransaccionSet as a, VehiculoSet as b, DetalleSet as c, TipoDetalleSet as d
	WHERE a.IdTransaccion = c.IdTransaccion AND a.Id_Vehiculo = b.Id_Vehiculo AND c.TipoDetalle = d.IdTipoDetalle
	AND b.Id_Vehiculo = @id_vehiculo AND a.Activo = 1
	AND c.TipoTransaccion = 0 AND d.IdTipoDetalle = @id_rubro AND a.FechaTransaccion = @fecha
END

GO
/****** Object:  StoredProcedure [dbo].[EgresosDetallePorRubroEntreFechas]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		NOEL OBANDO
-- Create date: 01/01/2018
-- Description:	OBTENER EL DETALLE DE LOS EGRESOS POR UN RUBRO EN ESPECIFICO
-- UTILIZANDO UN FILTRO ENTRE FECHAS
-- =============================================
CREATE PROCEDURE [dbo].[EgresosDetallePorRubroEntreFechas] 
	@id_rubro int,
	@id_vehiculo int,
	@fecha1 datetime,
	@fecha2 datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.IdTransaccion,a.FechaTransaccion, a.Activo, b.Placa, c.Cantidad, d.Descripcion
	FROM TransaccionSet as a, VehiculoSet as b, DetalleSet as c, TipoDetalleSet as d
	WHERE a.IdTransaccion = c.IdTransaccion AND a.Id_Vehiculo = b.Id_Vehiculo AND c.TipoDetalle = d.IdTipoDetalle
	AND b.Id_Vehiculo = @id_vehiculo AND a.Activo = 1
	AND c.TipoTransaccion = 0 AND d.IdTipoDetalle = @id_rubro AND a.FechaTransaccion BETWEEN @fecha1 AND @fecha2+1
END

GO
/****** Object:  StoredProcedure [dbo].[GastosPorRubroEntreFechas]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<yo,,mismo>
-- Create date: <29/12/2017,,>
-- Description:	<Consulta,,>
-- =============================================
CREATE PROCEDURE [dbo].[GastosPorRubroEntreFechas]
	-- Add the parameters for the stored procedure here
	@Tipo int,
	@Fecha1 DateTime,
	@Fecha2 DateTime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.Placa, b.IdTipoDetalle, b.Descripcion, SUM(a.Cantidad) as Monto
FROM DetalleSet as a, TipoDetalleSet as b, VehiculoSet as c, TransaccionSet as d
WHERE a.TipoTransaccion = 0
-- Uniendo tablas :v
AND a.TipoDetalle = b.IdTipoDetalle
AND c.Id_Vehiculo = d.Id_Vehiculo
AND d.IdTransaccion = a.IdTransaccion
AND a.Activo = 1 /* Si no esta anulada */
/* Parametro de busqueda */
AND b.IdTipoDetalle = @Tipo
AND d.FechaTransaccion BETWEEN @Fecha1 AND @Fecha2 +1
GROUP BY b.IdTipoDetalle, c.Placa, b.Descripcion
END

GO
/****** Object:  StoredProcedure [dbo].[GastosPorRubroPorDia]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosPorRubroPorDia]
(
	@tipo int,
	@Fecha datetime
)
AS
	SET NOCOUNT ON;
SELECT        c.Placa, b.IdTipoDetalle, b.Descripcion, SUM(a.Cantidad) AS Monto
FROM            TransaccionSet AS d INNER JOIN
                         VehiculoSet AS c ON d.Id_Vehiculo = c.Id_Vehiculo INNER JOIN
                         DetalleSet AS a INNER JOIN
                         TipoDetalleSet AS b ON a.TipoDetalle = b.IdTipoDetalle ON d.IdTransaccion = a.IdTransaccion
WHERE        (a.TipoTransaccion = 0) AND (d.Activo = 1) AND (b.IdTipoDetalle = @tipo) AND (d.FechaTransaccion = @Fecha)
GROUP BY b.IdTipoDetalle, c.Placa, b.Descripcion
GO
/****** Object:  StoredProcedure [dbo].[ingreso_total_por_dia]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ingreso_total_por_dia]
(
	@fecha datetime
)
AS
	SET NOCOUNT ON;

SELECT a.Id_Vehiculo,a.Placa ,
SUM(CASE c.TipoTransaccion WHEN 1 THEN c.Cantidad END) as Ingreso, 
SUM(CASE c.TipoTransaccion WHEN 0 THEN c.Cantidad END) as Egreso 
FROM VehiculoSet as a, TransaccionSet as b, DetalleSet as c
WHERE a.Id_Vehiculo IN 
				(SELECT Id_Vehiculo from TransaccionSet WHERE TransaccionSet.Activo = 1)
AND b.FechaTransaccion = @fecha
AND b.Activo = 1 
AND a.Id_Vehiculo = b.Id_Vehiculo
AND b.IdTransaccion = c.IdTransaccion
AND c.Activo = 1
GROUP BY a.Id_Vehiculo, a.Placa
GO
/****** Object:  StoredProcedure [dbo].[Ingresos_Dia]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ingresos_Dia]
(
	@id_vehiculo int,
	@fecha datetime
)
AS
	SET NOCOUNT ON;
SELECT         a.IdTransaccion AS 'No Factura', b.TipoDetalle AS 'Codigo', c.Descripcion, b.Cantidad
FROM            TipoDetalleSet as c,TransaccionSet AS a INNER JOIN
                         DetalleSet AS b ON a.IdTransaccion = b.IdTransaccion
WHERE        (a.Id_Vehiculo = @id_vehiculo) AND (a.FechaTransaccion = @fecha) AND (b.Activo = 1) AND (b.TipoTransaccion = 1) AND (b.TipoDetalle = c.IdTipoDetalle)
GO
/****** Object:  StoredProcedure [dbo].[saldo_vehiculos]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[saldo_vehiculos]
AS
	SET NOCOUNT ON;
SELECT        VehiculoSet.Placa, VehiculoSet.Marca, VehiculoSet.Modelo, SaldoSet.Total_sado, SaldoSet.Ultima_transacion
FROM            VehiculoSet INNER JOIN
                         SaldoSet ON VehiculoSet.Id_Vehiculo = SaldoSet.Id_vehiculo
GO
/****** Object:  StoredProcedure [dbo].[ScalarQuery]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ScalarQuery]
AS
	SET NOCOUNT ON;
SELECT        PersonasSet.Nombres, PersonasSet.Apellidos, PersonasSet.Telefono, UsuariosSet.Nickname, UsuariosSet.Id_tipo
FROM            PersonasSet INNER JOIN
                         UsuariosSet ON PersonasSet.Id_persona = UsuariosSet.Id_usuario
WHERE        (PersonasSet.Activo = 1)


GO
/****** Object:  StoredProcedure [dbo].[SociosActivos]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SociosActivos]
AS
	SET NOCOUNT ON;
SELECT        PersonasSet.Nombres, PersonasSet.Apellidos, PersonasSet.Telefono, SocioSet.FechaAsociacion
FROM            PersonasSet INNER JOIN
                         SocioSet ON PersonasSet.Id_persona = SocioSet.Id_socio
WHERE        (PersonasSet.Activo = 1)


GO
/****** Object:  StoredProcedure [dbo].[TicketCarrera]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TicketCarrera]
(
	@Codigo int
)
AS
	SET NOCOUNT ON;
SELECT        CASE c.TipoTransaccion WHEN 1 THEN 'Ingreso' ELSE 'Egreso' END AS Tipo, c.Descripcion, c.Cantidad
FROM            CarreraSet AS a INNER JOIN
                         TransaccionSet AS b ON a.No_transaccion = b.IdTransaccion INNER JOIN
                         DetalleSet AS c ON b.IdTransaccion = c.IdTransaccion INNER JOIN
                         TipoDetalleSet AS d ON c.TipoDetalle = d.IdTipoDetalle
WHERE        (c.TipoTransaccion = 0) AND (a.Id_carrera = @Codigo)
GO
/****** Object:  StoredProcedure [dbo].[Total_entre_fechas]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Noel Obando
-- Create date: 04/01/2018
-- Description:	Permite obtener todo los ingresos generados por los vehiculos entre fechas
-- =============================================
CREATE PROCEDURE [dbo].[Total_entre_fechas] 
	-- Add the parameters for the stored procedure here
	@FechaInicio datetime = NULL, 
	@FechaFin datetime = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT a.Id_Vehiculo,a.Placa ,
	SUM(CASE c.TipoTransaccion WHEN 1 THEN c.Cantidad END) as Ingreso, 
	SUM(CASE c.TipoTransaccion WHEN 0 THEN c.Cantidad END) as Egreso 
	FROM VehiculoSet as a, TransaccionSet as b, DetalleSet as c
	WHERE a.Id_Vehiculo IN 
					(SELECT Id_Vehiculo from TransaccionSet WHERE TransaccionSet.Activo = 1)
	AND b.FechaTransaccion BETWEEN @FechaInicio AND @FechaFin + 1
	AND b.Activo = 1 
	AND a.Id_Vehiculo = b.Id_Vehiculo
	AND b.IdTransaccion = c.IdTransaccion
	AND c.Activo = 1
	GROUP BY a.Id_Vehiculo, a.Placa
END

GO
/****** Object:  StoredProcedure [dbo].[VehiculosActivos]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[VehiculosActivos]
AS
	SET NOCOUNT ON;
SELECT        Placa, Marca, Modelo
FROM            VehiculoSet
WHERE        (Activo = 1)

GO
/****** Object:  StoredProcedure [dbo].[verEntreFechas]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Noel Obando
-- Create date: 04/01/2018
-- Description:	Permite obtener los ingresos y egresos generados en un dia
-- =============================================
CREATE PROCEDURE [dbo].[verEntreFechas] 
	-- Add the parameters for the stored procedure here
	@FechaInicio datetime, 
	@FechaFin datetime,
	@id_vehiculo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT b.IdTransaccion as Factura,b.FechaTransaccion as Fecha ,d.Descripcion,
	case c.TipoTransaccion WHEN 1 THEN c.Cantidad ELSE 0 END as Ingreso,
	case c.TipoTransaccion WHEN 0 THEN c.Cantidad ELSE 0 END as Egreso
	FROM VehiculoSet as a, TransaccionSet as b, DetalleSet as c, TipoDetalleSet as d
	WHERE a.Id_Vehiculo = b.Id_Vehiculo AND b.IdTransaccion = c.IdTransaccion AND d.IdTipoDetalle = c.TipoDetalle
	/* Filtrando por Fecha */
	AND b.FechaTransaccion BETWEEN @FechaInicio AND @FechaFin
	AND a.Id_Vehiculo = @id_vehiculo
	ORDER BY b.IdTransaccion
END

GO
/****** Object:  Table [dbo].[CarreraSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarreraSet](
	[Id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[Id_conductor] [int] NOT NULL,
	[Id_vehiculo] [int] NOT NULL,
	[No_transaccion] [int] NOT NULL,
	[HoraSalida] [time](7) NOT NULL,
	[HoraLlegada] [time](7) NOT NULL,
	[FechaCarrera] [datetime] NOT NULL,
	[Vuelta_Completa] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_CarreraSet] PRIMARY KEY CLUSTERED 
(
	[Id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ConductorSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConductorSet](
	[Id_conductor] [int] NOT NULL,
	[Licencia] [nvarchar](max) NOT NULL,
	[Personas_Id_persona] [int] NOT NULL,
 CONSTRAINT [PK_ConductorSet] PRIMARY KEY CLUSTERED 
(
	[Id_conductor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleSet](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdTransaccion] [int] NOT NULL,
	[TipoDetalle] [int] NOT NULL,
	[TipoTransaccion] [bit] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Cantidad] [decimal](18, 0) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_DetalleSet] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonasSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonasSet](
	[Id_persona] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [nvarchar](max) NOT NULL,
	[Nombres] [nvarchar](max) NOT NULL,
	[Apellidos] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Correo] [nvarchar](max) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_PersonasSet] PRIMARY KEY CLUSTERED 
(
	[Id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaldoSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaldoSet](
	[Id_saldo] [int] IDENTITY(1,1) NOT NULL,
	[Id_vehiculo] [int] NULL,
	[Total_sado] [float] NULL,
	[Ultima_transacion] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SocioSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocioSet](
	[Id_socio] [int] NOT NULL,
	[FechaAsociacion] [datetime] NOT NULL,
	[Personas_Id_persona] [int] NOT NULL,
 CONSTRAINT [PK_SocioSet] PRIMARY KEY CLUSTERED 
(
	[Id_socio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoDetalleSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDetalleSet](
	[IdTipoDetalle] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_TipoDetalleSet] PRIMARY KEY CLUSTERED 
(
	[IdTipoDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoUsuarioSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoUsuarioSet](
	[Id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TipoUsuarioSet] PRIMARY KEY CLUSTERED 
(
	[Id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TransaccionSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransaccionSet](
	[IdTransaccion] [int] IDENTITY(1,1) NOT NULL,
	[Id_usuario] [int] NOT NULL,
	[Id_Vehiculo] [int] NOT NULL,
	[FechaTransaccion] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_TransaccionSet] PRIMARY KEY CLUSTERED 
(
	[IdTransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuariosSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosSet](
	[Id_usuario] [int] NOT NULL,
	[Nickname] [nvarchar](max) NOT NULL,
	[Clave] [nvarchar](max) NOT NULL,
	[Id_tipo] [int] NOT NULL,
	[Personas_Id_persona] [int] NOT NULL,
 CONSTRAINT [PK_UsuariosSet] PRIMARY KEY CLUSTERED 
(
	[Id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VehiculoSet]    Script Date: 09/01/2018 06:06:51 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehiculoSet](
	[Id_Vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [nvarchar](max) NOT NULL,
	[Marca] [nvarchar](max) NOT NULL,
	[Modelo] [nvarchar](max) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Id_socio] [int] NOT NULL,
 CONSTRAINT [PK_VehiculoSet] PRIMARY KEY CLUSTERED 
(
	[Id_Vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_FK_VehiculoCarrera]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_VehiculoCarrera] ON [dbo].[CarreraSet]
(
	[Id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PersonasConductor]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_PersonasConductor] ON [dbo].[ConductorSet]
(
	[Personas_Id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_TipoEgresoEgreso]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_TipoEgresoEgreso] ON [dbo].[DetalleSet]
(
	[TipoDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_TransaccionEgreso]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_TransaccionEgreso] ON [dbo].[DetalleSet]
(
	[IdTransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PersonasSocio]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_PersonasSocio] ON [dbo].[SocioSet]
(
	[Personas_Id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_VehiculoTransaccion]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_VehiculoTransaccion] ON [dbo].[TransaccionSet]
(
	[Id_Vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PersonasUsuarios]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_PersonasUsuarios] ON [dbo].[UsuariosSet]
(
	[Personas_Id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_TipoUsuarioUsuarios]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_TipoUsuarioUsuarios] ON [dbo].[UsuariosSet]
(
	[Id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_SocioVehiculo]    Script Date: 09/01/2018 06:06:51 p.m. ******/
CREATE NONCLUSTERED INDEX [IX_FK_SocioVehiculo] ON [dbo].[VehiculoSet]
(
	[Id_socio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CarreraSet]  WITH CHECK ADD  CONSTRAINT [FK_VehiculoCarrera] FOREIGN KEY([Id_vehiculo])
REFERENCES [dbo].[VehiculoSet] ([Id_Vehiculo])
GO
ALTER TABLE [dbo].[CarreraSet] CHECK CONSTRAINT [FK_VehiculoCarrera]
GO
ALTER TABLE [dbo].[ConductorSet]  WITH CHECK ADD  CONSTRAINT [FK_PersonasConductor] FOREIGN KEY([Personas_Id_persona])
REFERENCES [dbo].[PersonasSet] ([Id_persona])
GO
ALTER TABLE [dbo].[ConductorSet] CHECK CONSTRAINT [FK_PersonasConductor]
GO
ALTER TABLE [dbo].[DetalleSet]  WITH CHECK ADD  CONSTRAINT [FK_TipoEgresoEgreso] FOREIGN KEY([TipoDetalle])
REFERENCES [dbo].[TipoDetalleSet] ([IdTipoDetalle])
GO
ALTER TABLE [dbo].[DetalleSet] CHECK CONSTRAINT [FK_TipoEgresoEgreso]
GO
ALTER TABLE [dbo].[DetalleSet]  WITH CHECK ADD  CONSTRAINT [FK_TransaccionEgreso] FOREIGN KEY([IdTransaccion])
REFERENCES [dbo].[TransaccionSet] ([IdTransaccion])
GO
ALTER TABLE [dbo].[DetalleSet] CHECK CONSTRAINT [FK_TransaccionEgreso]
GO
ALTER TABLE [dbo].[SocioSet]  WITH CHECK ADD  CONSTRAINT [FK_PersonasSocio] FOREIGN KEY([Personas_Id_persona])
REFERENCES [dbo].[PersonasSet] ([Id_persona])
GO
ALTER TABLE [dbo].[SocioSet] CHECK CONSTRAINT [FK_PersonasSocio]
GO
ALTER TABLE [dbo].[TransaccionSet]  WITH CHECK ADD  CONSTRAINT [FK_VehiculoTransaccion] FOREIGN KEY([Id_Vehiculo])
REFERENCES [dbo].[VehiculoSet] ([Id_Vehiculo])
GO
ALTER TABLE [dbo].[TransaccionSet] CHECK CONSTRAINT [FK_VehiculoTransaccion]
GO
ALTER TABLE [dbo].[UsuariosSet]  WITH CHECK ADD  CONSTRAINT [FK_PersonasUsuarios] FOREIGN KEY([Personas_Id_persona])
REFERENCES [dbo].[PersonasSet] ([Id_persona])
GO
ALTER TABLE [dbo].[UsuariosSet] CHECK CONSTRAINT [FK_PersonasUsuarios]
GO
ALTER TABLE [dbo].[UsuariosSet]  WITH CHECK ADD  CONSTRAINT [FK_TipoUsuarioUsuarios] FOREIGN KEY([Id_tipo])
REFERENCES [dbo].[TipoUsuarioSet] ([Id_tipo])
GO
ALTER TABLE [dbo].[UsuariosSet] CHECK CONSTRAINT [FK_TipoUsuarioUsuarios]
GO
ALTER TABLE [dbo].[VehiculoSet]  WITH CHECK ADD  CONSTRAINT [FK_SocioVehiculo] FOREIGN KEY([Id_socio])
REFERENCES [dbo].[SocioSet] ([Id_socio])
GO
ALTER TABLE [dbo].[VehiculoSet] CHECK CONSTRAINT [FK_SocioVehiculo]
GO
USE [master]
GO
ALTER DATABASE [Etramulv2] SET  READ_WRITE 
GO
