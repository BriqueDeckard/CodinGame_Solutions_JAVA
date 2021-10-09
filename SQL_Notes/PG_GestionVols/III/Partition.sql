--PARTITION

SELECT
     pilote.nom,
     ROW_NUMBER() over (partition by pilote.nom) as count
     from pilote
     join ville v on pilote.fk_ville = v.code

select
 p.nom,
 v.nom
 from (
   select
     pilote.nom as nom,
     ROW_NUMBER() over (partition by pilote.nom) as count
     from pilote
     join ville v on pilote.fk_ville = v.code
 ) a
 join pilote p on p.nom = a.nom
 join ville v on v.code = p.fk_ville
 where a.count > 1
 
 
