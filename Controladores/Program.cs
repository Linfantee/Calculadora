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
            OperacionInterfaz op = new OperacionImplementacion();

            //Procedimiento
            while (!cerrarCalculadora)
            {


                OpcionSeleccionada = mi.mostrarCalculadoraYResultado();
                
                switch (OpcionSeleccionada)
                {
                       
                    case 1:
                        op.suma();
                        break;
                    case 2:
                        op.resta();
                        break;
                    case 3:
                        op.multiplicacion();    
                        break;
                    case 4:
                        op.division();  
                        break;
                    case 5:
                        cerrarCalculadora = true;
                        break;
                




                }






                

            }

        }

    }

}