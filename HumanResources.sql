

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
	RoleId INTEGER IDENTITY(1,1) NOT NULL,
	RoleDesc NVARCHAR(255)  NULL,
	RoleName NVARCHAR(255)  NULL,
	PRIMARY KEY(RoleId)
);

CREATE TABLE Salary (
	SalaryId INTEGER IDENTITY(1,1) NOT NULL,
	SalaryAmount INTEGER  NULL,
	SalaryDesc NVARCHAR(255)  NULL,
	PRIMARY KEY (SalaryId)

);

CREATE TABLE Department (
	DepId INTEGER IDENTITY(1,1) NOT NULL,
	DepDesc VARCHAR(255)  NULL,
	DepType VARCHAR(255)  NULL,
	DepPlace VARCHAR(255)  NULL,
	PRIMARY KEY (DepId) 
);
CREATE TABLE Account (
	AccountId INTEGER IDENTITY(1,1) NOT NULL,
	FullName NVARCHAR(255)  NULL,
	PassWords NVARCHAR(255)  NULL,
	Email NVARCHAR(255)  NULL,
	RoleId INTEGER  NULL,
	PRIMARY KEY (AccountId),
	FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);
CREATE TABLE Education (
    EducationId INTEGER IDENTITY(1,1) NOT NULL,
    EducationName NVARCHAR(255)  NULL,
    PRIMARY KEY (EducationId)
);
CREATE TABLE Degree (
    DegreeId INTEGER IDENTITY(1,1) NOT NULL,
    DegreeName NVARCHAR(255)  NULL,
    PRIMARY KEY (DegreeId)
);

CREATE TABLE RelativeEmployee (
    RelativeId INTEGER IDENTITY(1,1) NOT NULL,
    EmployeeId INTEGER   NULL,
    FullName NVARCHAR(255)  NULL,
    Relationship NVARCHAR(255)  NULL,
	PhoneNumber VARCHAR(255)  NULL,
    AddressRelative NVARCHAR(255)  NULL,
    PRIMARY KEY (RelativeId),
);

CREATE TABLE Employee (
	EmployId INTEGER IDENTITY(1,1) NOT NULL ,
	Email NVARCHAR(255)  NULL,
	EmployeeName NVARCHAR(255)  NULL,
	Avatar NVARCHAR(255)  NULL,
	AddressEmployee NVARCHAR(255)  NULL ,
	DateOfBirth DATE NULL,
	Phone VARCHAR(255)  NULL,
	Gender NVARCHAR(255) NULL,
	RoleId INTEGER  NULL,
	AccountId INTEGER  NULL,
	DepId INTEGER NULL,
	SalaryId INTEGER  NULL,
	EducationId INTEGER  NULL,
    DegreeId INTEGER  NULL,
	RelativeId INTEGER  NULL,
	PRIMARY KEY(EmployId),
	FOREIGN KEY(AccountId) REFERENCES Account(AccountId),
	FOREIGN KEY(RoleId) REFERENCES Roles(RoleId),
	FOREIGN KEY(DepId) REFERENCES Department(DepId),
	FOREIGN KEY(SalaryId) REFERENCES Salary(SalaryId),
	FOREIGN KEY(EducationId) REFERENCES Education(EducationId),
	FOREIGN KEY(DegreeId) REFERENCES Degree(DegreeId),
	FOREIGN KEY(RelativeId) REFERENCES RelativeEmployee(RelativeId),

);
CREATE TABLE EmployeeHistory (
	HistoryId INTEGER  IDENTITY(1,1) NOT NULL ,
	EmployId INTEGER  NULL,
	StartDate DATE NULL,
	EndDate DATE NULL,
	Staging VARCHAR(255)  NULL,
	PRIMARY KEY (HistoryId),
	FOREIGN KEY(EmployId) REFERENCES Employee(EmployId),
);



