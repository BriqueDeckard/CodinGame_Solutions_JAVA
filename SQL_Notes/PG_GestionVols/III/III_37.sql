--III)37. Donner le jour de la semaine (lundi, mardi, …) d'embauche de chaque pilote. Afficher le numéro du pilote, son nom et son jour d'embauche.

SELECT pi.nom, pi.nopilote, CASE 
WHEN (date_part('dow', pi.dateembauche) = 0)
THEN 'Lundi'
WHEN (date_part('dow', pi.dateembauche) = 1)
THEN 'Mardi'
WHEN (date_part('dow', pi.dateembauche) = 2)
THEN 'Mercredi'
WHEN (date_part('dow', pi.dateembauche) = 3)
THEN 'Jeudi'
WHEN (date_part('dow', pi.dateembauche) = 4)
THEN 'Vendredi'
WHEN (date_part('dow', pi.dateembauche) = 5)
THEN 'Samedi'
WHEN (date_part('dow', pi.dateembauche) = 6)
THEN 'Dimanche'
END
FROM pilote pi;