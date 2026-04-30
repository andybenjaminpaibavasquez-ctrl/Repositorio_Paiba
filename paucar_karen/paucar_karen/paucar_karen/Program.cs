using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paucar_karen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tarifa = 100.0;
            Console.WriteLine("Ingrese el género del paciente (femenino/Masculino): ");
            string genero = Console.ReadLine();

            Console.WriteLine("Ingrese la especialidad (cardiologia/Fisioterapia/Oftalmologia/neonatologia): ");
            string especialidad = Console.ReadLine();

            double descuento = 0;

            if (genero == "Femenino")
                {
                   switch (especialidad)
                    {
                        case "cardiologia":
                        descuento = 33.20;
                        break;
                    case "Fisioterapia":
                        descuento = 25;
                        break;
                    case "Oftalmologia":
                        descuento = 7;
                        break;
                    case "neonatologia":
                        descuento = 16.30;
                        break;
                    default:
                        Console.WriteLine("Especialidad no válida.");
                        return;
                 }
            }
            else if (genero =="masculino")
            {
                switch (especialidad)
                {
                    case "cardiologia":
                        descuento = 38;
                        break;
                    case "Fisioterapia":
                        descuento = 10.5;
                        break;
                    case "Oftalmologia":
                        descuento = 23;
                        break;
                    case "neonatologia":
                        descuento = 23;
                        break;
                    default:
                        Console.WriteLine("Especialidad no válida. ");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Género no válido.");
                return;
        }
            double montoFinal = tarifa - (tarifa * descuento / 100);
            Console.WriteLine("El monto final para cancelar es: " + montoFinal);

    }
    }
}