--III)20. Liste des avions de même type que l'avion '747' et mis en service la même année.
SELECT
	DISTINCT *
FROM
	avion
WHERE
	avion.annserv IN (
		SELECT
			DISTINCT annserv
		FROM
			avion av
		WHERE
			fk_typeappareil LIKE '%747%'
	);