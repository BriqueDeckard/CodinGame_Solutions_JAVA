--III)41. Donner le taux moyen de remplissage des avions de type '747'.

SELECT CAST(avg(af.nbpassagers*100 / ta.nbplaces) AS DECIMAL(16,2)) as moyenne
FROM affectation af
INNER JOIN avion av
ON av.noavion = af.fk_noavion
INNER JOIN typeappareil ta
ON ta.code = av.fk_typeappareil
WHERE ta.code LIKE '%747%';