using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3Progra2App.Properties
{
    internal class Cls_asistente
    {
        string[] asistentes;
        int cedula;

        public void Ind()
        {
            int numasis ;
            int maxasis = 4;
            Console.WriteLine("Ingrese la cantidad de asistentes");
            numasis = int.Parse(Console.ReadLine());
            if (numasis > maxasis)
            {
                numasis = maxasis;
                Console.WriteLine($"Solo se pueden inscribir hasta {maxasis} asistentes. Se tomarán los primeros {maxasis}.");
            }
            asistentes = new string[numasis];
            
            for (int i =0 ; i<asistentes.Length; i++)
            {

                Console.WriteLine("Ingrese el nombre del asistente "+(i+1));
                asistentes[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de cedula");
                cedula= int.Parse(Console.ReadLine());

            }
        }
        public void Imprimir()
        {
            

            Console.WriteLine("Los nombres de los asistentes son: ");
            for (int i = 0; i < asistentes.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + asistentes[i].ToString());
                Console.WriteLine("Cedula "+ cedula);
                
            }
        }
    }
}
