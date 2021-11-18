# SQL:
[UsefulQuery](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#useful-)
[Database](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#database-)
- [Create](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#create-)
- [Drop](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#drop)
[Tables](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#tables-)
- [Create](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#create)
- [Update](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#update)
- [Delete](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#delete)
[CRUD](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#crud-)
- [Create](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#create-insert)
- [Read](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#read-select-)
- [Update](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#update-update-)
- [Delete](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#delete-delete)
[Jointures](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#jointures)
[Sous requêtes](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#sous-requ%C3%AAtes)
[Fonctions](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#fonctions)
[Procedures Stockées](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#procedures-stock%C3%A9es)
[Triggers](https://github.com/BriqueDeckard/Notes/blob/master/DATABASES/SQL/README.md#triggers)

## Database : 
### Create :
```SQL
CREATE DATABASE IF NOT EXISTS ma_base
```
### Drop:
```SQL
DROP DATABASE ma_base
```
## Tables :
### Create:
```SQL
CREATE TABLE nom_de_la_table
(
    colonne1 type_donnees,
    colonne2 type_donnees,
    colonne3 type_donnees,
    colonne4 type_donnees
)
```
#### Constraints : 
- ```NOT NULL``` : empêche d’enregistrer une valeur nulle pour une colonne.
- ```DEFAULT``` : attribuer une valeur par défaut si aucune données n’est indiquée pour cette colonne lors de l’ajout d’une ligne dans la table.
- ```PRIMARY KEY``` : indiquer si cette colonne est considérée comme clé primaire pour un index.
##### Primary-Key :
```SQL
CREATE TABLE `nom_de_la_table` (
  id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
  [...]
);
```
### Update: 
#### Alter :
```SQL
ALTER TABLE nom_table
instruction
```
### Delete:
```SQL
DROP TABLE nom_table
```

### Useful : 
> Cette requête imaginaire sert principale d’aide-mémoire pour savoir dans quel ordre sont utilisé chacun des commandes au sein d’une requête SELECT.
```SQL
SELECT *
FROM table
WHERE condition
GROUP BY expression
HAVING condition
{ UNION | INTERSECT | EXCEPT }
ORDER BY expression
LIMIT count
OFFSET start
```

## CRUD :
### (Create) Insert: 

```SQL
INSERT INTO nom_table VALUES ('valeur 1', 'valeur 2', ...)
```

### (Read) Select :

```SQL
SELECT nom_du_champ FROM nom_table

SELECT nom_champ1, nom_champ2 FROM nom_table

SELECT * FROM table

SELECT DISTINCT nom_colonne FROM nom_table
```

#### And: 

```SQL
SELECT nom_colonnes
FROM nom_table
WHERE condition1 AND condition2
```

#### Or: 
```SQL
SELECT nom_colonnes FROM nom_table
WHERE condition1 OR condition2
```

#### Combinés : 
``` SQL
SELECT * FROM produit
WHERE ( categorie = 'informatique' AND stock < 20 )
OR ( categorie = 'fourniture' AND stock < 200 )
```

#### Like :
```SQL
SELECT *
FROM table
WHERE colonne LIKE modele
```

#### Group by :
```SQL
SELECT colonne1, fonction(colonne2)
FROM table
GROUP BY colonne1
```

#### Having: 
```SQL
SELECT colonne1, SUM(colonne2)
FROM nom_table
GROUP BY colonne1
HAVING fonction(colonne2) operateur valeur
```

#### OrderBy:
```SQL
SELECT colonne1, colonne2
FROM table
ORDER BY colonne1
```

### (Update) Update :
```SQL
UPDATE table
SET nom_colonne_1 = 'nouvelle valeur'
WHERE condition
```

#### Merge:
```SQL
MERGE INTO table1
  USING table_reference
  ON (conditions)
  WHEN MATCHED THEN
    UPDATE SET table1.colonne1 = valeur1, table1.colonne2 = valeur2
    DELETE WHERE conditions2
  WHEN NOT MATCHED THEN
    INSERT (colonnes1, colonne3) 
    VALUES (valeur1, valeur3)
```

- MERGE INTO permet de sélectionner la table à modifier
- USING et ON permet de lister les données sources et la condition de correspondance
- WHEN MATCHED permet de définir la condition de mise à jour lorsque la condition est vérifiée
- WHEN NOT MATCHED permet de définir la condition d’insertion lorsque la condition n’est pas vérifiée

### (Delete) Delete: 
```SQL
DELETE FROM `table`
WHERE condition
```

## Jointures

- **INNER JOIN** : jointure interne pour retourner les enregistrements quand la condition est vrai dans les 2 tables. C’est l’une des jointures les plus communes. Cette commande retourne les enregistrements lorsqu’il y a au moins une ligne dans chaque colonne qui correspond à la condition.
```SQL
SELECT *
FROM table1
INNER JOIN table2 ON table1.id = table2.fk_id
```
- **CROSS JOIN** : jointure croisée permettant de faire le produit cartésien de 2 tables. En d’autres mots, permet de joindre chaque lignes d’une table avec chaque lignes d’une seconde table. Attention, le nombre de résultats est en général très élevé. permet de retourner le produit cartésien.
```SQL
SELECT *
FROM table1
CROSS JOIN table2
```
- **LEFT JOIN** (ou LEFT OUTER JOIN) : jointure externe pour retourner tous les enregistrements de la table de gauche (LEFT = gauche) même si la condition n’est pas vérifié dans l’autre table. Permet de lister tous les résultats de la table de gauche (left = gauche) même s’il n’y a pas de correspondance dans la deuxième tables.
S’il y a un enregistrement de la table de gauche qui ne trouve pas de correspondance dans la table de droite, alors les colonnes de la table de gauche auront NULL pour valeur.
```SQL
SELECT *
FROM table1
LEFT JOIN table2 ON table1.id = table2.fk_id
```
- **RIGHT JOIN** (ou RIGHT OUTER JOIN) : jointure externe pour retourner tous les enregistrements de la table de droite (RIGHT = droite) même si la condition n’est pas vérifié dans l’autre table. Permet de retourner tous les enregistrements de la table de droite (right = droite) même s’il n’y a pas de correspondance avec la table de gauche.
S’il y a un enregistrement de la table de droite qui ne trouve pas de correspondance dans la table de gauche, alors les colonnes de la table de gauche auront NULL pour valeur.
```SQL
SELECT *
FROM table1
RIGHT JOIN table2 ON table1.id = table2.fk_id
```
- **FULL JOIN** (ou FULL OUTER JOIN) : jointure externe pour retourner les résultats quand la condition est vrai dans au moins une des 2 tables. permet de combiner les résultats des 2 tables, les associer entre eux grâce à une condition et remplir avec des valeurs NULL si la condition n’est pas respectée.
```SQL
SELECT *
FROM table1
FULL JOIN table2 ON table1.id = table2.fk_id
```
- **SELF JOIN** : permet d’effectuer une jointure d’une table avec elle-même comme si c’était une autre table.
```SQL
SELECT `t1`.`nom_colonne1`, `t1`.`nom_colonne2`, `t2`.`nom_colonne1`, `t2`.`nom_colonne2`
FROM `table` as `t1`
LEFT OUTER JOIN `table` as `t2` ON `t2`.`fk_id` = `t1`.`id`
```
- **NATURAL JOIN** : jointure naturelle entre 2 tables s’il y a au moins une colonne qui porte le même nom entre les 2 tables SQL. permet de faire une jointure naturelle entre 2 tables. Cette jointure s’effectue à la condition qu’il y ai des colonnes du même nom et de même type dans les 2 tables. Le résultat d’une jointure naturelle est la création d’un tableau avec autant de lignes qu’il y a de paires correspondant à l’association des colonnes de même nom.
```SQL
SELECT *
FROM table1
NATURAL JOIN table2
```
- **UNION JOIN** : jointure d’union

### Union:
Permet de concaténer les résultats de 2 requêtes ou plus.
```SQL
SELECT * FROM table1
UNION
SELECT * FROM table2
```

### Intersect: 
Intersection des résultats de 2 requêtes. Cette commande permet donc de récupérer les enregistrements communs à 2 requêtes
```SQL
SELECT * FROM `table1`
INTERSECT
SELECT * FROM `table2`
```

## Sous requêtes:
### Requête imbriquée qui retourne un seul résultat: 
```SQL
SELECT *
FROM `table`
WHERE `nom_colonne` = (
    SELECT `valeur`
    FROM `table2`
    LIMIT 1
  )
```
### Requête imbriquée qui retourne une colonne:
```SQL
SELECT *
FROM `table`
WHERE `nom_colonne` IN (
    SELECT `colonne`
    FROM `table2`
    WHERE `cle_etrangere` = 36
  )
```
## Fonctions:
- ```SUM()``` calculer la somme d’un set de résultat
- ```MAX()``` obtenir le résultat maximum (fonctionne bien pour un entier)
- ```MIN()``` obtenir le résultat minimum
- ```COUNT()``` compter le nombre de lignes dans un résultat
- ```ROUND()``` arrondir la valeur
- ```UPPER()``` afficher une chaîne en majuscule
- ```LOWER()``` afficher une chaîne en minuscule
- ```NOW()``` date et heure actuelle
- ```RAND()``` retourner un nombre aléatoire
- ```CONCAT()``` concaténer des chaînes de caractères
- ```CURRENT_DATE()``` date actuelle

## Procedures stockées:
[SQL.SH](https://sql.sh/cours/procedure-stockee)
## Triggers
[SQL.SH](https://sql.sh/cours/create-trigger)
