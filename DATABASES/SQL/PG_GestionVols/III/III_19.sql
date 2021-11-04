--III)19. Liste des pilotes affecté à aucun vol.
SELECT
	*
FROM
	pilote pi
WHERE
	pi.nopilote NOT IN (
		SELECT
			af.fk_nopilote
		FROM
			affectation af
	);