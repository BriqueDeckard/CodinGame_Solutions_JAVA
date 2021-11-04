--III)42. Afficher le numéro et le nom du dernier pilote embauché
SELECT
	pil.nopilote,
	pil.nom
FROM
	pilote pil
WHERE
	pil.dateembauche IN (
		SELECT
			max(pil.dateembauche)
		FROM
			pilote pil
	);