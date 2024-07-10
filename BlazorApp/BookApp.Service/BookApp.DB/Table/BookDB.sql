CREATE TABLE [dbo].[BookDB]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Titel] NVARCHAR(264) NOT NULL, 
    [Subtitle] NVARCHAR(264) NULL, 
    [Format] INT NOT NULL, 
    [Page] INT NULL, 
    [Hours] DECIMAL(18, 2) NULL, 
    [Language] INT NOT NULL, 
    [DateOfRelease] DATETIME2 NULL, 
    [ISBN] NVARCHAR(18) NULL, 
    [BandNr] INT NULL, 
    [PublisherId] UNIQUEIDENTIFIER NOT NULL, 
    [AuthorId] UNIQUEIDENTIFIER NOT NULL,
)
