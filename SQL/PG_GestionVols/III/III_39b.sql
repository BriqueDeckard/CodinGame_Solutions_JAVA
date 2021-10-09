--III)39. Donner la liste des pilotes embauchés le même mois et la même année que le pilote numéro '000011'. 
--		  Afficher le numéro, le nom, le mois et l'année d'embauche du pilote.

SELECT 
	pi1.nopilote, 
	pi1.nom, 
	date_part('month', pi1.dateembauche), 
	date_part('year', pi1.dateembauche)
FROM 
	pilote pi1
GROUP BY 
	pi1.nopilote 
HAVING
(
	(
		date_part('month', pi1.dateembauche) =
		(
			SELECT date_part('month', pi2.dateembauche)
			FROM pilote pi2
			WHERE pi2.nopilote = '000011'
		)
		AND
		date_part('year', pi1.dateembauche) =
		(
			SELECT date_part('year', pi2.dateembauche)
			FROM pilote pi2
			WHERE pi2.nopilote = '000011'
		)
	)
)
;