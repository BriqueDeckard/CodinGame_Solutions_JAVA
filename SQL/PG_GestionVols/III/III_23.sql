--III)23. Liste des avions de même type que l'avion n°20 et mis en service la même année.
SELECT
	DISTINCT *
FROM
	avion
WHERE
	(
		(
			avion.annserv IN (
				SELECT
					DISTINCT annserv
				FROM
					avion av
				WHERE
					noavion = 20
			)
		)
		AND (
			avion.fk_typeappareil IN (
				SELECT
					DISTINCT fk_typeappareil
				FROM
					avion av
				WHERE
					noavion = 20
			)
		)
	);