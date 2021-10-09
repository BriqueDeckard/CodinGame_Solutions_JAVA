--III)6.
CREATE OR REPLACE VIEW vols_villes AS
(
	SELECT 
		vol.novol AS novol,
		vildep.nom AS ville_depart, 
		vilarr.nom AS ville_arrivee
	FROM 
		vol
	INNER JOIN 
		ville vildep
	ON vildep.code = vol.fk_vildep
	INNER JOIN
		ville vilarr
	ON vilarr.code = vol.fk_vilarr
);

SELECT 
	v_v.novol, 
	v_v.ville_depart, 
	vol.dep
FROM 
	vols_villes v_v
INNER JOIN
	vol
ON vol.novol = v_v.novol
INNER JOIN
	affectation aff
ON aff.fk_novol = vol.novol
ORDER BY v_v.ville_depart, vol.dep;

