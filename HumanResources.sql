

IF NOT EXISTS (
    SELECT 1
    FROM sys.databases
    WHERE Name = 'HumanResource'
)
BEGIN
    CREATE DATABASE HumanResource;
END
GO
USE HumanResource
GO

CREATE TABLE Roles ( 
	RoleId INTEGER NOT NULL,
	RoleDesc NVARCHAR(255) NOT NULL,
	RoleName NVARCHAR(255) NOT NULL,
	PRIMARY KEY(RoleId)
);

CREATE TABLE Salary (
	SalaryId INTEGER NOT NULL,
	SalaryAmount INTEGER NOT NULL,
	SalaryDesc NVARCHAR(255) NOT NULL,
	PRIMARY KEY (SalaryId)

);

CREATE TABLE Department (
	DepId INTEGER NOT NULL,
	DepDesc NVARCHAR(255) NOT NULL,
	DepType VARCHAR(255) NOT NULL,
	DepPlace NVARCHAR(255) NOT NULL,
	PRIMARY KEY (DepId) 
);
CREATE TABLE Account (
	AccountId INTEGER NOT NULL,
	FullName NVARCHAR(255) NOT NULL,
	PassWords NVARCHAR(255) NOT NULL,
	Email NVARCHAR(255) NOT NULL,
	RoleId INTEGER NOT NULL,
	PRIMARY KEY (AccountId),
	FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);

CREATE TABLE Employee (
	EmployId INTEGER NOT NULL ,
	Email NVARCHAR(255) NOT NULL,
	EmployeeName NVARCHAR(255) NOT NULL,
	Avatar NVARCHAR(255) NOT NULL,
	AddressEmployee NVARCHAR(255) NOT NULL ,
	Phone VARCHAR(255) NOT NULL,
	RoleId INTEGER NOT NULL,
	AccountId INTEGER NOT NULL,
	DepId INTEGER NOT NULL,
	SalaryId INTEGER NOT NULL,

	PRIMARY KEY(EmployId),
	FOREIGN KEY(AccountId) REFERENCES Account(AccountId),
	FOREIGN KEY(RoleId) REFERENCES Roles(RoleId),
	FOREIGN KEY(DepId) REFERENCES Department(DepId),
	FOREIGN KEY(SalaryId) REFERENCES Salary(SalaryId),

);




INSERT INTO Roles (RoleId, RoleDesc, RoleName)
VALUES (1, 'Administrator', 'Admin'),
       (2, 'Manager', 'Manager'),
       (3, 'Employee', 'Employee'),
       (4, 'Supervisor', 'Supervisor'),
       (5, 'Team Lead', 'TeamLead'),
       (6, 'Developer', 'Developer'),
       (7, 'Analyst', 'Analyst'),
       (8, 'Tester', 'Tester'),
       (9, 'Designer', 'Designer'),
       (10, 'Intern', 'Intern');

INSERT INTO Salary (SalaryId, SalaryAmount, SalaryDesc)
VALUES (1, 5000, 'Junior Salary'),
       (2, 8000, 'Senior Salary'),
       (3, 3000, 'Intern Salary'),
       (4, 6000, 'Mid-level Salary'),
       (5, 9000, 'Senior Salary'),
       (6, 4000, 'Junior Salary'),
       (7, 7000, 'Mid-level Salary'),
       (8, 3500, 'Intern Salary'),
       (9, 5500, 'Junior Salary'),
       (10, 7500, 'Mid-level Salary');

INSERT INTO Department (DepId, DepDesc, DepType, DepPlace)
VALUES (1, 'IT Department', 'Technical', 'Headquarters'),
       (2, 'Sales Department', 'Sales', 'Branch Office'),
       (3, 'HR Department', 'Administrative', 'Headquarters'),
       (4, 'Marketing Department', 'Marketing', 'Branch Office'),
       (5, 'Finance Department', 'Financial', 'Headquarters'),
       (6, 'Operations Department', 'Operations', 'Branch Office'),
       (7, 'Research Department', 'Research', 'Headquarters'),
       (8, 'Support Department', 'Technical', 'Branch Office'),
       (9, 'Legal Department', 'Legal', 'Headquarters'),
       (10, 'Quality Assurance Department', 'Technical', 'Branch Office');

DECLARE @AccountId INTEGER = 11;
DECLARE @FullName NVARCHAR(255) = 'John Doe';
DECLARE @Email NVARCHAR(255) = 'admin1@gmail.com';
	   
