CREATE TABLE [Author] (
    [Id] INTEGER NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(255) NOT NULL
);

CREATE TABLE [Book] (
    [Id] INTEGER NOT NULL PRIMARY KEY,
    [Title] NVARCHAR(255) NOT NULL,
    [AuthorId] INTEGER NOT NULL,
    [PublishDate] DATE NOT NULL,
    [ISBN] NVARCHAR(13) NOT NULL,

    FOREIGN KEY (AuthorId) REFERENCES Author(Id)
);

INSERT INTO [Author] VALUES 
    (1, 'Robert C. Martin'), 
    (2, 'Eric Evans'),
    (3, 'Dennis Ritchie'),
    (4, 'Martin Fowler');

INSERT INTO [Book] VALUES 
    (1, 'Clean Code', 1, '2018-10-01', '9780132350884'),
    (2, 'Domain Driven Design', 2, '2003-08-20', '9780321125217'),
    (3, 'C Programming Language', 3, '1988-03-22', 'B009ZUZ9FW'),
    (4, 'Refactoring: Improving the Design of Existing Code', 4, '2012-03-09', 'B007WTFWJ6');
