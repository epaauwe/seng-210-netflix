--AVERGAGE SCORE BY CONTENT ID
SELECT title, CAST(Round(AVG(rating),2) AS decimal(2,1)) AS 'AvgRating'  FROM ContentUser
INNER JOIN Content ON Content.contentID = ContentUser.contentID
WHERE Content.contentID = 3568
GROUP BY title