INSERT INTO Account ( AccountId,FullName, PassWords, Email, RoleId)
VALUES (1, 'John Doe', 'password123', 'johndoe@example.com', 1),
       (2, 'Jane Smith', 'pass456', 'janesmith@example.com', 3),
       (3, 'Mike Johnson', 'abc123', 'mikejohnson@example.com', 2),
       (4, 'Sarah Williams', 'pwd789', 'sarahwilliams@example.com', 4),
       (5, 'David Brown', 'securepass', 'davidbrown@example.com', 5),
       (6, 'Emily Davis', 'mypassword', 'emilydavis@example.com', 6),
       (7, 'Michael Wilson', 'password321', 'michaelwilson@example.com', 7),
       (8, 'Jessica Taylor', 'ilovecoding', 'jessicataylor@example.com', 8),
       (9, 'Andrew Thomas', 'thomaspass', 'andrewthomas@example.com', 9),
       (10, 'Olivia Clark', 'mypwd123', 'oliviaclark@example.com', 10),
	   (@AccountId, @FullName, CONVERT(nvarchar(max), HASHBYTES('MD5', '123'), 2),@Email, 2);



INSERT INTO Employee (EmployId, Email, EmployeeName, Avatar, AddressEmployee, Phone, RoleId, AccountId, DepId, SalaryId)
VALUES (1, 'employee1@example.com', 'Employee 1', 'avatar1.jpg', '123 ABC Street', '1234567890', 3, 1, 1, 3),
       (2, 'employee2@example.com', 'Employee 2', 'avatar2.jpg', '456 XYZ Street', '9876543210', 3, 2, 1, 3),
       (3, 'employee3@example.com', 'Employee 3', 'avatar3.jpg', '789 PQR Street', '5555555555', 2, 3, 2, 2),
       (4, 'employee4@example.com', 'Employee 4', 'avatar4.jpg', '321 DEF Street', '4444444444', 4, 4, 3, 4),
       (5, 'employee5@example.com', 'Employee 5', 'avatar5.jpg', '654 UVW Street', '3333333333', 6, 5, 4, 5),
       (6, 'employee6@example.com', 'Employee 6', 'avatar6.jpg', '987 HIJ Street', '2222222222', 7, 6, 5,6),
       (7, 'employee7@example.com', 'Employee 7', 'avatar7.jpg', '654 KLM Street', '1111111111', 8, 7, 6, 7),
       (8, 'employee8@example.com', 'Employee 8', 'avatar8.jpg', '321 XYZ Street', '9999999999', 9, 8, 7, 8),
       (9, 'employee9@example.com', 'Employee 9', 'avatar9.jpg', '789 PQR Street', '8888888888', 5, 9, 8, 9),
       (10, 'employee10@example.com', 'Employee 10', 'avatar10.jpg', '123 ABC Street', '7777777777', 10, 10, 9, 10),
       (11, 'employee11@example.com', 'Employee 11', 'avatar11.jpg', '456 XYZ Street', '6666666666', 3, 1, 2, 3),
       (12, 'employee12@example.com', 'Employee 12', 'avatar12.jpg', '789 PQR Street', '5555555555', 2, 2, 3, 2),
       (13, 'employee13@example.com', 'Employee 13', 'avatar13.jpg', '321 DEF Street', '4444444444', 4, 3, 4, 4),
       (14, 'employee14@example.com', 'Employee 14', 'avatar14.jpg', '654 UVW Street', '3333333333', 6, 4, 5, 5),
       (15, 'employee15@example.com', 'Employee 15', 'avatar15.jpg', '987 HIJ Street', '2222222222', 7, 5, 6, 6),
       (16, 'employee16@example.com', 'Employee 16', 'avatar16.jpg', '654 KLM Street', '1111111111', 8, 6, 7, 7),
       (17, 'employee17@example.com', 'Employee 17', 'avatar17.jpg', '321 XYZ Street', '9999999999', 9, 7, 8, 8),
       (18, 'employee18@example.com', 'Employee 18', 'avatar18.jpg', '789 PQR Street', '8888888888', 5, 8, 9, 9),
       (19, 'employee19@example.com', 'Employee 19', 'avatar19.jpg', '123 ABC Street', '7777777777', 10, 9, 10, 10),
       (20, 'employee20@example.com', 'Employee 20', 'avatar20.jpg', '456 XYZ Street', '6666666666', 3, 8, 1, 3);

