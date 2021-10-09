(defun fib(n)
  (cond ((eq n 0) 1)
        ((eq n 1) 1)
        (t (+ (fib (- n 1)) (fib (- n 2))))))

 (write (fib 6))