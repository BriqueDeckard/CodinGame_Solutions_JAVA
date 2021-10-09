--III)33. Donner la liste des vols qui font l'aller et le retour entre deux villes. Afficher le numéro de vol, 
--		  la ville de départ et la ville d'arrivée.
DROP VIEW vue_vol;

CREATE OR REPLACE VIEW vue_vol AS
(
	SELECT vo.novol, vd.code as CodeDepart, vd.nom as VilleDepart, va.code AS CodeArrivee, va.nom AS VilleArrivee
	FROM vol vo
	INNER JOIN ville vd 
	ON vd.code = vo.fk_vildep
	INNER JOIN ville va
	ON va.code = vo.fk_vilarr
);

SELECT * from vue_vol;

SELECT * 
FROM vue_vol v_v1, vue_vol v_v2
WHERE 
(
	(
		v_v1.codedepart = v_v2.codearrivee 
	)
	AND
	(
		v_v1.codearrivee = v_v2.codedepart
	)
);