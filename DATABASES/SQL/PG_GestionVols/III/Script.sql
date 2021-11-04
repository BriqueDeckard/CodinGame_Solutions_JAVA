--Suppression des tables du dwh ( data warehouse)
DROP TABLE IF EXISTS export_vols;

--Export des vols des pilotes interessants
SELECT
    * INTO export_vols
FROM
    vue_affectation
WHERE
    nompilote LIKE 'a%';

CREATE INDEX idx_nompilote ON export_vols USING btree(nompilote);

--USING sert a indiquer le type de structure qu'on va utiliser pour creer notre index. btree est un arbre balancé.
/*
 Les nœuds feuilles de l'index sont stockés dans un ordre arbitraire en ce sens que la position sur le disque ne correspond pas à 
 la position logique suivant l'ordre de l'index. C'est comme un annuaire téléphonique avec les pages mélangées. Si vous recherchez 
 « Dupont » mais que vous ouvrez l'annuaire à « Canet », il n'est pas garanti que Dupont suive Canet. Une base de données a besoin 
 d'une deuxième structure pour trouver rapide­ment une donnée parmi des pages mélangées : un arbre de recherche équilibré (en anglais,
 un « Balanced Tree Search ») ou, plus court, un B-tree.
 */