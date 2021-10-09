--III)43. Donner le nombre de vols différents auquel le pilote numéro '000008' a été affecté.

SELECT count(distinct vol.novol)
FROM vol
INNER JOIN affectation af
ON af.fk_novol = vol.novol
INNER JOIN pilote pil
ON pil.nopilote = af.fk_nopilote
WHERE pil.nopilote = 000008;