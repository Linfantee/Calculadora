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
            Console.WriteLine("5. Cerrar menú");
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
        
    }
}