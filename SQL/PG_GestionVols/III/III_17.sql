--III)17. Liste des pilotes qui habitent dans une ville de départ d'un vol desservi par un avion
--		  de code type '747'.
SELECT
    pi.nom as nom_pilote,
    ad.nom as adresse,
    de.nom as depart
FROM
    pilote pi
    INNER JOIN affectation af ON af.fk_nopilote = pi.nopilote
    INNER JOIN vol vo ON vo.novol = af.fk_novol
    INNER JOIN avion av ON av.noavion = af.fk_noavion
    INNER JOIN ville ad ON ad.code = pi.fk_ville
    INNER JOIN ville de ON de.code = vo.fk_vildep
WHERE
    av.fk_typeappareil = '%747%'
    AND pi.fk_ville = vo.fk_vildep;