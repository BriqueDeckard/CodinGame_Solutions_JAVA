--III)36. Donner pour chaque pilote, son numéro, son nom, sa date d'embauche, la date de son premier vol.

SELECT pil.nopilote, pil.nom, pil.dateembauche, min(aff.dateaffectation) AS premierVol
FROM pilote pil
INNER JOIN affectation aff
ON aff.fk_nopilote = pil.nopilote
GROUP BY pil.nopilote, pil.nom, pil.dateembauche;