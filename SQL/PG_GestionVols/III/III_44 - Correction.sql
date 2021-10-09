--III)44. Donner la liste des avions qui ont été pilotés par plus de deux pilotes. 
--		  Afficher le numéro des avions et le nom des pilotes. Afficher le numéro et le nom des avions.
SELECT
    DISTINCT av.noavion,
    av.nom
FROM
    avion av
    INNER JOIN affectation af ON af.fk_noavion = av.noavion
    INNEr JOIN pilote pil ON pil.nopilote = af.fk_nopilote
GROUP BY
    av.noavion,
    av.nom
HAVING
    count(DISTINCT af.fk_nopilote) >= 2
ORDER BY
    av.nom;