               
/*

Solution1 tìm tên phòng ban

DECLARE @DepDesc NVARCHAR(255) = 'IT Department'
SELECT * FROM Department WHERE DepDesc LIKE '%' + @DepDesc + '%'

Solution 2 tìm nhân viên trong phòng ban
DECLARE @DepDesc NVARCHAR(255) = 'hr department'
SELECT * 
FROM Employee e, Department d 
WHERE  e.DepId = d.DepId
--AND DepDesc LIKE '%' + @DepDesc + '%'
AND DepDesc LIKE  + @DepDesc


solution 3 tìm id phòng ban
DECLARE @DepId INTEGER = 2
SELECT * FROM Department  WHERE DepId = @DepId


solution 4 xoá nhân viên ra khỏi phòng ban
DECLARE @EmployId INTEGER = 2
UPDATE Employee
SET DepId = NULL
WHERE EmployId IN (
    SELECT e.EmployId
    FROM Department d,Employee e
    WHERE d.DepId = e.DepId
	AND e.EmployId = @EmployId
)

xem danh sách
SELECT * FROM Department d, Employee e WHERE e.DepId = d.DepId


xem danh sách 
SELECT * FROM Employee
SELECT * FROM Roles

solution 5  tìm kiếm nhân viên
DECLARE  @EmployeeName NVARCHAR(255) = N'Đ'
SELECT * FROM Employee WHERE EmployeeName LIKE  '%' + @EmployeeName + '%'


solution 6 thêm nhân viên
DECLARE  @Email NVARCHAR(255) = 'DangVanDung@example.com'
DECLARE  @EmployeeName NVARCHAR(255) = N'Đặng Văn Dung'
DECLARE  @AddressEmployee NVARCHAR(255) = '123 ABC Street'
DECLARE  @Phone NVARCHAR(255) = '1234567890'
DECLARE  @DateOfBirth DATE = '1990-01-01'
DECLARE  @RoleId INTEGER = 3
DECLARE  @Gender NVARCHAR(255) = 'Male'

INSERT INTO Employee (EmployId, Email, EmployeeName, AddressEmployee, Phone, RoleId,  DateOfBirth, Gender)
VALUES 
    (12, @Email, @EmployeeName, @AddressEmployee,@Phone ,@RoleId,@DateOfBirth,@Gender);


solution 7 employeee, department, education, degreee, roles

DECLARE @EmployId INTEGER = 12222

SELECT * FROM Employee e
WHERE e.EmployId = @EmployId


DECLARE @EmployId INTEGER = 12222

SELECT * FROM Employee e, Department d, Education ed, Degree de, Roles r
WHERE e.EmployId = @EmployId
AND  e.DepId =  d.DepId
AND e.EducationId = ed.EducationId
AND e.DegreeId = de.DegreeId
AND e.RoleId = r.RoleId


khi các ID tương ứng là rỗng
các dòng từ bảng Employee vẫn được hiển thị, ngay cả khi không có kết quả tương ứng
DECLARE @EmployId INTEGER = 2
SELECT *
FROM Employee e
LEFT JOIN Department d ON e.DepId = d.DepId
LEFT JOIN Education ed ON e.EducationId = ed.EducationId
LEFT JOIN Degree de ON e.DegreeId = de.DegreeId
LEFT JOIN Roles r ON e.RoleId = r.RoleId
WHERE e.EmployId = @EmployId


solution 8  xoá người dùng

DECLARE @EmployId INTEGER = 21122
DELETE FROM Employee WHERE EmployId = @EmployId;

SOLUTION 9 CẬP NHẬT NHÂN VIÊN

DECLARE @EmployeeName NVARCHAR(255) = 'Tên nhân viên';
DECLARE @AddressEmployee NVARCHAR(255)  = 'Địa chỉ nhân viên';
DECLARE @Phone NVARCHAR(255) = 'Số điện thoại';
DECLARE @Email NVARCHAR(255)= 'Email';
DECLARE @DateOfBirth DATETIME  = '1990-01-01';
DECLARE @Gender NVARCHAR(255) = 'Male';
DECLARE @EmployId INTEGER = 1;



UPDATE Employee 
SET 
EmployeeName = @EmployeeName,
AddressEmployee = @AddressEmployee, 
Phone = @Phone, 
Email = @Email, 
DateOfBirth = @DateOfBirth ,
Gender = @Gender
WHERE EmployId = @EmployId



thêm 

UPDATE Employee 
SET EmployeeName = @EmployeeName, 
AddressEmployee = @AddressEmployee, 
Phone = @Phone, Email = @Email, 
DateOfBirth = @DateOfBirth , 
Gender = @Gender , 
DepId = @DepId, 
DegreeId = @DegreeId,
EducationId = @EducationId 
WHERE EmployId = @EmployId

DECLARE @EmployId INTEGER = 2
DECLARE @DepId INTEGER = 1

UPDATE Employee SET DepId = @DepId WHERE EmployId = @EmployId

solution 9 cập nhật phòng ban
UPDATE Department SET DepPlace = @DepPlace, DepType = @DepType, DepDesc = @DepDesc WHERE DepId = @DepId 

SOLUTION 10 TÌM NHÂN VIÊN CHƯA CÓ PHÒNG
SELECT *
FROM Employee
WHERE DepId IS NULL;


SELECT * FROM EmployeeHistory
SELECT * FROM Roles r , Employee e WHERE r.RoleId = e.RoleId





solution 11 xuất lịch sử làm việc
EmployeeName: Tên của nhân viên.
StartDate: Ngày bắt đầu làm việc.
EndDate: Ngày kết thúc làm việc.
Staging: Thông tin về giai đoạn công việc.

SELECT E.EmployeeName, EH.StartDate, EH.EndDate, EH.Staging
FROM Employee E
INNER JOIN EmployeeHistory EH ON E.EmployId = EH.EmployId
ORDER BY E.EmployeeName, EH.StartDate ASC




SELECT E.EmployeeName, EC.StartDate, EC.EndDate, EC.Staging
FROM Employee E
INNER JOIN EmployeeHistory EC ON E.EmployId = EC.EmployId
ORDER BY E.EmployeeName, EC.StartDate ASC




solution 12 xuất lý lịch nhân viên
DECLARE @EmployId INTEGER = 2
SELECT E.EmployId, E.EmployeeName, E.Email,  E.AddressEmployee, E.DateOfBirth, E.Phone, 
       E.Gender, R.RoleName, D.DepDesc, S.SalaryAmount, Edu.EducationName, Deg.DegreeName, 
       RE.FullName as RelativeName, RE.Relationship, RE.PhoneNumber, RE.AddressRelative
FROM Employee E
LEFT JOIN Roles R ON E.RoleId = R.RoleId
LEFT JOIN Department D ON E.DepId = D.DepId
LEFT JOIN Salary S ON E.SalaryId = S.SalaryId
LEFT JOIN Education Edu ON E.EducationId = Edu.EducationId
LEFT JOIN Degree Deg ON E.DegreeId = Deg.DegreeId
LEFT JOIN RelativeEmployee RE ON E.RelativeId = RE.RelativeId
LEFT JOIN Account ac ON E.AccountId = ac.AccountId
WHERE E.EmployId = @EmployId



solution 13   xuất lịch sử luân chuyển nahan viên

DECLARE @EmployId INTEGER = 5
SELECT EH.StartDate, EH.EndDate, EH.Staging
FROM EmployeeHistory EH, Employee E
WHERE E.EmployId = EH.EmployId 
AND  E.EmployId = @EmployId
ORDER BY EH.StartDate;



solution 14 xuất lịch sử làm việc
DECLARE @EmployId INTEGER = 5
SELECT E.EmployId, E.EmployeeName, EH.StartDate, EH.EndDate, EH.Staging
FROM Employee E
INNER JOIN EmployeeHistory EH ON E.EmployId = EH.EmployId
WHERE E.EmployId =  @EmployId 
ORDER BY EH.StartDate;



SELECT * FROM Salary



solution 15 tìm nhân chứa mức lương
DECLARE @SalaryId INTEGER = 4
SELECT *
FROM Salary s
LEFT JOIN Employee e ON e.SalaryId = s.SalaryId
WHERE s.SalaryId = @SalaryId



SELECT * FROM Roles r , Employee e WHERE r.RoleId = e.RoleId

DECLARE @EmployId INTEGER = 5

SELECT *
FROM Employee e
LEFT JOIN Department d ON e.DepId = d.DepId
LEFT JOIN Education ed ON e.EducationId = ed.EducationId
LEFT JOIN Degree de ON e.DegreeId = de.DegreeId
LEFT JOIN Roles r ON e.RoleId = r.RoleId
LEFT JOIN EmployeeHistory eh ON e.EmployId = eh.EmployId
LEFT JOIN Salary s ON e.SalaryId = s.SalaryId
WHERE e.EmployId = @EmployId


DECLARE @EmployId INTEGER = 5
SELECT *
FROM Employee e
LEFT JOIN Department d ON e.DepId = d.DepId
LEFT JOIN Education ed ON e.EducationId = ed.EducationId
LEFT JOIN Degree de ON e.DegreeId = de.DegreeId
LEFT JOIN Roles r ON e.RoleId = r.RoleId
LEFT JOIN EmployeeHistory eh ON e.EmployId = eh.EmployId
LEFT JOIN Salary s ON e.SalaryId = s.SalaryId
LEFT JOIN Account ac ON e.AccountId = ac.AccountId
WHERE e.EmployId = @EmployId




DECLARE @EmployId INTEGER = 2
DECLARE @DepId INTEGER = 1
DECLARE @RoleId INTEGER = 1
DECLARE @EducationId INTEGER = 1
DECLARE @AccountId INTEGER = 1
DECLARE @DegreeId INTEGER = 1
DECLARE @EmployeeName NVARCHAR(255) = 'Tên nhân viên';
DECLARE @AddressEmployee NVARCHAR(255)  = 'Địa chỉ nhân viên';
DECLARE @Phone NVARCHAR(255) = 'Số điện thoại';
DECLARE @Email NVARCHAR(255)= 'Email';
DECLARE @DateOfBirth DATETIME  = '1990-01-01';
DECLARE @Gender NVARCHAR(255) = 'Male';


UPDATE Employee 
SET EmployeeName = @EmployeeName, 
AddressEmployee = @AddressEmployee, 
Phone = @Phone, 
Email = @Email, 
DateOfBirth = @DateOfBirth , 
Gender = @Gender  , 
AccountId = @AccountId ,
DepId = @DepId , 
EducationId = @EducationId, 
RoleId = @RoleId, 
DegreeId = @DegreeId
WHERE EmployId = @EmployId 


DECLARE @EmployId INTEGER = 2

SELECT * FROM Employee E 
LEFT JOIN RelativeEmployee RE ON E.RelativeId = RE.RelativeId
WHERE EmployId = @EmployId


*/
