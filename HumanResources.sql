

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
    Activities NVARCHAR(255) NULL,
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
       (6000, 'Mid-level Salary')
      

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
    (N'Nguyễn Văn An', N'Cha', '1111111111', '123 ABC Street'),
    (N'Trần Thị Bình', N'Mẹ', '2222222222', '456 XYZ Street'),
    (N'Lê Văn Cường', N'Anh trai', '3333333333', '789 PQR Street'),
    (N'Phạm Thị Diễm', N'Chị gái', '4444444444', '321 DEF Street'),
    (N'Hoàng Văn Dũng', N'Chồng', '5555555555', '654 UVW Street'),
    (N'Vũ Thị Hà', N'Vợ', '6666666666', '987 HIJ Street'),
    (N'Đặng Văn Giang', N'Ông', '7777777777', '654 KLM Street'),
    (N'Bùi Thị Hoa', N'Bà', '8888888888', '321 XYZ Street'),
    (N'Đỗ Văn Huy', N'Cô', '9999999999', '789 PQR Street');

INSERT INTO Employee ( Email, EmployeeName, Avatar, AddressEmployee, Phone, RoleId, AccountId, DepId, SalaryId, EducationId, DegreeId, RelativeId, DateOfBirth, Gender)
VALUES 
 ('NguyenNgocHieu@example.com', N'Nguyễn Ngọc Hiếu', 'avatar1.jpg', N'Tên đường A, Hồ Chí Minh', '0987654321', 3, 1, 1, 3, 4, 1, 1, '1990-01-01', 'Male'),
    ('NguyenNgocTrung@example.com', N'Nguyễn Ngọc Trung', 'avatar2.jpg', N'Tên đường B, Đà Nẵng', '0987654321', 3, 2, 1, 3, 4, 2, 2, '1992-03-15', 'Male'),
    ('NgoDangDangTrung@example.com', N'Ngô Đặng Đăng Trung', 'avatar3.jpg', N'Tên đường C, Hải Phòng', '0987654321', 2, 3, 2, 2, 4, 1, 3, '1988-06-20', 'Male'),
    ('HoQuocThang@example.com', N'Hồ Quốc Thắng', 'avatar4.jpg', N'Tên đường D, Huế', '0987654321', 4, 4, 3, 4, 5, 3, 4, '1995-09-10', 'Male'),
    ('DangDinhHuy@example.com', N'Đặng Đình Huy', 'avatar5.jpg', N'Tên đường E, Nha Trang', '0987654321', 6, 5, 4,3, 3, 2, 5, '1993-12-25', 'Male'),
    ('TranVanPhong@example.com', N'Trần Văn Phong', 'avatar6.jpg', N'Tên đường F, Cần Thơ', '0987654321', 7, 6, 5,2, 2, 1, 6, '1991-04-05', 'Male'),
    ('NguyenPhanBaoQuy@example.com', N'Nguyễn Phan Bảo Quý', 'avatar7.jpg', N'Tên đường G, Vũng Tàu', '0987654321', 8, 7, 6,4, 1, 4, 7, '1989-07-15', 'Male'),
    ('HuynhPhuocTri@example.com', N'Huỳnh Phước Trí', 'avatar9.jpg', N'Tên đường H, Hà Nội', '0987654321', 5, 9, 8,3, 4, 3, 9, '1994-02-14', 'Male'),
    ('NguyenThiThap@example.com', N'Nguyễn Thị Thập', 'avatar1.jpg', N'Tên đường A, Hồ Chí Minh', '0987654321', 3, 1, 1, 3, 4, 1, 1, '1990-01-01', 'Female'),
    ('NguyenVanCu@example.com', N'Nguyễn Văn Cừ', 'avatar2.jpg', N'Tên đường B, Đà Nẵng', '0987654321', 3, 2, 1, 3, 4, 2, 2, '1992-03-15', 'Male'),
    ('PhamVanLinh@example.com', N'Phạm Văn Linh', 'avatar3.jpg', N'Tên đường C, Hải Phòng', '0987654321', 2, 3, 2, 2, 4, 1, 3, '1988-06-20', 'Male'),
    ('NguyenThiThu@example.com', N'Nguyễn Thị Thu', 'avatar4.jpg', N'Tên đường D, Huế', '0987654321', 4, 4, 3, 4, 5, 3, 4, '1995-09-10', 'Female'),
    ('TranVanBinh@example.com', N'Trần Văn Bình', 'avatar5.jpg', N'Tên đường E, Nha Trang', '0987654321', 6, 5, 4,3, 3, 2, 5, '1993-12-25', 'Male'),
    ('LeThiMinh@example.com', N'Lê Thị Minh', 'avatar6.jpg', N'Tên đường F, Cần Thơ', '0987654321', 7, 6, 5,2, 2, 1, 6, '1991-04-05', 'Female'),
    ('HoangVanNam@example.com', N'Hoàng Văn Nam', 'avatar7.jpg', N'Tên đường G, Vũng Tàu', '0987654321', 8, 7, 6,1, 1, 4, 7, '1989-07-15', 'Male'),
    ('TranThiMy@example.com', N'Trần Thị Mỹ', 'avatar9.jpg', N'Tên đường H, Hà Nội', '0987654321', 5, 9, 8,3, 4, 3, 9, '1994-02-14', 'Female');
INSERT INTO EmployeeHistory (EmployId, StartDate, EndDate, Staging, Activities)
VALUES
    (1, '2019-01-01', '2021-12-31', 'Inactive','Transfer'),
    (2, '2020-03-15', '2022-06-30', 'Inactive', 'Transer'),
    (3, '2018-06-20', NULL, 'Active','Transer'),
    (4, '2022-01-01', '2023-12-31', 'Inactive', 'Transer'),
    (5, '2023-03-15', NULL, 'Active', 'Transer'),
    (6, '2021-06-20', '2024-05-04', 'Inactive', 'Transer'),
    (7, '2020-09-01', '2022-08-31', 'InActive', 'Transer'),
    (8, '2024-01-01', NULL, 'Active', 'Transer');
