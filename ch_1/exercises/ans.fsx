// Function declaration
let g n = n + 4;;
g(2);;

let h (x, y) = System.Math.Sqrt(x * x + y * y);;
h(5.0, 9.0);;

// Function expression
let g = fun n -> n + 4 ;;
g(1);;

let h = fun (x, y) -> System.Math.Sqrt(x * x + y * y);;
h(3.0, 4.0);;

let rec f = function
    | 0 -> 0
    | n -> n + f(n - 1)
;;
f(4);;

let rec fibonacci = function
    | 0 -> 0
    | 1 -> 1
    | n -> fibonacci(n-1) + fibonacci(n-2)
;;
fibonacci(12);;

let rec sum = function
    |(m, 0) -> m
    |(m, n) -> m + n + sum(m, n - 1)
;;

let a = 5;;
let f a = a + 1;;
let g b = (f b) + a;;

f 3;;
g 3;;
