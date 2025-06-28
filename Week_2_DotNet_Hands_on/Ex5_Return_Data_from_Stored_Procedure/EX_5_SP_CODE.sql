-- Step 1: Create Database
CREATE DATABASE CompanyDB_EmployeeCount;
GO
USE CompanyDB_EmployeeCount;
GO

-- Step 2: Create Departments Table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName VARCHAR(100) NOT NULL
);
GO

-- Step 3: Create Employees Table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DepartmentID INT NOT NULL,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
GO

-- Step 4: Insert Sample Departments
INSERT INTO Departments (DepartmentName) VALUES
('Human Resources'),
('Finance'),
('Engineering'),
('Marketing');
GO

-- Step 5: Insert Sample Employees
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('Koushi', 'Sharma', 3, 89000, '2024-05-10'),  -- Engineering
('Sri', 'Laxmi', 3, 70000, '2023-11-01'),      -- Engineering
('Chethana', 'Kamsali', 1, 95000, '2022-07-15'),     -- HR
('Varalax', 'Reddy', 2, 75000, '2024-01-20');     -- Finance
GO

-- Step 6: Create Stored Procedure to Return Employee Count by Department
CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        COUNT(*) AS TotalEmployees
    FROM 
        Employees
    WHERE 
        DepartmentID = @DepartmentID;
END;
GO

--Example Query: Get Employee Count for Engineering Department (DepartmentID = 3)
EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 3;
GO
