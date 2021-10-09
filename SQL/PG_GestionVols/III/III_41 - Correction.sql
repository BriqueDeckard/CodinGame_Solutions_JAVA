--III)41. Donner le taux moyen de remplissage des avions de type '747'. 
-- Le WHERE est TOUJOURS avant LE GROUP BY
-- Le HAVING se place après le GROUP BY

SELECT 
	CAST
	(
		AVG
		(
			af.nbpassagers*100 / ta.nbplaces
		) 
		AS DECIMAL(16,2)
	) 
	AS moyenne
FROM 
	affectation af
INNER JOIN 
	avion av
ON 
	av.noavion = af.fk_noavion
INNER JOIN 
	typeappareil ta
ON 
	ta.code = av.fk_typeappareil
WHERE 
(
	ta.code 
	LIKE '%747%'
);

SELECT aff.fk_novol