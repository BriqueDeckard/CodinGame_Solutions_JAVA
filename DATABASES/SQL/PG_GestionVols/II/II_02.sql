-- II) 2. Affecter à ce nouveau pilote tous les vols du pilote nommé « DEJEAN Frederic »
UPDATE
	affectation
SET
	fk_nopilote = 43
WHERE
	affectation.fk_nopilote IN (
		SELECT
			pil.nopilote
		FROM
			pilote pil
		WHERE
			pil.nom LIKE '%DEJEAN%'
	);