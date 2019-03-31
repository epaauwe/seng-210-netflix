--All Scores By Title,With User name
SELECT  Content.title, rating, [User].fName +' ' + [User].lName AS "User" FROM ContentUser
INNER JOIN Content ON Content.contentID=ContentUser.ContentID
INNER JOIN [User] ON [User].userID=ContentUser.userID