--III)13. Donner pour chaque pilote qui est passé par Paris, le numéro de vol et la date
--		  correspondante. Afficher le numéro du pilote, le nom du pilote, le numéro de vol et
--		  la date du vol.
SELECT
	DISTINCT affectation.fk_nopilote AS numero_pilote,
	pilote.nom,
	affectation.fk_novol AS numero_vol,
	affectation.dateaffectation AS date_vol
FROM
	affectation
	INNER JOIN pilote ON pilote.nopilote = affectation.fk_nopilote
WHERE
	affectation.fk_novol IN (
		SELECT
			vue_vol.novol
		FROM
			vue_vol
		WHERE
			(
				(vue_vol.vildep LIKE '%Paris%')
				OR (vue_vol.vilarr LIKE '%Paris%')
			)
	);