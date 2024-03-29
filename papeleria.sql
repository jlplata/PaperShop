USE [papeleria]
GO
/****** Object:  Table [dbo].[personas]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personas](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apepaterno] [nvarchar](50) NULL,
	[apematerno] [nvarchar](50) NULL,
	[domicilio] [nvarchar](50) NULL,
	[telefono] [nvarchar](50) NULL,
	[correo] [nvarchar](50) NULL,
	[sexo] [nvarchar](50) NULL,
	[fecha_nac] [date] NULL,
	[estado_civil] [nvarchar](50) NULL,
	[estados] [nvarchar](50) NULL,
	[municipio] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [int] NULL,
	[login] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[tipo] [nvarchar](50) NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_user] [int] NULL,
	[imagen] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaPersonas]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VistaPersonas] 
AS
SELECT p.id_persona, p.nombre, p.apepaterno, p.apematerno, p.domicilio, p.telefono, p.correo,
p.sexo, p.fecha_nac, p.estado_civil, p.estados, p.municipio, p.activo, p.fecha_registro, p.hora_registro,
(SELECT CONCAT(p.nombre, ' ', p.apepaterno, ' ', p.apematerno) as persona 
from personas as p where p.id_persona=u.id_persona) as Usuario
FROM personas as p
INNER JOIN usuarios as u
ON p.id_usuario=u.id_usuario
GO
/****** Object:  Table [dbo].[cajas]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cajas](
	[id_caja] [int] IDENTITY(1,1) NOT NULL,
	[numero_caja] [int] NULL,
	[id_sucursal] [int] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoria_productos]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria_productos](
	[id_categoria_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [nvarchar](50) NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [int] NULL,
	[numero_cliente] [int] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departamentos]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departamentos](
	[id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[nombre_departamento] [nvarchar](50) NULL,
	[extension] [int] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_entrada]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_entrada](
	[id_detalle_entrada] [int] IDENTITY(1,1) NOT NULL,
	[id_entrada] [int] NULL,
	[id_producto] [int] NULL,
	[precio_compra] [money] NULL,
	[cantidad] [int] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_salida]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_salida](
	[id_detalle_salida] [int] IDENTITY(1,1) NOT NULL,
	[id_salida] [int] NULL,
	[id_producto] [int] NULL,
	[precio_venta] [money] NULL,
	[cantidad] [int] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL,
	[descripcion] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entradas]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entradas](
	[id_entrada] [int] IDENTITY(1,1) NOT NULL,
	[id_caja] [int] NULL,
	[id_trabajador] [int] NULL,
	[id_proveedor] [int] NULL,
	[factura] [nvarchar](50) NULL,
	[total] [money] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[cve_producto] [int] NULL,
	[cantidad] [int] NULL,
	[descripcion] [nvarchar](50) NULL,
	[nombre] [nvarchar](50) NULL,
	[id_categoria_producto] [int] NULL,
	[precio_compra] [money] NULL,
	[precio_venta] [money] NULL,
	[id_proveedor] [int] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [nvarchar](50) NULL,
	[domicilio] [nvarchar](50) NULL,
	[telefono] [nvarchar](50) NULL,
	[correo] [nvarchar](50) NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puestos]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puestos](
	[id_puesto] [int] IDENTITY(1,1) NOT NULL,
	[puesto] [nvarchar](50) NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salidas]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salidas](
	[id_salida] [int] IDENTITY(1,1) NOT NULL,
	[id_caja] [int] NULL,
	[id_trabajador] [int] NULL,
	[id_cliente] [int] NULL,
	[factura] [nvarchar](50) NULL,
	[total] [money] NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL,
	[descripcion] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[soportes]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[soportes](
	[id_soporte] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [nvarchar](50) NULL,
	[producto] [nvarchar](100) NULL,
	[num_serie] [int] NULL,
	[id_garantia] [int] NULL,
	[falla] [nvarchar](300) NULL,
	[accesorio] [nvarchar](300) NULL,
	[activo] [int] NULL,
	[status] [nvarchar](50) NULL,
	[fecha_entrega] [date] NULL,
	[hora_entrega] [nvarchar](50) NULL,
	[precio_reparacion] [money] NULL,
	[fecha_registro] [date] NULL,
	[hora_ragistro] [nvarchar](50) NULL,
	[id_usuario] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sucursales]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sucursales](
	[id_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombre_sucursal] [nvarchar](50) NULL,
	[responsable] [nvarchar](50) NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trabajadores]    Script Date: 10/09/2019 02:53:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trabajadores](
	[id_trabajador] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [int] NULL,
	[numero_empleado] [int] NULL,
	[id_puesto] [int] NULL,
	[id_departamento] [int] NULL,
	[turno] [nvarchar](50) NULL,
	[fecha_registro] [date] NULL,
	[hora_registro] [nvarchar](50) NULL,
	[activo] [int] NULL,
	[id_usuario] [int] NULL
) ON [PRIMARY]
GO
