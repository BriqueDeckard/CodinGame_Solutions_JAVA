(defun lnpe(n)                  ; Def de la fonction
  (if (eq n 0) nil              ; si n = 0 on renvoie nil
    (cons n (lnpe (- n 1)))))   ; sinon on fait une liste de n grace a la recursivité

(write(lnpe 5))