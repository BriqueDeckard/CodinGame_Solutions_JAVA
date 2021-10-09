--III)31. Donner le numéro, le nom et le montant de la commission du pilote qui a la plus faible commission non nulle.
-- L'aggregat "MIN" exclue les nulls;
SELECT pil.nopilote, pil.nom, pil.commission 
FROM pilote pil
WHERE
(
	pil.commission IN
	(
		SELECT MIN(pil.commission)
		FROM pilote pil
		WHERE pil.commission > 0::money
	)
);

SELECT pil.nopilote, pil.nom, pil.commission 
FROM pilote pil
WHERE pilote.commission = 
(
	SELECT MIN(pil2.commission) 
	FROM pilote pil2
);

SELECT pil.nopilote, pil.nom, pil.commission
FROM pilote pil
WHERE pil.commission IS NOT NULL
ORDER BY pil.commission DESC 
LIMIT 1 ;