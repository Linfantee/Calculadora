using Calculadora.Servicios;

namespace Calculadora
{

    class Program
    {

        //Variables
        static void Main(string[] args)
        {
            int OpcionSeleccionada;
            bool cerrarCalculadora = false;
            MenuInterfaz mi = new MenuImplementacion();


            //Procedimiento
            while (!cerrarCalculadora)
            {


                OpcionSeleccionada = mi.mostrarCalculadoraYResultado();
                
                switch (OpcionSeleccionada)
                {
                       
                    case 1:
                        mi.suma();
                        break;
                    case 2:
                        mi.resta();
                        break;
                    case 3:
                        mi.multiplicacion();    
                        break;
                    case 4:
                        mi.division();  
                        break;
                   




                }






                

            }

        }

    }

}