--la base de datos se llama export_clientes

CREATE TABLE [dbo].[Clientes](
	[clageing] [char](4) NOT NULL,
	[clcajaing] [char](7) NOT NULL,
	[clusuing] [char](10) NOT NULL,
	[clcodcli] [char](14) NOT NULL,
	[cldatcli] [varchar](35) NOT NULL,
	[cltipdoc] [char](3) NOT NULL,
	[cldocume] [char](15) NOT NULL,
	[cltelefo] [varchar](10) NOT NULL,
	[cldirecc] [varchar](60) NULL,
	[clfecreg] [datetime] NULL,
	[cltippub] [char](2) NOT NULL,
	[clsexo] [char](1) NULL,
	[cltelefo2] [char](10) NULL,
	[cltelefo3] [char](10) NULL,
	[clcategoria] [char](3) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY NONCLUSTERED 
(
	[clcodcli] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF__Clientes__cltipp__773456C8]  DEFAULT ('') FOR [cltippub]
GO


