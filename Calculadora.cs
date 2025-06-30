
double resultado;
float numero;
string entrada;
Console.Write("Ingrese un numero:");
entrada = Console.ReadLine();
if (float.TryParse(entrada, out numero))
{
    int numero_entero = (int)numero;
    resultado = Math.Abs(numero);
    Console.WriteLine("El valor absoluto del numero ingresado es: " + resultado);
    resultado = numero * numero;
    Console.WriteLine("El cuadrado del numero ingresado es: " + resultado);
    resultado = Math.Sqrt(numero);
    Console.WriteLine("La raiz del numero ingresado es: " + resultado);
    resultado = Math.Sin(numero);
    Console.WriteLine("El seno del numero ingresado es: " + resultado);
    resultado = Math.Cos(numero);
    Console.WriteLine("El coseno del numero ingresado es: " + resultado);
    Console.WriteLine("La parte entera del numero ingresado es: " + numero_entero);
}
else
{
    Console.Write("Numero invalido.");
}
Console.WriteLine("Ingrese dos numeros:");
Console.WriteLine("Ingrese el primer numero:");
int numero_1;
entrada = Console.ReadLine();
if (int.TryParse(entrada, out numero_1))
{
    Console.WriteLine("Ingrese el segundo numero:");
    entrada = Console.ReadLine();
    int numero_2;
    if (int.TryParse(entrada, out numero_2))
    {
        if (numero_1 > numero_2)
        {
            Console.WriteLine("El numero 1: " + numero_1 + "es el maximo");
            Console.WriteLine("El numero 1: " + numero_2 + "es el minimo");
        }
        else
        {
            Console.WriteLine("El numero 1: " + numero_2 + "es el maximo");
            Console.WriteLine("El numero 1: " + numero_1 + "es el minimo");
        }
    }
    else
    {
        Console.Write("Numero invalido.");
    }
}
else
{
    Console.Write("Numero invalido.");
}


