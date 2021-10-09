--III)7. Donner la liste des pilotes qui ne perçoivent pas de commission et qui ont un salaire
-- 		 supérieur à 20000. Afficher le nom du pilote et son salaire.
SELECT pil.nom, pil.salaire
FROM pilote pil
WHERE 
(
	(
		(pil.commission = null)
		OR
		(pil.commission <= 0::money)
	)
	AND 
	(pil.salaire > 20000::money)
);

