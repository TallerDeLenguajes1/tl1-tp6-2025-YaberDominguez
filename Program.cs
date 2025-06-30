// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;

Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
Console.Write("----------------------------------");
int numero = 0;
while (numero <= 0)
{
    Console.Write("Ingrese un numero para que sea invertido");
    string entrada = Console.ReadLine();
    if (int.TryParse(entrada, out numero))
    {
        if (numero <= 0)
        {
            Console.Write("El numero ingresado es invalido.Ingrese un numero mayor que 0.");
        }
        else
        {
            int invertido;
            invertido = Invertir_numero.Invertir(numero);
            Console.WriteLine("El numero invertido es: " + invertido);
        }
    }
    else
    {
        Console.Write("Se ingreso una palabra/frase, se esperaba un numero.");
        numero = 0;
    }
}