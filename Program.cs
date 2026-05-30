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
float numeroAFlotante, numeroBFlotante, resultado;

do
{
    Console.WriteLine("Ingrese \"1\" para sumar");
    Console.WriteLine("Ingrese \"2\" para restar");
    Console.WriteLine("Ingrese \"3\" para multiplicar");
    Console.WriteLine("Ingrese \"4\" para dividir");
    Console.WriteLine("Ingrese \"5\" para usar la nueva funcion de CalculadoraV2");


    opcion = Console.ReadLine();
    opcionEntera = int.Parse(opcion);

    switch (opcionEntera)
    {
        case 1:
            Console.WriteLine("Ingrese un numero:");
            a = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero:");
            b = Console.ReadLine();
            numeroAFlotante = float.Parse(a);
            numeroBFlotante = float.Parse(b);
            resultado = numeroAFlotante + numeroBFlotante;
            Console.WriteLine($"Resultado: {resultado}");
            break;

        case 2:
            Console.WriteLine("Ingrese un numero:");
            a = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero:");
            b = Console.ReadLine();
            numeroAFlotante = float.Parse(a);
            numeroBFlotante = float.Parse(b);
            resultado = numeroAFlotante - numeroBFlotante;
            Console.WriteLine($"Resultado: {resultado}");
            break;

        case 3:
            Console.WriteLine("Ingrese un numero:");
            a = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero:");
            b = Console.ReadLine();
            numeroAFlotante = float.Parse(a);
            numeroBFlotante = float.Parse(b);
            resultado = numeroAFlotante * numeroBFlotante;
            Console.WriteLine($"Resultado: {resultado}");
            break;

        case 4:
            Console.WriteLine("Ingrese un numero:");
            a = Console.ReadLine();
            numeroAFlotante = float.Parse(a);
            do
            {
                Console.WriteLine("Ingrese otro numero:");
                b = Console.ReadLine();
                numeroBFlotante = float.Parse(b);
            } while (numeroBFlotante == 0);
            resultado = numeroAFlotante / numeroBFlotante;
            Console.WriteLine($"Resultado: {resultado}");
            break;

        case 5:
            do
            {
                Console.WriteLine("Ingrese un numero:");
                a = Console.ReadLine();
            } while (!(float.TryParse(a, out numeroAFlotante)));

            Console.WriteLine("Valor absoluto: {0}", Math.Abs(numeroAFlotante));
            Console.WriteLine("Cuadrado: {0}", Math.Pow(numeroAFlotante, 2));
            if (numeroAFlotante < 0)
            {
                Console.WriteLine("Raiz cuadrada: No se puede calcular");
            } else
            {
                Console.WriteLine("Raiz cuadrada: {0}", Math.Sqrt(numeroAFlotante));
            }
            Console.WriteLine("Seno: {0}", Math.Sin(numeroAFlotante));
            Console.WriteLine("Coseno: {0}", Math.Cos(numeroAFlotante));
            Console.WriteLine("Parte entera: {0}", (int)Math.Truncate(numeroAFlotante));

            do
            {
                Console.WriteLine("Ingrese un numero A:");
                a = Console.ReadLine();
            } while (!(float.TryParse(a, out numeroAFlotante)));

            do
            {
                Console.WriteLine("Ingrese un numero B:");
                b = Console.ReadLine();
            } while (!(float.TryParse(b, out numeroBFlotante)));

            if (numeroAFlotante > numeroBFlotante)
            {
                Console.WriteLine("Maximo entre los dos numeros: {0}", numeroAFlotante);
                Console.WriteLine("Minimo entre los dos numeros: {0}", numeroBFlotante);
            } else if (numeroBFlotante > numeroAFlotante)
            {
                Console.WriteLine("Maximo entre los dos numeros: {0}", numeroBFlotante);
                Console.WriteLine("Minimo entre los dos numeros: {0}", numeroAFlotante);
            } else
            {
                Console.WriteLine("Maximo entre los dos numeros: {0}", numeroBFlotante);
                Console.WriteLine("Minimo entre los dos numeros: {0}", numeroAFlotante);
            }

            break;

        default:
            Console.WriteLine("No se ingreso una opcion valida");
            break;    
    }
    Console.WriteLine("Ingrese \"1\" para realizar otra operacion o \"0\" para salir: ");
    opcion = Console.ReadLine();
    opcionEntera = int.Parse(opcion);
} while (opcionEntera != 0);