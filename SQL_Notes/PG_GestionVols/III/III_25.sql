--III)25. Donner la liste des pilotes qui ont été embauché après le pilote numéro ‘000008’. Afficher le numéro et le nom des pilotes.

SELECT p2.nopilote, p2.nom
FROM pilote p2
WHERE p2.dateembauche >
(
	SELECT DISTINCT p1.dateembauche
	FROM pilote p1
	WHERE p1.nopilote = '000008'
);