--III)4. Afficher les numéros des vols qui ont eu lieu le 2 mars 2004.
CREATE OR REPLACE VIEW Date_Vol AS
(
	SELECT vol.novol, aff.dateaffectation
	FROM vol
	INNER JOIN affectation aff
	ON aff.fk_novol = vol.novol
);

SELECT d_v.novol
FROM date_vol d_v
WHERE 
(
	d_v.dateaffectation = '2004-03-02'
);