INSERT INTO Roles ( RoleDesc, RoleName)
VALUES ( 'Administrator', 'Admin'),
       ( 'Manager', 'Manager'),
       ( 'Employee', 'Employee'),
       ( 'Supervisor', 'Supervisor'),
       ( 'Team Lead', 'TeamLead'),
       ( 'Developer', 'Developer'),
       ('Analyst', 'Analyst'),
       ('Tester', 'Tester'),
       ( 'Designer', 'Designer'),
       ( 'Intern', 'Intern'),
       ( 'Root', 'Big-Boss');

INSERT INTO Salary ( SalaryAmount, SalaryDesc)
VALUES ( 5000, 'Junior Salary'),
       ( 8000, 'Senior Salary'),
       (3000, 'Intern Salary'),
       (6000, 'Mid-level Salary'),
       ( 9000, 'Senior Salary'),
       (4000, 'Junior Salary'),
       ( 7000, 'Mid-level Salary'),
       ( 3500, 'Intern Salary'),
       ( 5500, 'Junior Salary'),
       ( 7500, 'Mid-level Salary');

INSERT INTO Department ( DepDesc, DepType, DepPlace)
VALUES ( 'IT Department', 'Technical', 'Headquarters'),
       ('Sales Department', 'Sales', 'Branch Office'),
       ( 'HR Department', 'Administrative', 'Headquarters'),
       ( 'Marketing Department', 'Marketing', 'Branch Office'),
       ( 'Finance Department', 'Financial', 'Headquarters'),
       ( 'Operations Department', 'Operations', 'Branch Office'),
       ( 'Research Department', 'Research', 'Headquarters'),
       ( 'Support Department', 'Technical', 'Branch Office'),
       ( 'Legal Department', 'Legal', 'Headquarters'),
       ( 'Quality Assurance Department', 'Technical', 'Branch Office');

DECLARE @AccountId INTEGER = 11;
DECLARE @FullName NVARCHAR(255) = 'John Doe';
DECLARE @Email NVARCHAR(255) = 'admin1@gmail.com';
	   
INSERT INTO Account ( FullName, PassWords, Email, RoleId)
VALUES ( 'John Doe', CONVERT(nvarchar(max), HASHBYTES('MD5', 'password123'),2), 'johndoe@example.com', 1),
       ( 'Jane Smith', CONVERT(nvarchar(max), HASHBYTES('MD5', 'pass456'),2), 'janesmith@example.com', 3),
       ( 'Mike Johnson', CONVERT(nvarchar(max), HASHBYTES('MD5', 'abc123'),2), 'mikejohnson@example.com', 2),
       ( 'Sarah Williams', CONVERT(nvarchar(max), HASHBYTES('MD5', 'pwd789'),2), 'sarahwilliams@example.com', 4),
       ( 'David Brown', CONVERT(nvarchar(max), HASHBYTES('MD5', 'securepass'),2), 'davidbrown@example.com', 5),
       ( 'Emily Davis', CONVERT(nvarchar(max), HASHBYTES('MD5','mypassword'),2), 'emilydavis@example.com', 6),
       ( 'Michael Wilson', CONVERT(nvarchar(max), HASHBYTES('MD5', 'password321'),2), 'michaelwilson@example.com', 7),
       ( 'Jessica Taylor', CONVERT(nvarchar(max), HASHBYTES('MD5', 'ilovecoding'),2) , 'jessicataylor@example.com', 8),
       ( 'Andrew Thomas',CONVERT(nvarchar(max), HASHBYTES('MD5', 'thomaspass'),2) , 'andrewthomas@example.com', 9),
       ( 'Olivia Clark',CONVERT(nvarchar(max), HASHBYTES('MD5', 'mypwd123') ,2), 'oliviaclark@example.com', 10),
	   (@FullName, CONVERT(nvarchar(max), HASHBYTES('MD5', '123'), 2),@Email, 2);


INSERT INTO Education ( EducationName)
VALUES
    ( 'High school'),
    ( 'Intermediate'),
    ( 'College'),
    ( 'Undergraduate'),
    ( 'Postgraduate');

