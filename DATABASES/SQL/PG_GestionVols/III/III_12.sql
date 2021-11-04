--III)12. Donner la liste des vols qui correspondent à des aller-retours entre deux villes.
--		  Afficher le numéro de vol, la ville de départ et la ville d'arrivée.
Create
OR REPLACE VIEW vue_vol AS
SELECT
    vol.*,
    vildep.nom as vildep,
    vilarr.nom as vilarr
FROM
    vol
    INNER JOIN ville vildep ON vildep.code = vol.fk_vildep
    INNER JOIN ville vilarr ON vilarr.code = vol.fk_vilarr;

SELECT
    *
from
    vue_vol
    INNER JOIN vol ON vol.fk_vildep = vue_vol.fk_vilarr
    AND vol.fk_vilarr = vue_vol.fk_vildep;