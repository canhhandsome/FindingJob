-- Create tables
CREATE TABLE Account (
    Email VARCHAR(255) PRIMARY KEY,
    Password VARCHAR(255),
    Type VARCHAR(50)
);

CREATE TABLE JobSeeker (
    ID VARCHAR(4) PRIMARY KEY default SUBSTRING(CONVERT(VARCHAR(36), NEWID()), 1, 4) ,
    Name VARCHAR(255),
    Email VARCHAR(255) UNIQUE,
    Address VARCHAR(255),
    PhoneNumber VARCHAR(20),
    DateOfBirth DATE,
    NationalID VARCHAR(20),
    Avatar image,
    CV image
);

CREATE TABLE Company (
    ID VARCHAR(4) PRIMARY KEY default SUBSTRING(CONVERT(VARCHAR(36), NEWID()), 1, 4) ,
    Name VARCHAR(255),
    Email VARCHAR(255) UNIQUE,
    Address VARCHAR(255),
    CompanyType VARCHAR(100),
    CompanySize VARCHAR(100),
    Phonenumber NCHar(100),
    WorkingTime VARCHAR(100),
    Avatar image
);

CREATE TABLE Job (
    JobID VARCHAR(4) PRIMARY KEY default SUBSTRING(CONVERT(VARCHAR(36), NEWID()), 1, 4),
    CompanyID VARCHAR(4),
    JobName VARCHAR(255),
    Position VARCHAR(255),
    Salary DECIMAL(10, 2),
    DatePublish DATETIME DEFAULT CURRENT_TIMESTAMP,
    requirement text,
    description text,
    FOREIGN KEY (CompanyID) REFERENCES Company(ID) ON UPDATE CASCADE
);

CREATE TABLE Apply (
    JobSeekerID VARCHAR(4),
    JobID VARCHAR(4),
    TimeApply DATETIME DEFAULT CURRENT_TIMESTAMP,
    status VARCHAR (20) DEFAULT ('waiting'),
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(ID) ON UPDATE CASCADE,
    FOREIGN KEY (JobID) REFERENCES Job(JobID) ON UPDATE CASCADE,
    PRIMARY KEY (JobSeekerID, JobID) -- Composite primary key to prevent duplicate applications
);

CREATE TABLE Rating (
    JobSeekerID VARCHAR(4),
    CompanyID VARCHAR(4),
    Rate INT,
    Type VARCHAR(50),
    TimeRate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(ID) ON UPDATE CASCADE,
    FOREIGN KEY (CompanyID) REFERENCES Company(ID) ON UPDATE CASCADE,
    PRIMARY KEY (JobSeekerID, CompanyID) -- Composite primary key to prevent duplicate ratings
);

CREATE TABLE JobAlert (
    id VARCHAR(4) PRIMARY KEY default SUBSTRING(CONVERT(VARCHAR(36), NEWID()), 1, 4),
    senderID VARCHAR(4), 
    recipientID VARCHAR(4), 
    Subject TEXT, 
    content TEXT,
    DateReply DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (senderID) REFERENCES Company(ID) ON UPDATE CASCADE,
    FOREIGN KEY (recipientID) REFERENCES JobSeeker(ID) ON UPDATE CASCADE
);

-- Add foreign key constraints
ALTER TABLE Company
ADD CONSTRAINT FK_AccountCompany
FOREIGN KEY (Email) REFERENCES Account(Email);

ALTER TABLE JobSeeker
ADD CONSTRAINT FK_AccountJobSeeker
FOREIGN KEY (Email) REFERENCES Account(Email);

ALTER TABLE apply
ADD CONSTRAINT chk_status CHECK (status IN ('waiting', 'approve', 'decline'));