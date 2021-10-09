;; Concatenation
(defun conc(l1 l2)
  (if (null l1) l2 
  (cons (car l1)(conc (cdr l1) l2)))
)

(defun renverse (l)
  (if (null l) nil      ;; If l is null, returns nil. Else ...
  (conc                 ;; Concatenate
    (renverse (cdr l))  ;; the reversed list without its first element 
     (list (car l)))))  ;; with the list's first element.

(setq a '(1 2 3))
(write (renverse a))