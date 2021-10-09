(defun pair (l)
  (if (null l) nil      ;; if l is null return nil
  (impair (cdr l))))    ;; else apply impair to the list without its first element

(defun impair (l)
  (if (null l) nil      ;; if l is null return nil
  (cons                 ;; else build a list with ...
    (car l)             ;; l's first element 
    (pair (cdr l)))))   ;; and pair, applied to l without its first element



(setq a '(1 2 3 4))

(write (pair a))
;; 1 - a is not null so it goes into impair without its first element (2 3 4)
;; 2 - a is not null, so into impair a list is built with the first element of a --> 2 and then a goes into pair without its first element --> (3 4)
;; 3 - a is not null, so it goes into impair without its first element --> (4)
;; 4 - a is not null, so into imp. the first element of a is added to the list --> (4)
;; 5 - the list is returned --> (2 4)

