using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        ///<sumary>
        ///Método que mos muestra la calculadora
        /// 101023 - lig
        /// </sumary> 

        public int mostrarCalculadoraYResultado()
        {
            int Seleccion;
            Console.WriteLine("-----------------");
            Console.WriteLine("Inicio Calculadora");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("-----------------");
            Seleccion = Console.ReadKey(true).KeyChar - ('0');

            return Seleccion;
        }
        /*
        public int introduzcaNumero()
        {

            Console.WriteLine("Introduzca un número");
            int valorAsignado = Console.ReadLine();
            int valorAsignado2 = Convert.ToInt32(Console.ReadLine());
            return valorAsignado;


        }
        */

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