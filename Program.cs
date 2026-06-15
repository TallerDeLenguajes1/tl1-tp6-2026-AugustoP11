/*
Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("valor de a: "+a);

Console.WriteLine("valor de b: "+b);
*/


//______________________EJERCICIO 1____________________
/*
int numeroEntero;
string numero;

do
{
    Console.WriteLine("Ingrese un numero: ");
    numero = Console.ReadLine();
} while (!(int.TryParse(numero, out numeroEntero)));


if (numeroEntero > 0)
{
    int numeroInvertido = 0;
    int aux;

    while (numeroEntero > 0)
    {
        aux = numeroEntero % 10;
        numeroEntero = numeroEntero / 10;    
        numeroInvertido = numeroInvertido * 10 + aux;
    }

    Console.WriteLine($"El numero ingresado es: {numeroEntero}");
    Console.WriteLine($"El numero invertido es: {numeroInvertido}");
} else
{
    Console.WriteLine($"El numero ingresado debe ser mayor a 0 para ser invertido");
}
*/

//______________Ejercicio 4___________________

//Obtener la longitud de una cadena y mostrar por pantalla
Console.WriteLine("Ingrese una cadena:");
string primeraCadenaIngresada = Console.ReadLine().ToString();
Console.WriteLine($"Longitud de cadena ingresada: {primeraCadenaIngresada.Length}");

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.WriteLine("Ingrese otra cadena:");
string segundaCadenaIngresada = Console.ReadLine().ToString();
string cadenasConcatenadas = string.Concat(primeraCadenaIngresada, segundaCadenaIngresada);
Console.WriteLine($"Cadena concatenada: {cadenasConcatenadas}");

//Extraer una subcadena de la cadena ingresada.
int longitudCadenasConcatenadas = cadenasConcatenadas.Length;
string indice;
int indiceEntero;
do
{
    Console.WriteLine("Ingrese un indice (entero) a partir del cual extraer una subcadena:");
    indice = Console.ReadLine();
    indiceEntero = int.Parse(indice);
} while (longitudCadenasConcatenadas < indiceEntero);

string subcadena = cadenasConcatenadas.Substring(indiceEntero);
Console.WriteLine($"Subcadena obtenida: {subcadena}");

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
foreach (var elemento in cadenasConcatenadas)
{
    Console.WriteLine($"{elemento}");
}

//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("Ingrese una subcadena para encontrar su ocurrencia:");
subcadena = Console.ReadLine().ToString();
indiceEntero = cadenasConcatenadas.IndexOf(subcadena);

if (indiceEntero >= 0)
{
    Console.WriteLine($"Ocurrencia en la posicion: {indiceEntero}.");
} else
{
    Console.WriteLine("No hay ocurrencias.");
}

//Convierta la cadena a mayúsculas y luego a minúsculas.
string cadenasMayusculas = cadenasConcatenadas.ToUpper();
string cadenasMinusculas = cadenasConcatenadas.ToLower();

Console.WriteLine($"Cadenas concatenadas en mayusculas: {cadenasMayusculas}");
Console.WriteLine($"Cadenas concatenadas en minusculas: {cadenasMinusculas}");

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
string cadenaCompleta = "Juan;Perez;30;12345678";
string[] cadenaSeparada = cadenaCompleta.Split(';');
foreach (var elemento in cadenaSeparada)
{
    Console.WriteLine($"{elemento}");
}