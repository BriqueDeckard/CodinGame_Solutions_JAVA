(defun longueur(l)              ; Def de la fonction
 (if                            ; Si
   (eq nil l)                   ; la liste est nulle
   0                            ; Alors on renvoie 0
   (1+                          ; Sinon on incrémente
     (longueur                  ; on fait de la recursivité sur ...
       (cdr l)                  ; ... la liste privée de son premier element
     )
    )
 )
)    
                                
(write(longueur '(2 2 3 5)))