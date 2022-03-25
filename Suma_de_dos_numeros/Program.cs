using System;

namespace Suma_de_dos_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            int num1 = 10;
            int num2 = 20;
            int resultado;
            //Colocar el procedimiento
            resultado = num1 + num2;
            //Imprimir en pantalla el resultado
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("El numero uno es: " + num1);
            Console.WriteLine("El numero dos es: " + num2);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("La suma de los dos numeros es: " + resultado);
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey(true);
        }
    }
}
