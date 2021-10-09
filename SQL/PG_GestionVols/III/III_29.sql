--III)29. Donner la liste des pilotes qui n'ont jamais été affecté à un vol. Afficher le numéro du pilote.
SELECT
	pi.nopilote
FROM
	pilote pi
WHERE
	pi.nopilote NOT IN (
		SELECT
			af.fk_nopilote
		FROM
			affectation af
	);