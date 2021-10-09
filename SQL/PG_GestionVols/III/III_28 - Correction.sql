--III)28. Donner la liste des vols pour lesquels au moins un pilote ayant effectué 
--		  la liaison habite la ville d'arrivée. Afficher le numéro de vol, la ville de départ
--		  et la ville d'arrivée.

SELECT vol.novol, vol.fk_vilarr, vol.fk_vildep
FROM vol 
INNER JOIN affectation aff
ON aff.fk_novol = vol.novol
WHERE EXISTS
(
	SELECT *
	FROM pilote pil
	WHERE aff.fk_nopilote = pil.nopilote
	AND pil.fk_ville = vol.fk_vilarr
);

SELECT novol, vildep.nom, vilarr.nom 
FROM avion
INNER JOIN affectation aff
ON aff.fk_noavion = avion.noavion
INNER JOIN vol 
ON fk_novol = novol
INNER JOIN pilote 
ON aff.fk_nopilote = pilote.nopilote
INNER JOIN ville vildep 
ON fk_vildep = vildep.code
INNER JOIN ville vilarr
ON fk_vilarr = vilarr.code
WHERE piloote.fk_ville = vildep.code;