

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
	SalaryAmount INTEGER  NULL,
	SalaryDesc NVARCHAR(255)  NULL,
	PRIMARY KEY (SalaryId)

);

CREATE TABLE Department (
	DepId INTEGER NOT NULL,
	DepDesc VARCHAR(255)  NULL,
	DepType VARCHAR(255)  NULL,
	DepPlace VARCHAR(255)  NULL,
	PRIMARY KEY (DepId) 
);
CREATE TABLE Account (
	AccountId INTEGER NOT NULL,
	FullName NVARCHAR(255)  NULL,
	PassWords NVARCHAR(255)  NULL,
	Email NVARCHAR(255)  NULL,
	RoleId INTEGER NOT NULL,
	PRIMARY KEY (AccountId),
	FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);
CREATE TABLE Education (
    EducationId INTEGER NOT NULL,
    EducationName NVARCHAR(255)  NULL,
    PRIMARY KEY (EducationId)
);
CREATE TABLE Degree (
    DegreeId INTEGER NOT NULL,
    DegreeName NVARCHAR(255)  NULL,
    PRIMARY KEY (DegreeId)
);

CREATE TABLE RelativeEmployee (
    RelativeId INTEGER NOT NULL,
    EmployeeId INTEGER  NOT NULL,
    FullName NVARCHAR(255)  NULL,
    Relationship NVARCHAR(255)  NULL,
	PhoneNumber VARCHAR(255)  NULL,
    AddressRelative NVARCHAR(255)  NULL,
    PRIMARY KEY (RelativeId),
);

