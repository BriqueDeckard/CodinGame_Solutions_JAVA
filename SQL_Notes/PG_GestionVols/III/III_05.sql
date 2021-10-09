--III)5. Donner la liste alphabétique des pilotes qui habitent Paris et qui ont été embauchés
--		 avant le 1 janvier 2001 ou après le 1 janvier 2008. Afficher les noms des pilotes, leur
--		 date d'embauche et leur adresse.
CREATE OR REPLACE VIEW adresses AS
(
	SELECT 
		pil.nopilote AS nopilote, 
		pil.nom AS nompilote, 
		ville.code AS codeville, 
		ville.nom AS ville
	FROM 
		pilote pil
	INNER JOIN 
		ville
	ON 
		ville.code = pil.fk_ville
);

SELECT 
	pil.nom, 
	pil.dateembauche, 
	adr.ville
FROM 
	pilote pil
INNER JOIN 
	adresses adr
ON 
	adr.nopilote = pil.nopilote
AND
	adr.ville LIKE 	'%Paris%'
AND
	pil.dateembauche < '2001-01-01';