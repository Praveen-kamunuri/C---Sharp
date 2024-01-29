-- Select the 'name' column from the 'Customer' table
SELECT name 
-- Filter rows where 'referee_id' is either NULL (not referred by anyone) or not equal to '2' (referred by someone other than customer with id = 2)
FROM Customer 
WHERE referee_id IS NULL OR referee_id != '2';