CREATE TABLE Employee (
	EmployId INTEGER NOT NULL ,
	Email NVARCHAR(255)  NULL,
	EmployeeName NVARCHAR(255)  NULL,
	Avatar NVARCHAR(255)  NULL,
	AddressEmployee NVARCHAR(255)  NULL ,
	DateOfBirth DATE NULL,
	Phone VARCHAR(255)  NULL,
	RoleId INTEGER NOT NULL,
	AccountId INTEGER NOT NULL,
	DepId INTEGER NULL,
	SalaryId INTEGER NOT NULL,
	EducationId INTEGER NOT NULL,
    DegreeId INTEGER NOT NULL,
	RelativeId INTEGER NOT NULL,
	Process NVARCHAR NULL,
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
	HistoryId INTEGER NOT NULL ,
	EmployId INTEGER NOT NULL,
	StartDate DATE NULL,
	EndDate DATE NULL,
	Staging VARCHAR(255) NOT NULL,
	PRIMARY KEY (HistoryId),
	FOREIGN KEY(EmployId) REFERENCES Employee(EmployId),
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
VALUES (1, 'John Doe', CONVERT(nvarchar(max), HASHBYTES('MD5', 'password123'),2), 'johndoe@example.com', 1),
       (2, 'Jane Smith', CONVERT(nvarchar(max), HASHBYTES('MD5', 'pass456'),2), 'janesmith@example.com', 3),
       (3, 'Mike Johnson', CONVERT(nvarchar(max), HASHBYTES('MD5', 'abc123'),2), 'mikejohnson@example.com', 2),
       (4, 'Sarah Williams', CONVERT(nvarchar(max), HASHBYTES('MD5', 'pwd789'),2), 'sarahwilliams@example.com', 4),
       (5, 'David Brown', CONVERT(nvarchar(max), HASHBYTES('MD5', 'securepass'),2), 'davidbrown@example.com', 5),
       (6, 'Emily Davis', CONVERT(nvarchar(max), HASHBYTES('MD5','mypassword'),2), 'emilydavis@example.com', 6),
       (7, 'Michael Wilson', CONVERT(nvarchar(max), HASHBYTES('MD5', 'password321'),2), 'michaelwilson@example.com', 7),
       (8, 'Jessica Taylor', CONVERT(nvarchar(max), HASHBYTES('MD5', 'ilovecoding'),2) , 'jessicataylor@example.com', 8),
       (9, 'Andrew Thomas',CONVERT(nvarchar(max), HASHBYTES('MD5', 'thomaspass'),2) , 'andrewthomas@example.com', 9),
       (10, 'Olivia Clark',CONVERT(nvarchar(max), HASHBYTES('MD5', 'mypwd123') ,2), 'oliviaclark@example.com', 10),
	   (@AccountId, @FullName, CONVERT(nvarchar(max), HASHBYTES('MD5', '123'), 2),@Email, 2);


INSERT INTO Education (EducationId, EducationName)
VALUES
    (1, 'High school'),
    (2, 'Intermediate'),
    (3, 'College'),
    (4, 'Undergraduate'),
    (5, 'Postgraduate');

INSERT INTO Degree (DegreeId, DegreeName)
VALUES
    (1, 'Bachelor'),
    (2, 'Master'),
    (3, 'Doctorate'),
    (4, 'Engineer'),
    (5, 'Professor');
INSERT INTO RelativeEmployee (RelativeId, EmployeeId, FullName, Relationship, PhoneNumber, AddressRelative)
VALUES
    (1, 1, 'Relative 1', 'Sibling', '1111111111', '123 ABC Street'),
    (2, 2, 'Relative 2', 'Spouse', '2222222222', '456 XYZ Street'),
    (3, 3, 'Relative 3', 'Parent', '3333333333', '789 PQR Street'),
    (4, 4, 'Relative 4', 'Child', '4444444444', '321 DEF Street'),
    (5, 5, 'Relative 5', 'Sibling', '5555555555', '654 UVW Street'),
    (6, 6, 'Relative 6', 'Spouse', '6666666666', '987 HIJ Street'),
    (7, 7, 'Relative 7', 'Parent', '7777777777', '654 KLM Street'),
    (8, 8, 'Relative 8', 'Child', '8888888888', '321 XYZ Street'),
    (9, 9, 'Relative 9', 'Sibling', '9999999999', '789 PQR Street');

INSERT INTO Employee (EmployId, Email, EmployeeName, Avatar, AddressEmployee, Phone, RoleId, AccountId, DepId, SalaryId, EducationId, DegreeId, RelativeId, DateOfBirth)
VALUES 
    (1, 'NguyenNgocHieu@example.com', N'Nguyễn Ngọc Hiếu', 'avatar1.jpg', '123 ABC Street', '1234567890', 3, 1, 1, 3, 4, 1, 1, '1990-01-01'),
    (2, 'NguyenNgocTrung@example.com', N'Nguyễn Ngọc Trung', 'avatar2.jpg', '456 XYZ Street', '9876543210', 3, 2, 1, 3, 4, 2, 2, '1992-03-15'),
    (3, 'NgoDangDangTrung@example.com', N'Ngô Đặng Đăng Trung', 'avatar3.jpg', '789 PQR Street', '5555555555', 2, 3, 2, 2, 4, 1, 3, '1988-06-20'),
    (4, 'HoQuocThang@example.com', N'Hồ Quốc Thắng', 'avatar4.jpg', '321 DEF Street', '4444444444', 4, 4, 3, 4, 5, 3, 4, '1995-09-10'),
    (5, 'DangDinhHuy@example.com', N'Đặng Đình Huy', 'avatar5.jpg', '654 UVW Street', '3333333333', 6, 5, 4, 5, 3, 2, 5, '1993-12-25'),
    (6, 'TranVanPhong@example.com', N'Trần Văn Phong', 'avatar6.jpg', '987 HIJ Street', '2222222222', 7, 6, 5, 6, 2, 1, 6, '1991-04-05'),
    (7, 'NguyenPhanBaoQuy@example.com', N'Nguyễn Phan Bảo Quý', 'avatar7.jpg', '654 KLM Street', '1111111111', 8, 7, 6, 7, 1, 4, 7, '1989-07-15'),
    (8, 'PhamMinhNhut@example.com', N'Phạm Minh Nhựt', 'avatar8.jpg', '321 XYZ Street', '9999999999', 9, 8, 7, 8, 5, 2, 8, '1996-10-30'),
    (9, 'HuynhPhuocTri@example.com', N'Huỳnh Phước Trí', 'avatar9.jpg', '789 PQR Street', '8888888888', 5, 9, 8, 9, 4, 3, 9, '1994-02-14');


INSERT INTO EmployeeHistory (HistoryId, EmployId, StartDate, EndDate, Staging)
VALUES
    (1, 1, '2019-01-01', '2021-12-31', 'Inactive'),
    (2, 2, '2020-03-15', '2022-06-30', 'Active'),
    (3, 3, '2018-06-20', NULL, 'Inactive'),
    (4, 4, '2022-01-01', '2023-12-31', 'Inactive'),
    (5, 5, '2023-03-15', NULL, 'Active'),
    (6, 6, '2021-06-20', '2024-05-04', 'Inactive'),
    (7, 7, '2020-09-01', '2022-08-31', 'Active'),
    (8, 8, '2024-01-01', NULL, 'Inactive'),
    (9, 9, '2022-03-15', '2023-06-30', 'Active');