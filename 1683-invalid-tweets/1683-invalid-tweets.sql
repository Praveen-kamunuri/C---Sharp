-- Select 'tweet_id' from the 'Tweets' table where the length of 'content' is greater than 15
SELECT tweet_id
FROM Tweets
WHERE LENGTH(content) > 15;
