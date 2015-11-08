using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerProyectoS3B
{
    class Program
    {
        static void Main(string[] args)
        {
            //programa switch
            string nombre;
            Console.WriteLine("Ingrese un nombre:");
            nombre = Console.ReadLine();
            switch (nombre){
                case "Pedro":
                    Console.WriteLine("1");
                    break;
                case "Ana":
                    Console.WriteLine("2");
                    break;
                case "Jorge":
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("4");
                    break;
            }
            //Programa 3 usando arreglo
            /*int[] a = new int[2];
            a[0] = 2;
            a[1] = 5;
            for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Int32.Parse(Console.ReadLine());
                }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, (a[i]));
            }
            */
            //Programa 2
            /* r = t + i;
               //Console.WriteLine("Primer Proyecto variable:"+(i+1));
               //Console.WriteLine(t + "+"+(i)+"= "+r );
               //c = c + r;            
               //Console.WriteLine("total: " +c);
              
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, (a[i]*2));
            }
           */
        }

    }
}
