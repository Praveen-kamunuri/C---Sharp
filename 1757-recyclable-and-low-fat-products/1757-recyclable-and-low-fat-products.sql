# Write your MySQL query statement below

-- Select the product_id from the Products table
SELECT product_id 
-- Filter rows where low_fats column is 'Y' and recyclable column is 'Y'
FROM Products 
WHERE low_fats = 'Y' AND recyclable = 'Y';
