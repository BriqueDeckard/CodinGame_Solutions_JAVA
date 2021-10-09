--III)10.Donner pour chaque pilote de la base de données, la liste des villes à partir
--	 	 desquelles il a effectué un vol. Afficher le numéro du pilote, le nom du pilote, et la
--		 ville de départ.
SELECT
	DISTINCT pil.nopilote,
	pil.nom,
	vildep.nom
FROM
	pilote pil
	INNER JOIN affectation af ON af.fk_nopilote = pil.nopilote
	INNER JOIN vol ON vol.novol = af.fk_novol
	INNER JOIN ville vildep ON vildep.code = vol.fk_vildep
WHERE
	pil.nopilote IN (
		SELECT
			fk_nopilote
		FROM
			affectation
	)
GROUP BY
	pil.nopilote,
	pil.nom,
	vildep.nom;