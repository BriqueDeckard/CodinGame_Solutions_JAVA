--III)31. Donner le numéro, le nom et le montant de la commission du pilote qui a la plus faible commission non nulle.

SELECT pi.nopilote, pi.nom, pi.commission 
FROM pilote pi
WHERE
(
	pi.commission IN
	(
		SELECT MIN(pi.commission)
		FROM pilote pi
		WHERE pi.commission > 0::money
	)
);