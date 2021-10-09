(setq x '(2 3 4 5 6 7))
(write x)
(write-line "")
(defun der (l)                      ; def fonction
 (cond                              ; conditions
   (
       (eq nil l)                   ; si liste egale nil
       nil                          ; alors retourne nil
   )
   (
       (eq nil (cdr l))             ; si la liste privée de son premier element egale nil
       (car l)                      ; retourne le premier element de la liste
   )
   (
       t (der (cdr l))              ; Quoi qu'il se passe retourne der de la liste moins son premier.
   )
 )
)



(write (der x))