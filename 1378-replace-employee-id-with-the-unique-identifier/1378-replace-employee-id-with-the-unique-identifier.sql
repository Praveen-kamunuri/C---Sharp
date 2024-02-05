-- Select the unique_id from EmployeeUNI and the name from Employees
SELECT euni.unique_id, e.name
-- From the Employees table (aliased as 'e') 
FROM Employees e
-- Left join with the EmployeeUNI table (aliased as 'euni') based on employee IDs
LEFT JOIN EmployeeUNI euni ON e.id = euni.id;
