use FindingJob
go

-- Create tables
CREATE TABLE Account (
    Email VARCHAR(255) PRIMARY KEY,
    Password VARCHAR(255),
    Type VARCHAR(50)
);
go

CREATE TABLE JobSeeker (
    JobSeekerID varchar(10) PRIMARY KEY ,
    FullName VARCHAR(255),
    Email VARCHAR(255),
    Address VARCHAR(255),
    PhoneNumber VARCHAR(20),
    DateOfBirth DATE,
    NationalID VARCHAR(20)
);


CREATE TABLE Company (
    CompanyID varchar(10) PRIMARY KEY ,
    CompanyName VARCHAR(255),
    Email VARCHAR(255),
    Address VARCHAR(255),
    CompanyType VARCHAR(100),
    CompanySize VARCHAR(100),
    WorkingTime VARCHAR(100)
);

CREATE TABLE Job (
    JobID varchar(10) PRIMARY KEY ,
    CompanyID varchar(10),
    JobName VARCHAR(255),
    Position VARCHAR(255),
    Salary DECIMAL(10, 2),
    DatePublish DATE,
    FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID)
);


CREATE TABLE JS_Education (
    JobSeekerID varchar(10),
    Education VARCHAR(255),
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID)
);

CREATE TABLE JS_Skill (
    JobSeekerID varchar(10),
    Skill VARCHAR(255),
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID)
);

CREATE TABLE JS_Reward (
    JobSeekerID varchar(10),
    Reward VARCHAR(255),
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID)
);

CREATE TABLE JS_EXP (
    JobSeekerID varchar(10),
    EXP VARCHAR(255),
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID)
);

CREATE TABLE JS_Information (
    JobSeekerID varchar(10),
    Information VARCHAR(255),
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID)
);

CREATE TABLE JS_Project (
    JobSeekerID varchar(10),
    Project VARCHAR(255),
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID)
);

CREATE TABLE JS_Certificate (
    JobSeekerID varchar(10),
    Certificate VARCHAR(255),
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID)
);

CREATE TABLE J_Requirement (
    JobID varchar(10),
    Requirement VARCHAR(255),
    FOREIGN KEY (JobID) REFERENCES Job(JobID)
);

CREATE TABLE J_Description (
    JobID varchar(10),
    Description VARCHAR(2000),
    FOREIGN KEY (JobID) REFERENCES Job(JobID)
);

CREATE TABLE C_Description (
    CompanyID varchar(10),
    Description VARCHAR(2000),
    FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID)
);

CREATE TABLE Apply (
    JobSeekerID varchar(10),
    JobID varchar(10),
    TimeApply DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID),
    FOREIGN KEY (JobID) REFERENCES Job(JobID)
);

CREATE TABLE Rating (
    JobSeekerID varchar(10),
    CompanyID varchar(10),
    Rate INT,
    Type VARCHAR(50),
    TimeRate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (JobSeekerID) REFERENCES JobSeeker(JobSeekerID),
    FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID)
);


ALTER TABLE Company
ADD CONSTRAINT FK_AccountCompany
FOREIGN KEY (Email) REFERENCES Account(Email);

ALTER TABLE JobSeeker
ADD CONSTRAINT FK_AccountJobSeeker
FOREIGN KEY (Email) REFERENCES Account(Email);


INSERT INTO Account (Email, Password, Type) VALUES
('example1@example.com', 'password1', 'jobseeker'),
('example2@example.com', 'password2', 'company'),
('example3@example.com', 'password1', 'jobseeker'),
('example4@example.com', 'password2', 'company');

INSERT INTO JobSeeker (JobSeekerID, FullName, Email, Address, PhoneNumber, DateOfBirth, NationalID) VALUES
('JS001', 'John Doe', 'example1@example.com', '123 Main St, Cityville', '123-456-7890', '1990-05-15', '1234567890'),
('JS002', 'Jane Smith', 'example3@example.com', '456 Elm St, Townsville', '987-654-3210', '1995-08-25', '0987654321');

INSERT INTO Company (CompanyID, CompanyName, Email, Address, CompanyType, CompanySize, WorkingTime) VALUES
('C001', 'ABC Corp', 'example2@example.com', '789 Oak St, Villageton', 'Tech', 'Large', 'Full-time'),
('C002', 'XYZ Inc', 'example4@example.com', '321 Pine St, Hamletville', 'Finance', 'Small', 'Part-time');

INSERT INTO Job (JobID, CompanyID, JobName, Position, Salary, DatePublish) VALUES
('J001', 'C001', 'Software Engineer', 'Developer', 80000.00, '2024-03-01'),
('J002', 'C002', 'Financial Analyst', 'Analyst', 60000.00, '2024-03-02');

INSERT INTO JS_Education (JobSeekerID, Education) VALUES
('JS001', 'Bachelor of Science in Computer Science'),
('JS001', 'Master of Business Administration'),
('JS002', 'Bachelor of Arts in Economics');

INSERT INTO JS_Skill (JobSeekerID, Skill) VALUES
('JS001', 'Java'),
('JS001', 'Python'),
('JS002', 'Microsoft Excel');

INSERT INTO JS_Reward (JobSeekerID, Reward) VALUES
('JS001', 'Employee of the Month - July 2023'),
('JS002', 'Scholarship for Academic Excellence');

INSERT INTO JS_EXP (JobSeekerID, EXP) VALUES
('JS001', 'Software Developer at XYZ Corp (2018-2022)'),
('JS002', 'Financial Analyst Intern at ABC Inc (Summer 2023)');

INSERT INTO JS_Information (JobSeekerID, Information) VALUES
('JS001', 'Fluent in Spanish'),
('JS002', 'Certified in Financial Modeling');

INSERT INTO JS_Project (JobSeekerID, Project) VALUES
('JS001', 'Developed a mobile app for budget tracking'),
('JS002', 'Led a research project on market trends in emerging economies');

INSERT INTO JS_Certificate (JobSeekerID, Certificate) VALUES
('JS001', 'Oracle Certified Java Programmer'),
('JS002', 'CFA Level 1');

INSERT INTO J_Requirement (JobID, Requirement) VALUES
('J001', 'Bachelor''s degree in Computer Science or related field'),
('J002', 'Bachelor''s degree in Finance or related field');

INSERT INTO J_Description (JobID, Description) VALUES
('J001', 'We are seeking a skilled software engineer to join our development team.'),
('J002', 'We are looking for a detail-oriented financial analyst to analyze financial data and trends.');

INSERT INTO C_Description (CompanyID, Description) VALUES
('C001', 'ABC Corp is a leading tech company specializing in software development.'),
('C002', 'XYZ Inc is a finance company providing investment services.');