INSERT INTO Degree ( DegreeName)
VALUES
    ( 'Bachelor'),
    ('Master'),
    ( 'Doctorate'),
    ( 'Engineer'),
    ('Professor');
    INSERT INTO RelativeEmployee (  FullName, Relationship, PhoneNumber, AddressRelative)
VALUES
    ('Relative 1', 'Sibling', '1111111111', '123 ABC Street'),
    (  'Relative 2', 'Spouse', '2222222222', '456 XYZ Street'),
    ( 'Relative 3', 'Parent', '3333333333', '789 PQR Street'),
    ( 'Relative 4', 'Child', '4444444444', '321 DEF Street'),
    ( 'Relative 5', 'Sibling', '5555555555', '654 UVW Street'),
    ( 'Relative 6', 'Spouse', '6666666666', '987 HIJ Street'),
    ( 'Relative 7', 'Parent', '7777777777', '654 KLM Street'),
    ( 'Relative 8', 'Child', '8888888888', '321 XYZ Street'),
    (  'Relative 9', 'Sibling', '9999999999', '789 PQR Street');

INSERT INTO Employee ( Email, EmployeeName, Avatar, AddressEmployee, Phone, RoleId, AccountId, DepId, SalaryId, EducationId, DegreeId, RelativeId, DateOfBirth, Gender)
VALUES 
    ( 'NguyenNgocHieu@example.com', N'Nguyễn Ngọc Hiếu', 'avatar1.jpg', '123 ABC Street', '1234567890', 3, 1, 1, 3, 4, 1, 1, '1990-01-01', 'Male'),
    ( 'NguyenNgocTrung@example.com', N'Nguyễn Ngọc Trung', 'avatar2.jpg', '456 XYZ Street', '9876543210', 3, 2, 1, 3, 4, 2, 2, '1992-03-15', 'Male'),
    ( 'NgoDangDangTrung@example.com', N'Ngô Đặng Đăng Trung', 'avatar3.jpg', '789 PQR Street', '5555555555', 2, 3, 2, 2, 4, 1, 3, '1988-06-20', 'Male'),
    ( 'HoQuocThang@example.com', N'Hồ Quốc Thắng', 'avatar4.jpg', '321 DEF Street', '4444444444', 4, 4, 3, 4, 5, 3, 4, '1995-09-10', 'Male'),
    ( 'DangDinhHuy@example.com', N'Đặng Đình Huy', 'avatar5.jpg', '654 UVW Street', '3333333333', 6, 5, 4, 5, 3, 2, 5, '1993-12-25', 'Male'),
    ( 'TranVanPhong@example.com', N'Trần Văn Phong', 'avatar6.jpg', '987 HIJ Street', '2222222222', 7, 6, 5, 6, 2, 1, 6, '1991-04-05', 'Male'),
    ( 'NguyenPhanBaoQuy@example.com', N'Nguyễn Phan Bảo Quý', 'avatar7.jpg', '654 KLM Street', '1111111111', 8, 7, 6, 7, 1, 4, 7, '1989-07-15', 'Male'),
    ( 'HuynhPhuocTri@example.com', N'Huỳnh Phước Trí', 'avatar9.jpg', '789 PQR Street', '8888888888', 5, 9, 8, 9, 4, 3, 9, '1994-02-14', 'Male');

INSERT INTO EmployeeHistory (  StartDate, EndDate, Staging)
VALUES
    ( '2019-01-01', '2021-12-31', 'Inactive'),
    ('2020-03-15', '2022-06-30', 'Active'),
    ( '2018-06-20', NULL, 'Inactive'),
    ('2022-01-01', '2023-12-31', 'Inactive'),
    ( '2023-03-15', NULL, 'Active'),
    ( '2021-06-20', '2024-05-04', 'Inactive'),
    ( '2020-09-01', '2022-08-31', 'Active'),
    ('2024-01-01', NULL, 'Inactive'),
    ( '2022-03-15', '2023-06-30', 'Active');