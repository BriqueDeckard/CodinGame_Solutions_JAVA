(defun remplace (x y l)
  (cond 
    ((null l) nil)  ;; If l is null return nil
    ((eq (car l) x) ;; If the first element of l equal x 
      (cons y (remplace x y (cdr l)))   ;; then make a list with y and "recurs" on l without its first element.
    ) 
    (t      ;; aniway
      (cons  ;; make a list
        (car l) ;; With the first element of l
          (remplace x y (cdr l)))))) ;; and "recurs" ib k without its first element

(setq a '(1 2 3))

(write a)

;; (remplace 2 1 a))
;; --> (remplace 2 1 '(1 2 3))
;; a is not null and (car '(1 2 3)) (= 1) !eq x (= 2)
;; build a list with (car '(1 2 3)) (= 1) and (remplace 2 1 (cdr '(1 2 3))) --> (1 ...)
;; --> (remplace 2 1 '(2 3))
;; a is not null but (car '(2 3)) (=2) eq x (= 2)
;; build a list with y (= 1) and recurs on (cdr'(2 3)) --> (1 1 ...)