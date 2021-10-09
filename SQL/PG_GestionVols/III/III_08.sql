--III)8.Donner la liste alphabétique des pilotes qui ont effectué un vol le 2 mars 2004.
--		Afficher le nom du pilote, le numéro de vol, la ville de départ et la ville d'arrivée.
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