(defun elimin (x l)
    (cond 
        (
            (null l) nil
        )
        (
            (eq (car l) x) (elimin x (cdr l))
        )
        (
            t (cons (car l) (elimin x (cdr l)))
        )
    )
)

(setq li '(1 2 3 4))
(setq x 1)

(write(elimin x li))