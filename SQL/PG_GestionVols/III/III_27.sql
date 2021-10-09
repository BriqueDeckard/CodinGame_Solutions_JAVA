--III)27. Quels sont les avions qui sont partis au moins une fois de Paris et au moins une fois de Lyon.
SELECT av.noavion, av.nom
FROM avion av
INNER JOIN affectation af
ON af.fk_noavion = av.noavion
INNER JOIN vol
ON vol.novol = af.fk_novol
WHERE EXISTS 
(
	SELECT *
	FROM ville
	WHERE vol.fk_vildep = ville.code
	AND 
	(
		(ville.nom LIKE '%Londres%')
		OR
		(ville.nom LIKE '%Paris%')
	)
	
);