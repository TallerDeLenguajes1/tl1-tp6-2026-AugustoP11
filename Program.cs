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

