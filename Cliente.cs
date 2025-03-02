CREATE TABLE [IM252Cliente](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [nvarchar](256) NOT NULL,
	[Direccion] [nvarchar](512) NULL,
	[Telefono] [nvarchar](128) NOT NULL,
	[Correo] [nvarchar](256) NOT NULL,
    CONSTRAINT PK_IM252Cliente PRIMARY KEY ([Id])
);
