--III)18. Liste des vols ayant un pilote qui habite la ville de départ du vol. 
--		  Afficher le numéro de vol, la ville de départ, la ville d'arrivée et le nom du pilote.
SELECT
	vo.novol AS novol,
	de.nom AS depart,
	ar.nom AS arrivee,
	pi.nom AS pilote
FROM
	vol vo
	INNER JOIN ville de ON de.code = vo.fk_vildep
	INNER JOIN ville ar ON ar.code = vo.fk_vilarr
	INNER JOIN affectation af ON af.fk_novol = vo.novol
	INNER JOIN pilote pi ON pi.nopilote = af.fk_nopilote
WHERE
	(pi.fk_ville = vo.fk_vildep);