--III)2.Établir la liste des vols qui arrivent à Londres avant 12:00. 
-- 		Afficher le numéro de vol, la ville de départ, l'heure de départ et l'heure d'arrivée. 
-- 		La liste sera présentée par ordre alphabétique des villes de départ et par heures de départ croissantes.
SELECT vol.novol, villeDep.nom, vol.dep, vol.arr
FROM vol
INNER JOIN ville villeDep
ON villeDep.code = vol.fk_vildep
INNER JOIN ville villeArr
ON villeArr.code = vol.fk_vilarr
WHERE villeArr.nom LIKE '%Londres%'
AND vol.arr < '12:00:00'
;