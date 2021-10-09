Etude : 

    Raffinage :

        R_0 : 
            Creer un interpreteur LISP, il prend une expression exprimée
            en Lisp sous forme d'une chaine de caractères en entrée,
            l'évalue, et affiche le resultat final sous la forme d'une 
            chaine de caractères.

            Primitives LISP à fournir :
                - Calculs arithmetiques (+, -, *, / )
                - Travailler sur les listes : CONS, LIST, CAR, CDR, CADR, CDDR
                - QUOTE
                - Operateurs de comparaison : GT, GE, LT, LE, EQ
                - Operateurs logiques : OR, AND
                - Structure de test : IF, COND
                - DEFUN
                - NIL, T

            Exemples d'utilisation : 
                (+ 2 3)                     --> 5
                (LIST A B C)                --> (A B C)
                (QUOTE A)                   --> A
                'A                          --> A
                (DEFUN double(n) (* n 2))   --> double
                (double 2)                  --> 4
                (EQ 'A 'B)                  --> NIL
                (EQ 'A 'A)                  --> t
                TOTO                        --> Erreur : "variable TOTO has no value"
                (+ 1                        --> Erreur : "Expression invalide"
                (+ 2 A)                     --> Erreur : "+ impossible pour deux types differents"

            Comment faire : 
                - Parser (analyse syntaxique) de l'expression entrée : (...) ou Atome : élément simple.

                - Evaluation : 
                    - Si atome --> retourne atome ou valeur atome.
                    - Si liste --> retourne resultat de l'evaluation de la fonction dont le nom est le  
                                    premier element de la liste et les éléments suivants les arguments.
                    - Le resultats d'une évaluation sera une liste ou un atome.
                    - Fonctions particulières : DEFUN qui enregistre une fonction utilisateur.

                - Retour : 
                    - sous forme de chaine : représentation des listes sous forme de chaines.

        R_1 : 
            Elements syntaxiques : '(' ')'
            Parser l'expression         --> Parser(expr IN Chaine) OUT Item (atome ou liste)
            Evaluer liste               --> Evaluer(liste IN Liste) OUT Item

        R_2 :
            Parser : 
                - Analyse lexicale      --> Lexer(expr IN Chaine) OUT ListeLexemes
                - Analyse syntaxique    --> AnalyserSyntaxe(lexemes IN ListeLexemes))
            
            Evaluer : 
                - Si atome              --> evaluerAtome(atome)     OUT Item
                - Si liste              --> evaluerFonction(liste)  OUT Item
            
            Transformer en chaîne : 
                - Si atome              --> Valeur en texte
                - Si liste              --> '(' + pour chaque element : transformer en chaine + ')'

        R_3 : 
