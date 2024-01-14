CREATE TABLE Todo (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Description TEXT,
    DueDate DATETIME NOT NULL,
    StatusId INT NOT NULL, -- Assuming this is a foreign key to commonStatus table
    Enabled BOOLEAN NOT NULL,
    Priority INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    UpdatedDate DATETIME NOT NULL
);

CREATE TABLE commonTags (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    tagName VARCHAR(255) NOT NULL,
    Enabled BOOLEAN NOT NULL
);


CREATE TABLE commonStatus (
    statusID INT AUTO_INCREMENT PRIMARY KEY,
    statusName VARCHAR(255) NOT NULL
);

CREATE TABLE todoTags (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    todoID INT  NOT NULL,
    tagName VARCHAR(255) NOT NULL
);