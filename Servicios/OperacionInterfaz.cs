using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal interface OperacionInterfaz
    {
        public int suma();
        /// <summary>
        /// Método que realiza la suma
        /// 111023 - lig
        /// </summary>
        /// <returns>Devuelve un valor entero y nos da el resultado de la suma</returns>
        public int resta();
        /// <summary>
        /// Método que realiza la resta
        /// 111023 -lig
        /// </summary>
        /// <returns>Devuelve un valor entero y nos da el resultado de la resta</returns>

        public int multiplicacion();
        /// <summary>
        /// Método que realiza la multiplicación
        /// 111023 -lig
        /// </summary>
        /// <returns>Devuelve un valor entero y nos da el resultado de la multiplicación</returns>

        public int division();
        /// <summary>
        /// Método que realiza la división
        /// 111023 -lig
        /// </summary>
        /// <returns>Devuelve un valor entero y nos da el resultado de la división</returns>
    }
}
