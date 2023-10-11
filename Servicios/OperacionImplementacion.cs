using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public int suma()
        {

            int n1;
            int n2;
            Console.WriteLine("Primer número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número");
            n2 = Int32.Parse(Console.ReadLine());

            int suma = n1 + n2;
            Console.WriteLine("El resultado es: " + suma);

            return suma;
        }
        public int resta()
        {

            int n1;
            int n2;
            Console.WriteLine("Primer número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número");
            n2 = Int32.Parse(Console.ReadLine());

            int resta = n1 - n2;
            Console.WriteLine("El resultado es: " + resta);

            return resta;
        }

        public int multiplicacion()
        {

            int n1;
            int n2;
            Console.WriteLine("Primer número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número");
            n2 = Int32.Parse(Console.ReadLine());

            int multiplicacion = n1 * n2;
            Console.WriteLine("El resultado es: " + multiplicacion);

            return multiplicacion;
        }
        public int division()
        {

            int n1;
            int n2;
            Console.WriteLine("Primer número");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número");
            n2 = Int32.Parse(Console.ReadLine());

            int division = n1 / n2;
            Console.WriteLine("El resultado es: " + division);

            return division;
        }
    }
}
