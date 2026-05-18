-- =============================================
-- Bob's Gym Database Script
-- =============================================

USE master;
GO

-- Create Database
CREATE DATABASE GymManagementDB;
GO

USE GymManagementDB;
GO

-- =============================================
-- TABLES
-- =============================================

-- Members Table
CREATE TABLE Members (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(20),
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(200),
    TrainingProgram NVARCHAR(100),
    MembershipStartDate DATE NOT NULL,
    MembershipEndDate DATE NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- Gym Classes / Training Programs Table
CREATE TABLE GymClasses (
    ClassID INT PRIMARY KEY IDENTITY(1,1),
    ClassName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(300),
    Instructor NVARCHAR(100),
    Schedule NVARCHAR(100),
    Capacity INT NOT NULL,
    Duration INT NOT NULL,           -- Duration in minutes
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- =============================================
-- STORED PROCEDURES - MEMBERS
-- =============================================

CREATE PROCEDURE sp_CreateMember
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Gender NVARCHAR(20),
    @PhoneNumber NVARCHAR(20),
    @Address NVARCHAR(200),
    @TrainingProgram NVARCHAR(100),
    @MembershipStartDate DATE,
    @MembershipEndDate DATE
AS
BEGIN
    INSERT INTO Members (FirstName, LastName, DateOfBirth, Gender, PhoneNumber, 
                        Address, TrainingProgram, MembershipStartDate, MembershipEndDate)
    VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @PhoneNumber, 
            @Address, @TrainingProgram, @MembershipStartDate, @MembershipEndDate);
    
    SELECT SCOPE_IDENTITY() AS NewMemberID;
END
GO

CREATE PROCEDURE sp_GetAllMembers
AS
BEGIN
    SELECT * FROM Members ORDER BY LastName, FirstName;
END
GO

CREATE OR ALTER PROCEDURE sp_GetAllMembers
AS
BEGIN
SELECT * FROM Members
ORDER BY CreatedDate ASC;
END
GO

CREATE PROCEDURE sp_GetMemberByID
    @MemberID INT
AS
BEGIN
    SELECT * FROM Members WHERE MemberID = @MemberID;
END
GO

CREATE PROCEDURE sp_UpdateMember
    @MemberID INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Gender NVARCHAR(20),
    @PhoneNumber NVARCHAR(20),
    @Address NVARCHAR(200),
    @TrainingProgram NVARCHAR(100),
    @MembershipStartDate DATE,
    @MembershipEndDate DATE
AS
BEGIN
    UPDATE Members
    SET FirstName = @FirstName,
        LastName = @LastName,
        DateOfBirth = @DateOfBirth,
        Gender = @Gender,
        PhoneNumber = @PhoneNumber,
        Address = @Address,
        TrainingProgram = @TrainingProgram,
        MembershipStartDate = @MembershipStartDate,
        MembershipEndDate = @MembershipEndDate
    WHERE MemberID = @MemberID;
END
GO

CREATE PROCEDURE sp_DeleteMember
    @MemberID INT
AS
BEGIN
    DELETE FROM Members WHERE MemberID = @MemberID;
END
GO

CREATE PROCEDURE sp_SearchMembers
    @SearchTerm NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Members 
    WHERE FirstName LIKE '%' + @SearchTerm + '%' 
       OR LastName LIKE '%' + @SearchTerm + '%'
       OR CONVERT(NVARCHAR, MemberID) LIKE '%' + @SearchTerm + '%';
END
GO

-- =============================================
-- STORED PROCEDURES - CLASSES
-- =============================================

CREATE PROCEDURE sp_CreateClass
    @ClassName NVARCHAR(100),
    @Description NVARCHAR(300),
    @Instructor NVARCHAR(100),
    @Schedule NVARCHAR(100),
    @Capacity INT,
    @Duration INT
AS
BEGIN
    INSERT INTO GymClasses (ClassName, Description, Instructor, Schedule, Capacity, Duration)
    VALUES (@ClassName, @Description, @Instructor, @Schedule, @Capacity, @Duration);
    
    SELECT SCOPE_IDENTITY() AS NewClassID;
END
GO

CREATE PROCEDURE sp_GetAllClasses
AS
BEGIN
    SELECT * FROM GymClasses ORDER BY ClassName;
END
GO

CREATE PROCEDURE sp_UpdateClass
    @ClassID INT,
    @ClassName NVARCHAR(100),
    @Description NVARCHAR(300),
    @Instructor NVARCHAR(100),
    @Schedule NVARCHAR(100),
    @Capacity INT,
    @Duration INT
AS
BEGIN
    UPDATE GymClasses
    SET ClassName = @ClassName,
        Description = @Description,
        Instructor = @Instructor,
        Schedule = @Schedule,
        Capacity = @Capacity,
        Duration = @Duration
    WHERE ClassID = @ClassID;
END
GO

CREATE PROCEDURE sp_DeleteClass
    @ClassID INT
AS
BEGIN
    DELETE FROM GymClasses WHERE ClassID = @ClassID;
END
GO