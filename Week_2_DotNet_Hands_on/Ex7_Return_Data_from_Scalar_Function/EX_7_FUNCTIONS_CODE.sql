-- Step 1: Create Database
CREATE DATABASE CompanyDB_AnnualSalary;
GO
USE CompanyDB_AnnualSalary;
GO

-- Step 2: Create Employees Table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Salary DECIMAL(10,2) NOT NULL  -- Monthly Salary
);
GO

-- Step 3: Insert Sample Employees
INSERT INTO Employees (FirstName, LastName, Salary) VALUES
('Trisha', 'Reddy', 68000.00),   -- EmployeeID = 1
('Praneetha', 'Sharma', 75000.00),
('Hindu', 'Sri', 82000.00);
GO

-- Step 4: Create Scalar Function to Calculate Annual Salary
CREATE FUNCTION fn_CalculateAnnualSalary (
    @EmpID INT
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @AnnualSalary DECIMAL(10,2);

    SELECT @AnnualSalary = Salary * 12
    FROM Employees
    WHERE EmployeeID = @EmpID;

    RETURN @AnnualSalary;
END;
GO

--Step 5: Execute the Function for EmployeeID = 1
SELECT dbo.fn_CalculateAnnualSalary(1) AS AnnualSalary;
GO