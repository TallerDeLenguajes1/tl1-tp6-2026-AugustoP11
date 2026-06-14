# Trabajo Práctico N°6

**Alumno: Ponce Matías Augusto.**
**Comisión: Martes 11 Hs.**

## Ejercicio 4

#### ¿String es un tipo por valor o un tipo por referencia?

Es un tipo por referencia, cuando se crea una variable de tipo string el texto se guarda en el Heap y la variable en sí solo guarda un puntero que apunta a ese texto.
Algo importante que también debemos saber sobre el comportamiento del tipo string, es que es inmutable, por lo que cada vez que modificamos un string .NET no cambia el texto original en la memoria. En vez de eso, crea un objeto string nuevo en el Heap con el nuevo valor y cambia la dirección a la que apunta la variable.

#### ¿Qué secuencias de escape tiene el tipo string?

Secuencia | Descripción |
--- | --- |
\n | Nueva línea (Newline): Salto de línea.
\t | Tabulador horizontal: Añade un espacio de tabulación.
\\" | Comilla doble: Permite poner comillas dentro del string.
\\\ | Barra invertida: Permite escribir el carácter \ sin que evalúe un escape.
\\' | Comilla simple: Utilizado principalmente en caracteres (char).
\uXXXX | Carácter Unicode: Inserta un símbolo mediante su código hexadecimal de 4 dígitos.

#### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Estos dos símbolos son "modificadores" que cambian la forma en que el compilador lee una cadena de texto.
Al colocar @ antes de una cadena de texto y comillas, se ignoran las secuencias de escape.
Al colocar $ antes de una cadena de texto y comillas, se activa la interpolación de cadenas. Lo cual permite incrustar variables, expresiones o cálculos dentro del texto utilizando llaves {}.