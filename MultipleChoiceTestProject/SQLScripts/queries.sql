کوئری گزارش افرادی که آزمون را ناقص داده اند 
GO
CREATE VIEW VW_TestLateResponses
AS
SELECT DISTINCT U.Id AS [USERId], U.[Name] AS [USERNAME] FROM [User] AS U
INNER JOIN 
Answer A 
ON U.Id = A.UserId 
INNER JOIN
Test T
ON A.TestId = T.Id
WHERE A.SubmittedAt > T.EndTime

SELECT * from VW_TestLateResponses 


کوئری گزارش افرادی که آزمون را ناقص داده اند 
SELECT  U.[Name] AS USERNAME, TG.[Name] AS TESTGROUP FROM [USER] AS U
LEFT JOIN 
Answer A 
ON U.Id = A.UserId 
LEFT JOIN
Test T
ON T.Id = A.TestId
LEFT JOIN
TestGroup TG
ON T.TestGroupId = TG.Id
WHERE A.Id IS NULL


