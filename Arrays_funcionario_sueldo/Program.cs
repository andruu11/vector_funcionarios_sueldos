using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos los vectores
            string[] funcionarios = new string[5];
            int[] sueldos = new int[5];
            //introducimos los datos al vector
            for (int f = 0; f < funcionarios.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado " + (f + 1) + ": ");
                funcionarios[f] = Console.ReadLine();
                Console.Write("Ingrese el sueldo " + (f + 1) + ": ");
                sueldos[f] = Convert.ToInt32(Console.ReadLine());
            }

            //hallamos el sueldo mayor 
            int mayor;
            int pos;
            mayor = sueldos[0];
            pos = 0;
            for (int f = 1; f < funcionarios.Length; f++)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + funcionarios[pos]);
            Console.WriteLine("Tiene un sueldo de: " + mayor);
            Console.ReadKey();

        }
    }
}
