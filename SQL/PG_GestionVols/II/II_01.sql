-- II) 1. Ajouter un nouveau pilote
INSERT INTO pilote 
(
	nopilote, 
	nom, 
	fk_ville, 
	salaire, 
	commission, 
	dateembauche
)
VALUES 
(
	42, 
	'Amelia EARHART',
	'00001',
	12345,
	1234,
	'1922-09-12'
);