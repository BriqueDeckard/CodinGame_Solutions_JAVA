--II) 3. Supprimer ensuite le pilote nommé « DEJEAN Frederic »
DELETE FROM pilote
WHERE 
(
	pilote.nom LIKE '%DEJEAN%'
);
