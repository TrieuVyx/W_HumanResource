
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


xem danh sách employee
SELECT * FROM Employee
*/