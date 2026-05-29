/*
Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("valor de a: "+a);

Console.WriteLine("valor de b: "+b);
*/

//Ejercicio 1

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

string opcion, a, b;
int opcionEntera = 0;
float numeroAEntero, numeroBEntero, resultado;

do
{
    Console.WriteLine("Ingrese \"1\" para sumar");
    Console.WriteLine("Ingrese \"2\" para restar");
    Console.WriteLine("Ingrese \"3\" para multiplicar");
    Console.WriteLine("Ingrese \"4\" para dividir");


    opcion = Console.ReadLine();
    opcionEntera = int.Parse(opcion);

    switch (opcionEntera)
    {
        case 1:
            Console.WriteLine("Ingrese un numero:");
            a = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero:");
            b = Console.ReadLine();
            numeroAEntero = float.Parse(a);
            numeroBEntero = float.Parse(b);
            resultado = numeroAEntero + numeroBEntero;
            Console.WriteLine($"Resultado: {resultado}");
            break;

        case 2:
            Console.WriteLine("Ingrese un numero:");
            a = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero:");
            b = Console.ReadLine();
            numeroAEntero = float.Parse(a);
            numeroBEntero = float.Parse(b);
            resultado = numeroAEntero - numeroBEntero;
            Console.WriteLine($"Resultado: {resultado}");
            break;

        case 3:
            Console.WriteLine("Ingrese un numero:");
            a = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero:");
            b = Console.ReadLine();
            numeroAEntero = float.Parse(a);
            numeroBEntero = float.Parse(b);
            resultado = numeroAEntero * numeroBEntero;
            Console.WriteLine($"Resultado: {resultado}");
            break;

        case 4:
            Console.WriteLine("Ingrese un numero:");
            a = Console.ReadLine();
            numeroAEntero = float.Parse(a);
            do
            {
                Console.WriteLine("Ingrese otro numero:");
                b = Console.ReadLine();
                numeroBEntero = float.Parse(b);
            } while (numeroBEntero == 0);
            resultado = numeroAEntero / numeroBEntero;
            Console.WriteLine($"Resultado: {resultado}");
            break;

        default:
            Console.WriteLine("No se ingreso una opcion valida");
            break;    
    }
    Console.WriteLine("Ingrese \"1\" para realizar otra operacion o \"0\" para salir: ");
    opcion = Console.ReadLine();
    opcionEntera = int.Parse(opcion);
} while (opcionEntera != 0);