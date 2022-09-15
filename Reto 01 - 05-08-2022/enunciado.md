Dada una matriz de números enteros indexados a 0, hacer una función que: 
- Devuelva verdadero si la lista estrictamente creciente, después de eliminar como máximo un elemento de la lista
- Falso en caso contrario

Recordamos que una sucesión de números es estrictamente creciente si
```
nums[i - 1] < nums[i]
```
para 1 <= i < nums.length

**Ejemplo 1**

Entrada: [1,2,10,5,7]
Salida: verdadero

*Explicación: al eliminar 10 en el índice 2 de nums, se convierte en [1,2,5,7]*

**Ejemplo 2**

Entrada: [2,3,1,2]
Salida: falso

*[3,1,2] es el resultado de eliminar el elemento en el índice 0.
[2,1,2] es el resultado de eliminar el elemento en el índice 1.
[2,3,2] es el resultado de eliminar el elemento en el índice 2.
[2,3,1] es el resultado de eliminar el elemento en el índice 3.
Ninguna matriz resultante es estrictamente creciente, por lo que el resultado es falso*

**Fuente:**
https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/
