let f n = n%2 = 0 && n%3 = 0 && n%5 <> 0 ;;
f(24);;
f(27);;
f(29);;
f(30);;

let rec f = function
    | (s, 1) -> s + "" (* use "" to force type casting *)
    | (s, n) -> s + f(s, n-1)
;;

f("a", 3);;

let isIthChar (str: string) i ch = str.[i] = ch ;;
isIthChar "a" 0 'a' ;;
isIthChar "abc" 1 'a' ;;

let rec occFromIth (str: string, i: int, ch: char) = match compare (String.length str) i with
    | t when t > 0 -> if str.[i] = ch then  1 + occFromIth(str,i+1,ch) else occFromIth(str,i+1,ch)
    | _ -> 0
;;
occFromIth("cabccd", 1, 'c');;
occFromIth("abccd", 9, 'c');;

let occInString (str, ch) = occFromIth(str, 0, ch) ;;
occInString("abcdd", 'd');;

let notDivisible (d, n) = n%d <> 0;;
notDivisible(2, 5);;
notDivisible(3, 9);;
