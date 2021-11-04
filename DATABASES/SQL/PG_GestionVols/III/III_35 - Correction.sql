--III)35. Donner le taux de remplissage des avions pour chaque vol. Afficher le numéro du vol, les villes de départ et d'arrivée, 
--		  la date du vol et le taux de remplissage sous la forme d'un pourcentage.
SELECT
    vol.novol,
    viD.nom,
    viA.nom,
    aff.dateaffectation,
    avi.nom,
    typ.code,
    CONCAT(((100 * aff.nbpassagers) / 100), ' %') --SELECT vol.novol, viD.nom, viA.nom, aff.dateaffectation, avi.nom, typ.code, ((100*aff.nbpassagers)/100) ||  ' %')
FROM
    vol
    INNER JOIN ville viD ON viD.code = vol.fk_vildep
    INNER JOIN ville viA ON viA.code = vol.fk_vilarr
    INNER JOIN affectation aff ON aff.fk_novol = vol.novol
    INNER JOIN avion avi ON avi.noavion = aff.fk_noavion
    INNER JOIN typeappareil typ ON typ.code = avi.fk_typeappareil;