--III)32. Établir la liste des pilotes qui ont volé sur tous les types d'avions excepté le type C22. Afficher le numéro et le nom des pilotes.
SELECT
	DISTINCT pi.nopilote,
	COUNT(DISTINCT av.fk_typeappareil) as nbType
FROM
	pilote pi
	INNER JOIN affectation af ON af.fk_nopilote = pi.nopilote
	INNER JOIN avion av ON af.fk_noavion = av.noavion
GROUP BY
	pi.nopilote,
	av.fk_typeappareil
HAVING
	(av.fk_typeappareil != '%C22')
	AND (
		COUNT(DISTINCT av.fk_typeappareil) = (
			SELECT
				(COUNT(DISTINCT ty.code) -1)
			FROM
				typeappareil ty
		)
	);