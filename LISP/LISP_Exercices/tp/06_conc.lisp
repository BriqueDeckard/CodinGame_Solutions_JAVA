(setq x '(A B C))
(setq y '(D E F))
;(write x)
;(write y)

(defun conc(l1 l2)
  ; if l1 is null, return l2
  (if (null l1) l2 
  (cons (car l1)(conc (cdr l1) l2)))
  ; 1   --> [A + conc([BC], [DEF])]
  ; 2   --> [A B + conc([C], [DEF])]
  ; 3   --> [A B C + conc([], [DEF])]
  
)

(write (conc x y))
