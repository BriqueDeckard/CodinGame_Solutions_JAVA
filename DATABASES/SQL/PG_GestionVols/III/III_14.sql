--III)14. Donner la liste des appareils qui sont utilisés pour la liaison Lyon – Londres. Affiché le
--		  code type et le libellé de l'appareil.
SELECT
    distinct avion.nom
FROM
    affectation
    INNER JOIN vue_vol ON affectation.fk_novol = vue_vol.novol
    INNER JOIN avion ON fk_noavion = avion.noavion
WHERE
    vue_vol.vildep = 'Lyon'
    AND vue_vol.vilarr = 'Londres';