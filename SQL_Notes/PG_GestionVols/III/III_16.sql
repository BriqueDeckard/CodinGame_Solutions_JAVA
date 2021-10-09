--III)16. Donner la liste des pilotes qui ont le même nom et une adresse différente. Afficher le
--		  nom et l'adresse du pilote.

SELECT adressesA.nompilote, adressesA.ville
FROM adresses adressesA
INNER JOIN adresses adressesB
ON (adressesA.nompilote LIKE adressesB.nompilote)
AND (adressesA.ville != adressesB.ville);



