(let
  (
    (a 100)
    (b 15)
  )
  (cond
    ((> a 20) (format t "~% a is greater than 20"))
    (t (format t "~% value of a is ~d " a))
  )    
)