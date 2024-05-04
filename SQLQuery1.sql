
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


*/