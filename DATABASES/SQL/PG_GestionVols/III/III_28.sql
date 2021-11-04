--III)28. Donner la liste des vols pour lesquels au moins un pilote ayant effectué 
--		  la liaison habite la ville d'arrivée. Afficher le numéro de vol, la ville de départ
--		  et la ville d'arrivée.
SELECT
	vol.novol,
	vol.fk_vilarr,
	vol.fk_vildep
FROM
	vol
	INNER JOIN affectation aff ON aff.fk_novol = vol.novol
WHERE
	EXISTS (
		SELECT
			*
		FROM
			pilote pil
		WHERE
			aff.fk_nopilote = pil.nopilote
			AND pil.fk_ville = vol.fk_vilarr
	);