-- Select the 'name', 'population', and 'area' columns from the 'World' table
SELECT name, population, area
-- Filter countries that have an area of at least 3 million or a population of at least 25 million
FROM World
WHERE area >= 3000000 OR population >= 25000000;
