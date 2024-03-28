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
    Avatar varbinary(max),
    CV varbinary(max)
);

CREATE TABLE Company (
    ID VARCHAR(4) PRIMARY KEY default SUBSTRING(CONVERT(VARCHAR(36), NEWID()), 1, 4) ,
    Name VARCHAR(255),
    Email VARCHAR(255) UNIQUE,
    Address VARCHAR(255),
    CompanyType VARCHAR(100),
    CompanySize VARCHAR(100),
    Phonenumber NCHar(100),
    WorkingTimeBegin varchar(20), 
    WorkingTimeEnd varchar(20), 
    Avatar varbinary (max),
    TaxIndentification varchar(50),
    BusinessLicense varbinary(max),
    Details text
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

ALTER TABLE Apply
ADD CONSTRAINT chk_status CHECK (status IN ('waiting', 'approve', 'decline'));


-- Insert sample data into the Account table
INSERT INTO Account (Email, Password, Type)
VALUES
    ('john@example.com', 'password123', 'jobseeker'),
    ('emma@example.com', 'secret456', 'jobseeker'),
    ('abc@example.com', 'company123', 'company'), -- New account for ABC Corp
    ('xyz@example.com', 'company456', 'company'); -- New account for XYZ Inc

-- Insert sample data into the JobSeeker table
INSERT INTO JobSeeker (Name, Email, Address, PhoneNumber, DateOfBirth, NationalID, Avatar, CV)
VALUES
    ('John Doe', 'john@example.com', '123 Main St, City', '123-456-7890', '1990-01-01', '12345', NULL, NULL),
    ('Emma Smith', 'emma@example.com', '456 Elm St, Town', '987-654-3210', '1995-05-15', '54321', NULL, NULL);

-- Insert sample data into the Company table
INSERT INTO Company (Name, Email, Address, PhoneNumber, CompanyType, CompanySize, WorkingTime, Avatar)
VALUES
    ('ABC Corp', 'abc@example.com', '789 Oak St, Village', '987-654-3210', 'Tech', 'Large', '9am - 5pm', NULL),
    ('XYZ Inc', 'xyz@example.com', '987 Pine St, Town', '123-456-7890', 'Finance', 'Medium', '8am - 4pm', NULL);

alter table jobseeker
add gender varchar(10)

update JobSeeker
set gender = 'female'