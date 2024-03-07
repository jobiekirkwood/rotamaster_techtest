-- 20240307 jk - Rota Master tech test sql quieries

--a. Return the correct amount of shifts for Joseph White along with the role, location, start and end 
SELECT		[Name]
			,[Role]
			,[Location]
			,[Start]
			,[End]

FROM		dbo.Shifts s
JOIN		dbo.People p
ON			s.person_id = p.id
WHERE		person_id	= (SELECT id FROM dbo.People WHERE [Name] like 'Joseph White') 
ORDER BY	[Start]


-- b. Which role has the most shifts and how many shifts are for this role? 
SELECT TOP 1	[Role]
				,COUNT([Role]) rolecount 
FROM			dbo.Shifts 
GROUP BY		[Role] 
ORDER BY		[rolecount] DESC


-- c. Work out the count of total unique locations 
SELECT	COUNT(DISTINCT [location]) [Number of Unique Locations]
FROM	dbo.Shifts

-- d. Work out the shifts for active people where the shift starts between 15th November 2023 + 19th November 2023 
SELECT		s.id,
			p.[name]
			,s.[role]
			,s.[location]
			,s.[start]
			,s.[end]
FROM		dbo.Shifts s
JOIN		dbo.People p
ON			s.person_id = p.id
WHERE		p.active	= 1
AND			s.[start]	BETWEEN '20231115' AND '20231119'
ORDER BY	id





