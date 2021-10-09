;;; (write (+ 7 9 11))

;;; (write(+ (* (/ 9 5) 60) 32))

;;; (write-line "Hello World")

;;; (write '( i am a list))

(write '(a ( a b c) d e fgh))

(write (cos 45))

(write-line "single quote used, it inhibits evaluation")
(write '(* 2 3))
(write-line " ")
(write-line "single quote not used, so expression evaluated")
(write (* 2 3))
