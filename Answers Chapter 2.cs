//Answers Ch. 2

//ex 2.1

let bol n = 
    (n % 2 = 0 || n % 3 = 0) && n % 5 = 0;;

//false expected
let a = bol 24;;

//false expected
let b = bol 27;; 

//false expected
let c = bol 29;; 

//true expected
let d = bol 30;; 

//ex 2.21

let pow (str:string,n) =
    str.[0..(n-1)]

pow ("christian",3);;

//ex 2.3
//Why do I need to typecast the string input?

let isIthChar (str:string,i,ch) =
    str.[i] = ch;;

isIthChar ("Chr",1,'h');;

