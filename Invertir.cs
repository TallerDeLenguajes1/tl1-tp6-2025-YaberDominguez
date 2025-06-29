public class Invertir_numero
{
    public static int Invertir(int numero)
    {
        int numero_invertido = 0;
        while (numero != 0)
        {
            int ultimo_digito = numero % 10;
            numero_invertido = numero_invertido * 10 + ultimo_digito;
            numero = numero / 10;
        }
        return numero_invertido;
    } 
}