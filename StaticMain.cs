using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class StaticMain
    {

        static void Main(string[] args)
        {
             Tp1 ejercicio = new Tp1();
            Console.WriteLine(DateTime.Now.ToString("yyyy'-'MM'-'dd'HORA'HH':'mm':'ss"));
            Console.ReadLine();
            Console.WriteLine("Ejercicio 1 Suma de dos variables");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el numero A:");
            int numa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero B");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de la sume es:" + ejercicio.sumarNumero(numa,numb));
            Console.ReadLine();
            Console.WriteLine("Ejercicio 2 Cortar Cadena");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese una cadena de caracteres de 8 posiciones:");
            String cadena = (Console.ReadLine());
            Console.WriteLine("Resultado:" + ejercicio.validarCadena(cadena));
            Console.WriteLine(" ");
            Console.WriteLine("Indique una opcion:");
            Console.WriteLine("1 :BLANCO     2 :AZUL     3: NEGRO");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado: " + ejercicio.mostrarColor(opcion));

















        }



    }
}
