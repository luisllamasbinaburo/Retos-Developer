Reto developer 2!
:star: Adjunta tu respuesta en este hilo. Podéis resolverlo en vuestro lenguaje favorito
:calendar_spiral:  Fecha límite ** 12 septiembre 2022 **

===== :notepad_spiral: Enunciado ===== 

Consideremos un array que únicamente puede estar formado por 0 y 1.

En el array podemos ejecutar dos operaciones:
- Si un subarray es igual a 01, puede reemplazarse con un 1.
- Si un subarray es igual a 10, puede reemplazarse con un 0.

Llamaremos a un array "colapsable" si, mediante las dos operaciones anteriores, puede reducirse a un único elemento (equivalentemente, a un array con un único elemento)

Se pide un algoritmo que devuelva true si un array es colapsable, y false en caso contrario 

Ejemplos:

0 es colapsable :white_check_mark:

01 es colapsable :white_check_mark:

00 no es colapsable :x:

001 => (cogiendo el 01 del final y cambiándolo por 1) => 01 => 1  =>  es colapsable :white_check_mark: 

011 => (cogiendo el 01 del principio y cambiándolo por 1) => 11 => no es colapsable :x:

1001 => 101 => 01 => 1 => es colapsable :white_check_mark:



==== :fire:BONUS PACK ====
Para nota, quien quiera, puede ampliar con el siguiente ejercicio:

Algoritmo que, dado un array, calcule el **número total de subarrays que son "colapsables".**

**Ejemplo 1 **
Entrada: [1]
Salida: 1

*Explicación: 1 es en si mismo un array de longitud 1*

** Ejemplo 2**
Entrada: [0,1]
Salida: 3

*Explicación: los subarrays 0, 1, y 01 cumplen ser colapsables*

** Ejemplo 3**
Entrada: [1,0,0]
Salida: 4

*Explicación: los subarrays 1, 0, 0, y 100 cumplen ser colapsables*

** Ejemplo 4**
Entrada: [1,0,0,1]
Salida: 8

*Explicación: los subarrays 1, 0, 0, 1, 10, 01, 100, y 1001 cumplen ser colapsables*

** Ejemplo 5**
Entrada: [1,1,1,1,1]
Salida:

*Explicación: Solo los 5 subarrays de un elementos sueltos, 1 1 1 1 1, son colapsables*