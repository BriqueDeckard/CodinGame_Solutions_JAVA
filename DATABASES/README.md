# SQL vs NoSQL:

## SQL: (robuste)
- Relation clé-primaire/clé secondaire
- Insertion: sécuritaire
- Requêtage: potentiellement lent
- typage fort
## NoSQL: (rapide)
- Requetage rapide (GET)
- fichier plat (enregistrement en lignes, délimités par des caractères spéciaux)
- typage faible
- imbrication des collections

# Transactions : 
Une transaction est un ensemble de requêtes qui sont executées comme un seul bloc.
Si l'une d'entre elle echoue, on peut choisir de tout annuler (rollback) ou de ne garder que certaines modifications.
Qi tout fonctionne, on peut valider : commiter.
## MySQL:
```
START TRANSACTION

// code

ROLLBACK
ou
COMMIT
```
