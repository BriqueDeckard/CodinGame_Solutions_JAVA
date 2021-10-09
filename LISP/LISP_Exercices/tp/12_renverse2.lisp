(defun renverse2 (l)
  (renversebis l nil) ;; pass the list and nil to renversebis
)

(defun renversebis (l res)
  (if (null l) res    ;; if l is null return res
    (renversebis      ;; else recurs on
      (cdr l)         ;; l without its first element 
      (cons           ;; and a list built from
        (car l)       ;; the first element of l
        res           ;; and res
      )
    )
  )
)

(write (renverse2 '(1 2 3)))
;; (renversebis '(1 2 3) nil)
;; '(1 2 3) != null so 
;; (renversebis 
;;   (cdr '(1 2 3)) --> '(2 3)
;;   (cons (car '(1 2 3)) nil)) --> '(1 nil)
;; 
;; l is not null so
;; (renversebis
;;  (cdr '(2 3)) --> '(3)
;;  (cons (car '(2 3)) nil))  --> '(2 1))