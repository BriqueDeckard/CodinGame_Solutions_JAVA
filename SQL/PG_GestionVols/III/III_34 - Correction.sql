--III)34. Donner le nombre de jours qui sépare la date d'embauche du premier pilote embauché et la date d'embauche 
--		  du dernier pilote embauché.


SELECT (MAX(pil.dateembauche)-MIN(pil.dateembauche))
FROM pilote pil;