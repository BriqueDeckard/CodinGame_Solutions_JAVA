--III)15. Établir la liste des avions qui sont partis au moins une fois de Paris ou au moins une
--		  fois de Lyon. Afficher uniquement les numéros d'avion.
SELECT
	DISTINCT av.noavion as numero_avion
FROM
	affectation af
	INNER JOIN vue_vol ON vue_vol.novol = af.fk_novol
	INNER JOIN avion av ON av.noavion = af.fk_noavion
WHERE
	(
		(vue_vol.vildep = 'Paris')
		OR (vue_vol.vildep = 'Lyon')
	);