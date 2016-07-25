
//Answers Ch. 1

//ex 1.1

let rec g n = 
    n + 4.0;;

//ex 1.2

let rec h (x,y) : float =
    System.Math.Sqrt(x*x + y*y);; 

//ex 1.4

let rec sum = function
    | 0 -> 0
    | n -> n + sum (n-1)
;;

//ex 1.5

let rec fibo = function
    | 0 -> 0
    | 1 -> 1
    | n -> fibo (n-1) + fibo (n-2)
;;

//ex 1.6

let rec sum = function
    | (m,0) -> m
    | (0,n) -> 0
    | (m,n) -> m + (n+sum(m,n-1))
;;

//ex 1.7

float * int -> float
int -> int
function (float * int) -> float
float * int -> float
;;

//ex 1.8

env =   [
    a -> 5
    f(a) -> 6
    g(b) -> 11
        ]