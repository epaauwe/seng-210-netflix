
--Populate tables
BULK INSERT content
	FROM 'C:\Users\Evin\Desktop\School\2019\Spring\SENG 210\assignments\group\project\content.csv'
		WITH (FIELDTERMINATOR = ',', ROWTERMINATOR = '\n' , FIRSTROW=2);
		
INSERT INTO [User] VALUES
('Evin','Paauwe','epaauwe','epaauwe'),
('Jesse','Winden','jwinden','jwinden'),
('Jordan','Chicas','jchicas','jchicas'),
('Alec','Petzak','apetzak','apetzak')

INSERT INTO ContentUser VALUES
(789,3,3.4),
(34,3,1.2),
(14,1,5.0),
(3568,3,1.6),
(3568,2,4.6),
(3568,1,3.6)



