(defun fact(n)          ; definition de la fonction
  (if (eq n 1)           ; si n = 1
   1                    ; alors on retourne 1
   (* n (fact (- n 1)))  ; sinon recursivité, on multiplie n par fact de n-1
  )
)

(write-line "")
(write (fact 6))
(write-line "")
(write (fact 10))


; 1) premier appel
; (setq X fact(3)) ; par exemple
; la fonction fact() reçoit comme argument n=3
; n different de 1 alors
; n=n*fact(n-1) soit n=3*fact(2)
; appelons A la valeur fac(2) attendue

; 2) au deuxieme appel la fonction fact() reçoit comme argument n=2
; n different de 1 alors
; n=n*fact(n-1) soit n=2*fact(1)
; appelons B la valeur fact(1) attendue

; 3)au troisième appel la fonction fact() reçoit comme argument n=1
; n=1 alors retourne 1 a la fonction appelante
; donc B=1

;  on remplace B par sa valeur dans le 2)
; n=2*B soit n=2*1=2 et retourne 2 à la fonction appelante
; donc A=2

; on remplace A par sa valeur dans le 1)
; n=3*A soit n=3*2=6 et retourne 6 à la fonction appelante
; donc X=6

; Techniquement, ces opérations se passent dans une zone mémoire appelée la Pile (Stack). Cette zone est gérée par un registre du microprocesseur qui s'appelle Stack Pointer (SP). La pile à une dimension prédéfinie non extensible pour chaque programme. Quand une fonction récurrente comme celle décrite s'appelle elle-même un grand nombre de fois, on finit par avoir une erreur "Stack overflow" (dépassement de la pile). Cette erreur est irrécupérable et plante le programme. 