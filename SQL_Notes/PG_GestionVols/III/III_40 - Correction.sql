--III)40. Donner le nombre d'avion et le nombre moyen d'heures de vol par type d'avion.

SELECT 
	typeappareil.code, 
	AVG(av.nbhvol) AS moyenne, 
	00
FROM 
	avion av
INNER JOIN 
	typeappareil
ON 
	typeappareil.code = av.fk_typeappareil
GROUP BY 
	typeappareil.code
UNION 
SELECT
	typeappareil.code,
	00, 
	COUNT(DISTINCT avi.noavion) AS nombre
FROM 
	avion avi
INNER JOIN  
	typeappareil
ON 
	typeappareil.code = avi.fk_typeappareil
GROUP BY 
	typeappareil.code
;