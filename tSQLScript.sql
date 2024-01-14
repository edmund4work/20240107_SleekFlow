-- Todo Table
CREATE TABLE Todo (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    DueDate DATETIME NOT NULL,
    StatusId INT NOT NULL,
    Enabled BIT NOT NULL,
    Priority INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    UpdatedDate DATETIME NOT NULL
);

-- CommonTags Table
CREATE TABLE commonTags (
    ID INT PRIMARY KEY IDENTITY(1,1),
    tagName NVARCHAR(255) NOT NULL,
    Enabled BIT NOT NULL
);

-- CommonStatus Table
CREATE TABLE commonStatus (
    statusID INT PRIMARY KEY IDENTITY(1,1),
    statusName NVARCHAR(255) NOT NULL
);

-- TodoTags Table
CREATE TABLE todoTags (
    ID INT PRIMARY KEY IDENTITY(1,1),
    todoID INT NOT NULL,
    tagName NVARCHAR(255) NOT NULL
);