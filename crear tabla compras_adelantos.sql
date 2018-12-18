USE [EfectiOro]
GO

/****** Object:  Table [dbo].[compras_adelantos]    Script Date: 02/11/2015 08:45:41 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[compras_adelantos](
	[idcompras_adelantos] [int] IDENTITY(1,1) NOT NULL,
	[numcompra] [varchar](20) NOT NULL,
	[idadelanto] [varchar](20) NOT NULL,
	[codcliente] [varchar](20) NULL,
	[sinicial] [numeric](18, 2) NOT NULL,
	[monto] [decimal](18, 3) NOT NULL,
	[sfinal] [numeric](18, 2) NOT NULL,
	[fecha] [date] NOT NULL,
	[codcaja] [varchar](10) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[hora] [time](0) NOT NULL,
 CONSTRAINT [PK_compras_adelantos] PRIMARY KEY CLUSTERED 
(
	[idcompras_adelantos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


