--III)39. Donner la liste des pilotes embauchés le même mois et la même année que le pilote numéro '000011'. 
--		  Afficher le numéro, le nom, le mois et l'année d'embauche du pilote.
SELECT
	pil.nopilote,
	pil.nom,
	date_part('month', pil.dateembauche) as MM,
	date_part('year', pil.dateembauche) as YY
FROM
	pilote pil
GROUP BY
	pil.nopilote,
	pil.nom,
	MM,
	YY
HAVING
	date_part('year', pil.dateembauche) IN (
		SELECT
			date_part('year', pilo.dateembauche)
		FROM
			pilote pilo
		WHERE
			pil.nopilote = 000011
	);