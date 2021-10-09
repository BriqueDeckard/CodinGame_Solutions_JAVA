--III)11. Donner pour chaque pilote de la base de données, la liste des villes à partir
--		  desquelles il n'a jamais décollé. Afficher le numéro du pilote, le nom du pilote
--		  et la ville.

SELECT pilote.nom, ville.nom
FROM pilote, vol
INNER JOIN ville 
ON ville.code = vol.fk_vildep
WHERE NOT EXISTS (
	SELECT DISTINCT pil.nopilote, vilvol.fk_vildep
	FROM pilote pil
	INNER JOIN affectation af ON pil.nopilote = af.fk_nopilote
	INNER JOIN vol vilvol ON af.fk_novol = vilvol.novol
	WHERE pil.nopilote = pilote.nopilote
	AND vilvol.fk_vildep = vol.fk_vildep
)
GROUP BY pilote.nom, ville.nom
ORDER BY pilote.nom, ville.nom
;
