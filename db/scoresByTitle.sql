--All Scores By Title
SELECT  Content.title, rating  FROM ContentUser
INNER JOIN Content ON Content.contentID=ContentUSer.ContentID