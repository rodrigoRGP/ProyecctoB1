CREATE TABLE [IM252Cliente](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [nvarchar](256) NOT NULL,
	[Direccion] [nvarchar](512) NULL,
	[Telefono] [nvarchar](128) NOT NULL,
	[Correo] [nvarchar](256) NOT NULL,
    CONSTRAINT PK_IM252Cliente PRIMARY KEY ([Id])
);
CREATE TABLE [IM252Producto](
	[Id] [uniqueidentifier] NOT NULL,
	[Descripcion] [nvarchar](128) NULL,
	[Precio] [smallmoney] NOT NULL,
	[Cantidad] [tinyint] NOT NULL DEFAULT(0),
	[Foto] [nvarchar](max) NULL,
    CONSTRAINT PK_IM252Producto PRIMARY KEY ([Id])
);
