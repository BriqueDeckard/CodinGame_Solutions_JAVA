--III)	29. Donner la liste des pilotes qui n'ont jamais été affecté à un vol. Afficher le numéro du pilote.
--
SELECT
	pil.nopilote
FROM
	pilote pil
WHERE
	pil.nopilote NOT IN (
		SELECT
			aff.fk_nopilote
		FROM
			affectation aff
	);

--
SELECT
	pil.nopilote
FROM
	pilote pil
WHERE
	pil.nopilote NOT EXISTS (
		SELECT
			aff.fk_nopilote
		FROM
			affectation aff
	);

--	Avec un Left Join --> Les valeurs "NULL" représente l'absence de résultat
SELECT
	nopilote,
	pilote.nom
FROM
	pilote
	LEFT JOIN affectation aff ON pilote.nopilote = aff.fk_nopilote
WHERE
	fk_nopilote IS NULL;