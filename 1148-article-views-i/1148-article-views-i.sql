-- Select distinct 'author_id' from the 'Views' table 
-- where 'author_id' is equal to 'viewer_id' (indicating that the author viewed their own article)
SELECT DISTINCT author_id AS id
FROM Views
WHERE author_id = viewer_id
-- Order the result by 'author_id' in ascending order
ORDER BY author_id;
