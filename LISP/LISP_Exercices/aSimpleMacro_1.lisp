;;  (defmacro macro-name (parameter-list))
;;  "Optional documentation string."
;;  body-form

(defMacro setTo10(num)
(setq num 10)(print num))
(setq x 25)
(print x)
(setTo10 x)
