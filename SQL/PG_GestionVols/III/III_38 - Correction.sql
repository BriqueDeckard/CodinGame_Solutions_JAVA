--III)38. Indiquer pour chaque pilote qui reçoit une commission, le montant le plus élevé entre salaire et commission. 
--		  Afficher le numéro du pilote, le nom, « Salaire » ou « Commission » et le montant correspondant.
SELECT
	case
		WHEN pil.commission > 0 :: money THEN case
			WHEN pil.commission > pil.salaire THEN concat('COM : ', pil.commission)
			ELSE concat('SAL : ', pil.salaire)
		END
	END
FROM
	pilote pil;

SELECT
	CASE
		WHEN pil.commission IS NOT NULL THEN CASE
			WHEN pil.commission > pil.salaire THEN CONCAT('COM : ', pil.commission)
			ELSE CONCAT('SAL : ', pil.salaire)
		END
	END
FROM
	pilote pil;