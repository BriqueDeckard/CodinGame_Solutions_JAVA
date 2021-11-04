--III)24. Donner la liste des avions qui ont volé le 2 mars 2004. Afficher le numéro et le nom des avions.
SELECT
    DISTINCT av.noavion,
    av.nom
FROM
    avion av
    INNER JOIN affectation af ON af.fk_noavion = av.noavion
WHERE
    af.dateaffectation = '2004-03-02';