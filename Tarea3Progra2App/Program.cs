using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3Progra2App.Properties;

namespace Tarea3Progra2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0, numasis1, localidad, sublocal1, sublocal2, sublocal3, totlocal1, totlocal2, totlocal3,cargo,maxasis1=4;

            Cls_asistente Ind = new Cls_asistente();
            
            
            while (op!=3)
            {
                Console.WriteLine("Bienvenidos a la Federacion Costarricense de Futbol");
                Console.WriteLine("Sistema venta de entradas");
                Console.WriteLine("Partido CR vs Mexico 5 noviembre 2018");
                Console.WriteLine("1.Ingrese los asistentes");
                Console.WriteLine("2.Elija la localidad");
                Console.WriteLine("3.Salir");
                Console.WriteLine("Ingrese la opcion deseada");
                op= int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Ind.Ind();
                        break;
                    case 2:
                        
                        
                        Console.WriteLine("Digite el numero de asistentes que registro");
                        numasis1 = int.Parse(Console.ReadLine());
                        if (numasis1 > maxasis1)
                        {
                            numasis1 = maxasis1;
                            Console.WriteLine($"Solo se pueden inscribir hasta {maxasis1} asistentes");
                        }
                        Console.WriteLine("Digite el numero de localidad que desea: ");
                        Console.WriteLine("1.Sol Norte/Sur. Precio:10500 colones");
                        Console.WriteLine("2.Sombra Este/Oeste. Precio: 20500 colones");
                        Console.WriteLine("3.Preferencial. Precio: 25500 colones");
                        localidad=int.Parse(Console.ReadLine());
                        sublocal1=(10500*numasis1);
                        sublocal2=(20500*numasis1);
                        sublocal3=(25500*numasis1);
                        totlocal1=(sublocal1+(1000*numasis1));
                        totlocal2=(sublocal2+(1000*numasis1));
                        totlocal3=(sublocal3+(1000*numasis1));
                        cargo = numasis1*1000;
                        if (localidad==1)
                        {
                            Ind.Imprimir();
                            Console.WriteLine("Sol Norte/Sur");
                            Console.WriteLine("Cantida de entradas: "+numasis1);
                            Console.WriteLine("Costo de entradas: "+sublocal1);
                            Console.WriteLine("Cargo de servicio: " +cargo);
                            Console.WriteLine("Total: "+totlocal1);

                        }
                        else
                        if (localidad==2)
                        {
                            Ind.Imprimir();
                            Console.WriteLine("Sombra Este/Oeste");
                            Console.WriteLine("Cantida de entradas: "+numasis1);
                            Console.WriteLine("Costo de entradas: "+sublocal2);
                            Console.WriteLine("Cargo de servicio: " +cargo);
                            Console.WriteLine("Total: "+totlocal2);
                        }
                        else
                            if (localidad==3)
                        {
                            Ind.Imprimir();
                            Console.WriteLine("Preferencial");
                            Console.WriteLine("Cantida de entradas: "+numasis1);
                            Console.WriteLine("Costo de entradas: "+sublocal3);
                            Console.WriteLine("Cargo de servicio: " +cargo);
                            Console.WriteLine("Total: "+totlocal3);
                        }

                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta");
                        break;



                }
            }
        }
    }
}
