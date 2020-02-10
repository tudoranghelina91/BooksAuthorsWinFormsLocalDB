USE [TudorDB]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[Year] [int] NOT NULL,
	[PublisherId] [int] NOT NULL,
	[AuthorId] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublishingHouses]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublishingHouses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PublishingHouses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_PublishingHouses] FOREIGN KEY([PublisherId])
REFERENCES [dbo].[PublishingHouses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_PublishingHouses]
GO
/****** Object:  StoredProcedure [dbo].[DeleteAuthor]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete Author
CREATE PROCEDURE
	[dbo].[DeleteAuthor]
		@id int
AS
	--DELETE FROM Books WHERE AuthorId = @id;
	DELETE from Authors WHERE Id = @id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteBook]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete Book
CREATE PROCEDURE
	[dbo].[DeleteBook]
		@id int
AS
	DELETE FROM Books WHERE Id = @id;
GO
/****** Object:  StoredProcedure [dbo].[GetAllData]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE
	[dbo].[GetAllData]
AS
	SELECT * FROM Authors;
	SELECT * FROM Books;
GO
/****** Object:  StoredProcedure [dbo].[InsertAuthor]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert Author
CREATE PROCEDURE
	[dbo].[InsertAuthor]
		@firstName nvarchar(50), 
		@lastName nvarchar(50),
		@dateOfBirth datetime
AS
	INSERT INTO Authors(FirstName, LastName, DateOfBirth)
	VALUES (@firstName, @lastName, @dateOfBirth);
GO
/****** Object:  StoredProcedure [dbo].[InsertBook]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert Book
CREATE PROCEDURE
	[dbo].[InsertBook]
		@title nvarchar(50), 
		@year int,
		@authorId int
AS
	INSERT INTO Books(Title, Year, AuthorId)
	VALUES (@title, @year, @authorId);
GO
/****** Object:  StoredProcedure [dbo].[ReseedInitialData]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReseedInitialData]
AS
DELETE FROM Books;
DELETE FROM Authors;
DELETE FROM PublishingHouses;

DBCC CHECKIDENT ('[Books]', RESEED, 0);
DBCC CHECKIDENT ('[Authors]', RESEED, 0);
DBCC CHECKIDENT ('[PublishingHouses]', RESEED, 0);

INSERT INTO PublishingHouses (Name)
VALUES
('Nemira'),
('RAO'),
('Sedcom Libris');

INSERT INTO Authors (FirstName, LastName, DateOfBirth)
VALUES 
	('Nicolae', 'Iorga', CONVERT(datetime,'1871/01/17')),
	('Mihai', 'Eminescu', CONVERT(datetime,'1850/01/15')),
	('Mihail', 'Sadoveanu', CONVERT(datetime,'1880/11/05'));

INSERT INTO Books (Title, Year, PublisherId, AuthorId)
Values
	-- Nicolae Iorga
	('Bizant dupa Bizant', 1935, 1, 1),
	('Istoria romanilor si a civilizatiei lor', 1920, 2, 1),
	('Cugetari', 1911, 3, 1),
	('Istoria bisericii romanesti si a vietii religioase a romanilor', 1908, 2, 1),
	-- Mihai Eminescu
	('Poesii', 1883, 3, 2),
	-- Mihail Sadoveanu
	('Baltagul', 1930, 1, 3),
	('Hanu-Ancutei', 1928, 1, 3),
	('Fratii Jderi', 1935, 2, 3),
	('Neamul Soimarestilor', 1915, 3, 3),
	('Tara de dincolo de negura', 1926, 3, 3);
GO
/****** Object:  StoredProcedure [dbo].[UpdateAuthor]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update author
CREATE PROCEDURE
	[dbo].[UpdateAuthor]
		@id int,
		@firstName nvarchar(50),
		@lastName nvarchar (50),
		@dateOfBirth datetime
AS
	UPDATE Authors
	SET FirstName = @firstName, LastName = @lastName, DateOfBirth = @dateOfBirth
	WHERE Id = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateBook]    Script Date: 2/10/2020 9:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update book
CREATE PROCEDURE
	[dbo].[UpdateBook]
		@id int,
		@title nvarchar(50),
		@year int,
		@authorId int
AS
	UPDATE Books
	SET Title = @title, Year = @year, AuthorId = @authorId
	WHERE Id = @id;
GO
