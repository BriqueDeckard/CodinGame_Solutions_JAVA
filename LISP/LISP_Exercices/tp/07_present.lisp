(defun present (x l)
;; If l is null, return nil
 (cond ((null l) nil)
;; if car l is x, return t
 ((eq (car l) x) t)
;; elsse check for the next element by recursivity
 (t (present x(cdr l)))))

 (setq ll '(1 2 3 4)) 
 (setq xx 3)

(write (present xx ll))