--III)1. Établir la liste des pilotes dont le salaire est compris entre 19000 et 23000. Afficher le nom et le salaire des pilotes.
SELECT
	DISTINCT pil.nom as Pilote,
	pil.salaire
FROM
	pilote pil
WHERE
	(
		pil.salaire BETWEEN 19000 :: money
		AND 23000 :: money
	)
GROUP BY
	pil.nom,
	pil.salaire;