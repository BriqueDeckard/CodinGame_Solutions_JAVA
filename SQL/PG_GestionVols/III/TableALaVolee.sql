--table a la volée
--Export des vols des pilotes interessants
SELECT
    * INTO export_vols
FROM
    vue_affectation
WHERE
    nompilote LIKE 'a%';