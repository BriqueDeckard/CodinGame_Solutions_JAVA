--III)9. Donner pour chaque pilote qui habite à Lyon et qui utilise un avion totalisant moins
--		 de 12000 heures de vol, le type d'appareil correspondant. Afficher le nom du pilote
--		 et le libellé du type d'appareil.
SELECT
    DISTINCT pil.nom,
    vol.novol,
    vildep.nom,
    vilarr.nom
FROM
    pilote pil
    INNER JOIN affectation af ON af.fk_nopilote = pil.nopilote
    INNER JOIN vol ON vol.novol = af.fk_novol
    INNER JOIN ville vildep ON vildep.code = vol.fk_vildep
    INNER JOIN ville vilarr ON vilarr.code = vol.fk_vilarr
WHERE
    af.dateaffectation = '2004-03-02'
ORDER BY
    pil.nom ASC;