               
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

DECLARE @EmployId INTEGER = 2

SELECT * FROM Employee e, Department d, Education ed, Degree de, Roles r
WHERE e.EmployId = @EmployId
AND  e.DepId =  d.DepId
AND e.EducationId = ed.EducationId
AND e.DegreeId = de.DegreeId
AND e.RoleId = r.RoleId



*/