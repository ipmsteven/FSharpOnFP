let rec gcd = function
  | (0, n) -> n
  | (m, n) -> gcd(n % m, m)
;;

gcd(12, 27);;
gcd(27, 12);;
