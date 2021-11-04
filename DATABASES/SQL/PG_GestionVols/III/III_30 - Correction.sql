--III)30. Donner le numéro, le nom et le salaire du pilote qui a le salaire le plus élevé.
-- Les fonction d'aggregation sont natives, et peuvent/doivent être executées à "bas niveau" (= PLUS RAPIDE/PAS DE TRANSFERT DE DONNEES)
-- potentiels "doublons" mais plus "juste"
--
SELECT
	pil.nopilote,
	pil.nom,
	pil.salaire :: money
FROM
	pilote pil
WHERE
	pil.salaire IN (
		SELECT
			max(pil.salaire)
		FROM
			pilote pil
	);

-- Utiliser le tri et limiter les resultats, pas de doublon mais potentiellementt faux
--
SELECT
	pil.nopilote,
	pil.nom,
	pil.salaire :: money
FROM
	pilote pil
ORDER BY
	pil.salaire DESC
LIMIT
	1;