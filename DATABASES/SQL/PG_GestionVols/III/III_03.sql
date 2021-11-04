--III)3.Établir la liste des avions qui appartiennent à un type d'appareil dont le premier
--		caractère du code type est '7'. Afficher les numéros d'avion et les types.
SELECT
    DISTINCT av.noavion,
    typA.libelle
FROM
    avion av
    INNER JOIN typeappareil typA ON av.fk_typeappareil = typA.code
WHERE
    typA.code LIKE '7%'
GROUP BY
    av.noavion,
    typA.libelle;