USE [master]
GO
/****** Object:  Database [QUETZAL]    Script Date: 06/23/2015 20:11:46 ******/
CREATE DATABASE [QUETZAL] ON  PRIMARY 
( NAME = N'QUETZAL', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QUETZAL.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUETZAL_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QUETZAL_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUETZAL] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUETZAL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUETZAL] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QUETZAL] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QUETZAL] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QUETZAL] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QUETZAL] SET ARITHABORT OFF
GO
ALTER DATABASE [QUETZAL] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QUETZAL] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QUETZAL] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QUETZAL] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QUETZAL] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QUETZAL] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QUETZAL] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QUETZAL] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QUETZAL] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QUETZAL] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QUETZAL] SET  ENABLE_BROKER
GO
ALTER DATABASE [QUETZAL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QUETZAL] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QUETZAL] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QUETZAL] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QUETZAL] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QUETZAL] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QUETZAL] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QUETZAL] SET  READ_WRITE
GO
ALTER DATABASE [QUETZAL] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QUETZAL] SET  MULTI_USER
GO
ALTER DATABASE [QUETZAL] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QUETZAL] SET DB_CHAINING OFF
GO
USE [QUETZAL]
GO
/****** Object:  Table [dbo].[sucursal]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sucursal](
	[cod_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
	[telefono] [varchar](15) NOT NULL,
	[direccion] [varchar](15) NOT NULL,
	[capacidad] [int] NOT NULL,
	[cod_sede] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_sucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sede]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sede](
	[cod_sede] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_sede] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[cod_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
	[apellido] [varchar](15) NOT NULL,
	[telefono] [varchar](15) NOT NULL,
	[direccion] [varchar](15) NOT NULL,
	[tarjeta] [varchar](15) NOT NULL,
	[estado] [int] NOT NULL,
	[usuario] [varchar](15) NOT NULL,
	[contraseña] [varchar](15) NOT NULL,
	[nit] [int] NULL,
	[sucursal] [int] NULL,
 CONSTRAINT [PK__cliente__08ED61F307020F21] PRIMARY KEY CLUSTERED 
(
	[cod_cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[cod_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[porcentaje] [int] NOT NULL,
 CONSTRAINT [PK__categori__F052220725869641] PRIMARY KEY CLUSTERED 
(
	[cod_categoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[cod_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
	[apellido] [varchar](15) NOT NULL,
	[telefono] [varchar](15) NOT NULL,
	[direccion] [varchar](15) NOT NULL,
	[sueldo] [smallmoney] NOT NULL,
	[usuario] [varchar](15) NOT NULL,
	[contraseña] [varchar](15) NOT NULL,
	[puesto] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_empleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[depto]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[depto](
	[cod_depto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
 CONSTRAINT [PK__depto__529EC620164452B1] PRIMARY KEY CLUSTERED 
(
	[cod_depto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[aduana]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aduana](
	[cod_aduana] [int] IDENTITY(1,1) NOT NULL,
	[porcentaje] [int] NOT NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_aduana] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ganancia]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ganancia](
	[cod_ganancia] [int] IDENTITY(1,1) NOT NULL,
	[porcentaje] [int] NOT NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_ganancia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lote]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lote](
	[llave] [int] IDENTITY(1,1) NOT NULL,
	[cod_lote] [int] NOT NULL,
	[cod_sucursal] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK__lote__B8B4879F7F60ED59] PRIMARY KEY CLUSTERED 
(
	[llave] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contrato]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contrato](
	[cod_contrato] [int] IDENTITY(1,1) NOT NULL,
	[cod_sucursal] [int] NOT NULL,
	[cod_empleado] [int] NOT NULL,
	[cod_jefe] [int] NOT NULL,
	[cod_depto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_contrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[casilla]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[casilla](
	[cod_casilla] [int] IDENTITY(1,1) NOT NULL,
	[cod_cliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_casilla] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pedido](
	[cod_pedido] [int] IDENTITY(1,1) NOT NULL,
	[cod_casilla] [int] NULL,
	[cod_lote] [int] NULL,
	[fecha] [date] NULL,
	[cod_sucursal] [int] NULL,
	[estado] [varchar](25) NULL,
	[busqueda] [int] NULL,
 CONSTRAINT [PK__pedido__3392C4931DE57479] PRIMARY KEY CLUSTERED 
(
	[cod_pedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[factura]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[cod_factura] [int] IDENTITY(1,1) NOT NULL,
	[cod_pedido] [int] NOT NULL,
	[cod_empleado] [int] NOT NULL,
	[cod_ganancia] [int] NOT NULL,
	[cod_aduana] [int] NOT NULL,
	[total] [smallmoney] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paquete]    Script Date: 06/23/2015 20:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[paquete](
	[cod_paquete] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
	[peso] [int] NOT NULL,
	[precio] [smallmoney] NOT NULL,
	[cod_categoria] [int] NOT NULL,
	[cod_pedido] [int] NULL,
	[envio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_paquete] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [fk_cod_sucursal2]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[lote]  WITH CHECK ADD  CONSTRAINT [fk_cod_sucursal2] FOREIGN KEY([cod_sucursal])
REFERENCES [dbo].[sucursal] ([cod_sucursal])
GO
ALTER TABLE [dbo].[lote] CHECK CONSTRAINT [fk_cod_sucursal2]
GO
/****** Object:  ForeignKey [fk_cod_depto]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[contrato]  WITH CHECK ADD  CONSTRAINT [fk_cod_depto] FOREIGN KEY([cod_depto])
REFERENCES [dbo].[depto] ([cod_depto])
GO
ALTER TABLE [dbo].[contrato] CHECK CONSTRAINT [fk_cod_depto]
GO
/****** Object:  ForeignKey [fk_cod_empleados]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[contrato]  WITH CHECK ADD  CONSTRAINT [fk_cod_empleados] FOREIGN KEY([cod_empleado])
REFERENCES [dbo].[empleado] ([cod_empleado])
GO
ALTER TABLE [dbo].[contrato] CHECK CONSTRAINT [fk_cod_empleados]
GO
/****** Object:  ForeignKey [fk_cod_jefe]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[contrato]  WITH CHECK ADD  CONSTRAINT [fk_cod_jefe] FOREIGN KEY([cod_jefe])
REFERENCES [dbo].[empleado] ([cod_empleado])
GO
ALTER TABLE [dbo].[contrato] CHECK CONSTRAINT [fk_cod_jefe]
GO
/****** Object:  ForeignKey [fk_cod_sucursal]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[contrato]  WITH CHECK ADD  CONSTRAINT [fk_cod_sucursal] FOREIGN KEY([cod_sucursal])
REFERENCES [dbo].[sucursal] ([cod_sucursal])
GO
ALTER TABLE [dbo].[contrato] CHECK CONSTRAINT [fk_cod_sucursal]
GO
/****** Object:  ForeignKey [fk_cod_cliente]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[casilla]  WITH CHECK ADD  CONSTRAINT [fk_cod_cliente] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[cliente] ([cod_cliente])
GO
ALTER TABLE [dbo].[casilla] CHECK CONSTRAINT [fk_cod_cliente]
GO
/****** Object:  ForeignKey [fk_cod_casilla]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [fk_cod_casilla] FOREIGN KEY([cod_casilla])
REFERENCES [dbo].[cliente] ([cod_cliente])
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [fk_cod_casilla]
GO
/****** Object:  ForeignKey [fk_cod_lote]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [fk_cod_lote] FOREIGN KEY([cod_lote])
REFERENCES [dbo].[lote] ([llave])
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [fk_cod_lote]
GO
/****** Object:  ForeignKey [fk_cod_aduana]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [fk_cod_aduana] FOREIGN KEY([cod_aduana])
REFERENCES [dbo].[aduana] ([cod_aduana])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [fk_cod_aduana]
GO
/****** Object:  ForeignKey [fk_cod_empleado]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [fk_cod_empleado] FOREIGN KEY([cod_empleado])
REFERENCES [dbo].[empleado] ([cod_empleado])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [fk_cod_empleado]
GO
/****** Object:  ForeignKey [fk_cod_ganancia]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [fk_cod_ganancia] FOREIGN KEY([cod_ganancia])
REFERENCES [dbo].[ganancia] ([cod_ganancia])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [fk_cod_ganancia]
GO
/****** Object:  ForeignKey [fk_cod_pedido]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [fk_cod_pedido] FOREIGN KEY([cod_pedido])
REFERENCES [dbo].[pedido] ([cod_pedido])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [fk_cod_pedido]
GO
/****** Object:  ForeignKey [fk_cod_categoria]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[paquete]  WITH CHECK ADD  CONSTRAINT [fk_cod_categoria] FOREIGN KEY([cod_categoria])
REFERENCES [dbo].[categoria] ([cod_categoria])
GO
ALTER TABLE [dbo].[paquete] CHECK CONSTRAINT [fk_cod_categoria]
GO
/****** Object:  ForeignKey [fk_cod_pedido2]    Script Date: 06/23/2015 20:11:47 ******/
ALTER TABLE [dbo].[paquete]  WITH CHECK ADD  CONSTRAINT [fk_cod_pedido2] FOREIGN KEY([cod_pedido])
REFERENCES [dbo].[pedido] ([cod_pedido])
GO
ALTER TABLE [dbo].[paquete] CHECK CONSTRAINT [fk_cod_pedido2]
GO
