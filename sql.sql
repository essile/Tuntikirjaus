create database Tuntikirjaus;
go
USE [Tuntikirjaus]
GO

/****** Object:  Table [dbo].[Osasto]    Script Date: 12.10.2018 13.35.17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Osasto](
	[osasto_id] [int] IDENTITY(1,1) NOT NULL,
	[nimi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Osastot] PRIMARY KEY CLUSTERED 
(
	[osasto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Projekti]    Script Date: 12.10.2018 13.35.40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Projekti](
	[projekti_id] [int] IDENTITY(1,1) NOT NULL,
	[nimi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Projektit] PRIMARY KEY CLUSTERED 
(
	[projekti_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Henkilo](
	[henkilo_id] [int] IDENTITY(1,1) NOT NULL,
	[etunimi] [nvarchar](50) NOT NULL,
	[sukunimi] [nvarchar](50) NOT NULL,
	[osasto_id] [int] NOT NULL,
	[tehtavanimike] [nvarchar](50) NULL,
 CONSTRAINT [PK_Henkilo] PRIMARY KEY CLUSTERED 
(
	[henkilo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Henkilo]  WITH CHECK ADD  CONSTRAINT [FK_Henkilo_Osasto] FOREIGN KEY([osasto_id])
REFERENCES [dbo].[Osasto] ([osasto_id])
GO

ALTER TABLE [dbo].[Henkilo] CHECK CONSTRAINT [FK_Henkilo_Osasto]
GO

CREATE TABLE [dbo].[Tuntikirjaus](
	[tuntikirjaus_id] [int] IDENTITY(1,1) NOT NULL,
	[henkilo_id] [int] NOT NULL,
	[projekti_id] [int] NOT NULL,
	[pvm] [date] NOT NULL,
	[tunnit] [decimal](3, 1) NOT NULL,
	[kuvaus] [text] NULL,
	[laskutettava] [bit] NOT NULL,
 CONSTRAINT [PK_tuntikirjaukset] PRIMARY KEY CLUSTERED 
(
	[tuntikirjaus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tuntikirjaus]  WITH CHECK ADD  CONSTRAINT [FK_Tuntikirjaus_Henkilo] FOREIGN KEY([henkilo_id])
REFERENCES [dbo].[Henkilo] ([henkilo_id])
GO

ALTER TABLE [dbo].[Tuntikirjaus] CHECK CONSTRAINT [FK_Tuntikirjaus_Henkilo]
GO

ALTER TABLE [dbo].[Tuntikirjaus]  WITH CHECK ADD  CONSTRAINT [FK_Tuntikirjaus_Projekti] FOREIGN KEY([projekti_id])
REFERENCES [dbo].[Projekti] ([projekti_id])
GO

ALTER TABLE [dbo].[Tuntikirjaus] CHECK CONSTRAINT [FK_Tuntikirjaus_Projekti]
GO

ALTER TABLE [dbo].[Tuntikirjaus]  WITH CHECK ADD  CONSTRAINT [CK_Tuntikirjaus] CHECK  (([tunnit]>(0) AND [tunnit]<(20)))
GO

ALTER TABLE [dbo].[Tuntikirjaus] CHECK CONSTRAINT [CK_Tuntikirjaus]
GO

insert into Osasto values ('HR');
insert into Osasto values ('R&D');
insert into Osasto values ('Tuotanto');
insert into Osasto values ('Myynti');

insert into Projekti values ('Asiakas A');
insert into Projekti values ('Asiakas B');
insert into Projekti values ('Asiakas C');
insert into Projekti values ('IP 1');

insert into Henkilo values ('Emma', 'Tuovinen', 1, 'Frontend devaaja');
insert into Henkilo values ('Jukka', 'Ainali', 2, 'Backend devaaja');
insert into Henkilo values ('Essi', 'Lehtola', 3, 'Frontend devaaja');
insert into Henkilo values ('Sami', 'Orko', 4, 'Backend devaaja');