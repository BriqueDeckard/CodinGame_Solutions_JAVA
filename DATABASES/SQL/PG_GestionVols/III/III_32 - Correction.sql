--III)32. Établir la liste des pilotes qui ont volé sur tous les types d'avions excepté le type C22. Afficher le numéro et le nom des pilotes.
SELECT
	DISTINCT pil.nopilote,
	COUNT(DISTINCT avi.fk_typeappareil) as nbType
FROM
	pilote pil
	INNER JOIN affectation aff ON aff.fk_nopilote = pil.nopilote
	INNER JOIN avion avi ON aff.fk_noavion = avi.noavion
GROUP BY
	pil.nopilote,
	avi.fk_typeappareil
HAVING
	(av.fk_typeappareil != '%C22')
	AND (
		COUNT(DISTINCT avi.fk_typeappareil) = (
			SELECT
				(COUNT(DISTINCT typ.code) -1)
			FROM
				typeappareil typ
		)
	);