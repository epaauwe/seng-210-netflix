/*	
Build database,
Build tables	
*/
CREATE DATABASE [NetflixRec]

USE [NetflixRec]
GO

CREATE TABLE Content (
contentID INT IDENTITY PRIMARY KEY,
[year] SMALLINT NULL,
title VARCHAR(MAX));

		
CREATE TABLE [User] (
userID INT IDENTITY PRIMARY KEY,
fName VARCHAR(320),
lName VARCHAR(320),
[login] VARCHAR(320),
[password] VARCHAR(320)
);

CREATE TABLE ContentUser (
contentID INT NOT NULL,
userID INT NOT NULL,
rating DECIMAL(2,1),
FOREIGN KEY (contentID) REFERENCES Content(contentID),
FOREIGN KEY (userID)	REFERENCES [User](userID),
PRIMARY KEY (contentID,userID)
);
		
