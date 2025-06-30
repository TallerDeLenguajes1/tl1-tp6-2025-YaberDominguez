int opcion = 1;
while (opcion != 0)
{
    Console.Write("\nIngrese la operacion que quiere realizar:");
    Console.Write("1)Sumar");
    Console.Write("2)Restar");
    Console.Write("3)Multiplicar");
    Console.Write("4)Dividir");
    string entrada = Console.ReadLine();
    if (int.TryParse(entrada, out opcion))
    {
        int resultado;
        int numero_1;
        int numero_2;
        string entrada_1;
        string entrada_2;
        Console.Write("Ingrese el primer numero:");
        entrada_1 = Console.ReadLine();
        Console.Write("Ingrese el segundo numero:");
        entrada_2 = Console.ReadLine();
        if (int.TryParse(entrada_1, out numero_1) && int.TryParse(entrada_2, out numero_2))
        {
            switch (opcion)
            {
                case 1:
                    resultado = numero_1 + numero_2;
                    Console.WriteLine("La suma de los numeros ingresados es: " + resultado);
                    break;
                case 2:
                    resultado = numero_1 - numero_2;
                    Console.WriteLine("La resta de los numeros ingresados es: " + resultado);
                    break;
                case 3:
                    resultado = numero_1 * numero_2;
                    Console.WriteLine("La multiplicacion de los numeros ingresados es: " + resultado);
                    break;
                case 4:
                    if (numero_2 == 0)
                    {
                        Console.Write("Numeros invalido. No se puede realizar una division con 0.");
                    }
                    else
                    {
                        resultado = numero_1 / numero_2;
                        Console.WriteLine("La division de los numeros ingresados es: " + resultado);
                    }
                    break;
                default:
                    Console.Write("Opcion ingresada invalida.");
                    break;
            }
        }
        else
        {
            Console.Write("Los numeros ingresados son invalidos. Ingreselos nuevamente.");
        }
    }
    else
    {
        Console.Write("Error: Elija entre la opcion 1 a 4.");
    }
    Console.Write("Quiere realizar otra operacion:");
    Console.Write("1)Si");
    Console.Write("2)No");
    entrada = Console.ReadLine();
    if (int.TryParse(entrada, out opcion) && opcion == 2)
    {
        opcion = 0;
    }
    Console.WriteLine("----------------------------------------");
}