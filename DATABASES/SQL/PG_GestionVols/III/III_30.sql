--III)30. Donner le numéro, le nom et le salaire du pilote qui a le salaire le plus élevé.
SELECT
	pi.nopilote,
	pi.nom,
	pi.salaire :: money
FROM
	pilote pi
WHERE
	pi.salaire IN (
		SELECT
			max(pi.salaire)
		FROM
			pilote pi
	);