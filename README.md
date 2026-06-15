# Trabajo Práctico N°6

**Alumno: Ponce Matías Augusto.**
**Comisión: Martes 11 Hs.**

## Ejercicio 4

#### ¿String es un tipo por valor o un tipo por referencia?

Es un tipo por referencia, cuando se crea una variable de tipo string el texto se guarda en el Heap y la variable en sí solo guarda un puntero que apunta a ese texto.
Algo importante que también debemos saber sobre el comportamiento del tipo string, es que es inmutable, por lo que cada vez que modificamos un string .NET no cambia el texto original en la memoria. En vez de eso, crea un objeto string nuevo en el Heap con el nuevo valor y cambia la dirección a la que apunta la variable.

#### ¿Qué secuencias de escape tiene el tipo string?

Secuencia de escape	| Nombre de carácter | Codificación Unicode
--- | --- | --- |
\\' | Comilla simple | 0x0027
\\" | Comilla doble | 0x0022
\\ | Barra invertida | 0x005C
\0 | Nulo | 0x0000
\a | Alerta | 0x0007
\b | Retroceso | 0x0008
\e | Escapar | 0x001B
\f | Avance de página | 0x000C
\n | Nueva línea | 0x000A
\r | Retorno de carro | 0x000D
\t | Tabulación horizontal | 0x0009
\v | Tabulación vertical | 0x000B
\u | Secuencia de escape Unicode (UTF-16) | \uHHHH (intervalo: 0000 - FFFF; ejemplo: \u00E7 = "ç")
\U | Secuencia de escape Unicode (UTF-32) | \U00HHHHHH (intervalo: 000000 - 10FFFF; ejemplo: \U0001F47D = "👽")
\x | Secuencia de escape Unicode similar a "\u" excepto con longitud variable | \xH[H][H][H] (intervalo: 0 - FFFF; ejemplo: \x00E7 or \x0E7 or \xE7 = "ç")

Fuente: <a href="https://learn.microsoft.com/es-es/dotnet/csharp/programming-guide/strings/">Cadenas - C#</a>

#### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Estos dos símbolos son "modificadores" que cambian la forma en que el compilador lee una cadena de texto.
Al colocar @ antes de una cadena de texto y comillas, se ignoran las secuencias de escape.
Al colocar $ antes de una cadena de texto y comillas, se activa la interpolación de cadenas. Lo cual permite incrustar variables, expresiones o cálculos dentro del texto utilizando llaves {}.