CREATE TABLE [dbo].[Livro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](100) NOT NULL,
	[Autor] [nvarchar](100) NOT NULL,
	[Alugado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeUsuario] [nvarchar](50) NOT NULL,
	[Senha] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT INTO [dbo].[Usuario]
           ([NomeUsuario]
           ,[Senha])
     VALUES
           ('Admin',
           ,'Admin123')
GO

INSERT INTO [dbo].[Livro]
           ([Titulo]
           ,[Autor]
           ,[Alugado])
     VALUES
           ('PROCRASTINAÇÃO: Guia científico sobre como parar de procrastinar'
           ,'Lilian Soares'>
           ,0)
GO
INSERT INTO [dbo].[Livro]
           ([Titulo]
           ,[Autor]
           ,[Alugado])
     VALUES
           ('Arrume a sua cama'
           ,'William H. Mcraven'>
           ,0)
GO

