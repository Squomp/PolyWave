CREATE DATABASE [TeamTEAMMemeSquad]

CREATE TABLE [dbo].[Media](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Author] [varchar](50) NULL,
	[Caption] [varchar](50) NULL,
	[Description] [varchar](200) NULL,
	[Path] [varchar](200) NULL,
	[Type] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
)
