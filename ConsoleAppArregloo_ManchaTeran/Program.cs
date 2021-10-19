using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArregloo_ManchaTeran
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] a = new Alumno[5];
            for(int i =0; i < a.Length; i++)
            {
                a[i] = new Alumno();
                a[i].Nombre = "";
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" - NOMBRE :");
                a[i].Nombre = Console.ReadLine();

                a[i].Matriula = "";
                Console.WriteLine(" - MATRICULA :");
                a[i].Matriula = Console.ReadLine();

                a[i].Carrera = "";
                Console.WriteLine(" - CARRERA :");
                a[i].Carrera = Console.ReadLine();
            }

            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
