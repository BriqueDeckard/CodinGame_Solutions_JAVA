--III)26. Quels sont les avions qui sont partis de Paris ou de Lyon. Afficher les numéros et les noms.

SELECT av.noavion, av.nom
FROM avion av
INNER JOIN affectation af
ON af.fk_noavion = av.noavion
INNER JOIN vol vo
ON vo.novol = af.fk_novol
INNER JOIN ville vd
ON vo.fk_vildep = vd.code
WHERE 
(
	(
		vd.nom LIKE '%Paris%'
	)
	OR
	(
		vd.nom LIKE '%Lyon%'
	)
);