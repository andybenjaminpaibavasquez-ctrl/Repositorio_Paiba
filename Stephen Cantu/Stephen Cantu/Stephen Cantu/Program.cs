using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stephen_Cantu
{
    internal class Program
    {
        static void Main(string[] args)
        
        {

            Console.Write("Ingrese la cantidad de trabajadores: ");
            int n = int.Parse(Console.ReadLine());

            double totalSueldos = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nTrabajador " + i);

                Console.Write("Horas trabajadas: ");
                double horas = double.Parse(Console.ReadLine());

                Console.Write("Pago por hora: ");
                double pagoHora = double.Parse(Console.ReadLine());

                double sueldo = horas * pagoHora;

                Console.WriteLine("Sueldo del trabajador " + i + ": S/ " + sueldo);

                totalSueldos = totalSueldos + sueldo;
            }

            Console.WriteLine("\nTotal a pagar a todos los trabajadores: S/ " + totalSueldos);

        }
    }
}
