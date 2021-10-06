using System;

namespace suma2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero, el cual será sumado por 23");
            int numero = Convert.ToInt32(Console.ReadLine());
            int numero2 = 23;

            int resultado = numero + numero2;

            Console.WriteLine("el resultado de la suma es:" + Convert.ToString(resultado));

        }
    }
}
