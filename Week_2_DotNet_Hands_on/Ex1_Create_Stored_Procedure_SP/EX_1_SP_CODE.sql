
USE employe;
GO


CREATE TABLE Departments (
  DepartmentID   INT PRIMARY KEY,
  DepartmentName VARCHAR(100) NOT NULL
);


CREATE TABLE Employees (
  EmployeeID     INT PRIMARY KEY,
  FirstName      VARCHAR(50) NOT NULL,
  LastName       VARCHAR(50) NOT NULL,
  DepartmentID   INT NOT NULL
    REFERENCES Departments(DepartmentID),
  Salary         DECIMAL(10,2) NOT NULL,
  JoinDate       DATE NOT NULL
);
GO


INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
  (1, 'HR'),
  (2, 'Finance'),
  (3, 'IT'),
  (4, 'Marketing');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
  (1, 'Alekya',    'Gatu',     1, 78000.00, '2022-01-28'),
  (2, 'Ammu',    'Ammu',   2, 95000.00, '2020-02-27'),
  (3, 'Pranu', 'Ekbote', 3, 86000.00, '2015-09-14'),
  (4, 'Keerthi',   'Reddy',   4, 55500.00, '2020-08-10');
GO

-- Query to Retrieve employees by department
DROP PROCEDURE IF EXISTS sp_GetStaffByDept;
GO
CREATE PROCEDURE sp_GetStaffByDept
  @DeptID INT
AS
BEGIN
  SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    d.DepartmentName AS DeptName,
    e.Salary,
    e.JoinDate
  FROM Employees AS e
  JOIN Departments AS d
    ON e.DepartmentID = d.DepartmentID
  WHERE e.DepartmentID = @DeptID
  ORDER BY e.LastName, e.FirstName;
END;
GO

-- Query to Insert a new employee with automatic ID assignment
DROP PROCEDURE IF EXISTS sp_AddNewStaff;
GO
CREATE PROCEDURE sp_AddNewStaff
  @FirstName    VARCHAR(50),
  @LastName     VARCHAR(50),
  @DepartmentID INT,
  @Salary       DECIMAL(10,2),
  @JoinDate     DATE
AS
BEGIN
  DECLARE @NewID INT;
  SELECT @NewID = ISNULL(MAX(EmployeeID), 0) + 1 FROM Employees;

  INSERT INTO Employees (
    EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
  )
  VALUES (
    @NewID, @FirstName, @LastName, @DepartmentID, @Salary, @JoinDate
  );

  SELECT @NewID AS NewEmployeeID;
END;
GO

-- Example: Retrieve staff in department 3

EXEC sp_GetStaffByDept @DeptID = 3;