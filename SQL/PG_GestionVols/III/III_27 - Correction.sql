--III)27. Quels sont les avions qui sont partis au moins une fois de Paris et au moins une fois de Lyon.
SELECT
	av.noavion,
	av.nom
FROM
	avion av
	INNER JOIN affectation af ON af.fk_noavion = av.noavion
	INNER JOIN vol ON vol.novol = af.fk_novol
WHERE
	EXISTS (
		SELECT
			*
		FROM
			ville
		WHERE
			vol.fk_vildep = ville.code
			AND (
				(ville.nom LIKE '%Londres%')
				OR (ville.nom LIKE '%Paris%')
			)
	);

--2
SELECT
	av.noavion,
	av.nom
FROM
	avion av
	INNER JOIN affectation af ON af.fk_noavion = av.noavion
	INNER JOIN vol vo ON vo.novol = af.fk_novol
	INNER JOIN ville vd ON vo.fk_vildep = vd.code
WHERE
	vd.nom IN ('Lyon', 'Paris');

--3
SELECT
	av.noavion,
	av.nom
FROM
	avion av
	INNER JOIN affectation af ON af.fk_noavion = av.noavion
	INNER JOIN vol vo ON vo.novol = af.fk_novol
	INNER JOIN ville vd ON vo.fk_vildep = vd.code
	AND vd.nom IN ('Lyon', 'Paris');

--4
SELECT
	av.noavion,
	av.nom
FROM
	avion av
WHERE
	EXISTS (
		SELECT
			1
		FROM
			affectation aff
			INNER JOIN vol ON aff.fk_novol = vol.novol
			INNER JOIN ville vd ON vol.fk_vildep = vd.code
		WHERE
			av.noavion = fk_noavion
			AND vildep = 'Lyon'
	)
	AND EXISTS (
		SELECT
			1
		FROM
			affectation aff
			INNER JOIN vol ON aff.fk_novol = vol.novol
			INNER JOIN ville vd ON vol.fk_vildep = vd.code
		WHERE
			av.noavion = fk_noavion
			AND vildep = 'Paris'
	);

--5 Avec Intersect.
SELECT
	av.noavion,
	av.nom
FROM
	avion av
	INNER JOIN affectation af ON af.fk_noavion = av.noavion
	INNER JOIN vol vo ON vo.novol = af.fk_novol
	INNER JOIN ville vd ON vo.fk_vildep = vd.code
	and (vd.nom = 'Paris')
INTERSECT
SELECT
	av.noavion,
	av.nom
FROM
	avion av
	INNER JOIN affectation af ON af.fk_noavion = av.noavion
	INNER JOIN vol vo ON vo.novol = af.fk_novol
	INNER JOIN ville vd ON vo.fk_vildep = vd.code
	and (vd.nom = 'Lyon');