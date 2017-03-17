using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test
{
    class Program
    {
        static void Main(string[] args)
        {
            car auto = new car();
            car.consulta(auto);
            car.mostrar(auto);
        }

        class car
        {
            public string modelo { get; set; }
            public string marca { get; set; }
            public string year { get; set; }
            public bool nuevo { get; set; }

            public static void consulta( car auto) // nombro el objeto de tipo car
            {
                
                Console.Write("Ingrese Marca Auto: ");
                auto.marca = Console.ReadLine();
                Console.Write("Ingrese Modelo Auto: ");
                auto.modelo = Console.ReadLine();
                Console.Write("Ingrese año Auto: ");
                auto.year = Console.ReadLine();
                Console.Write("Ingrese estado del Auto 'True' si es nuevo 'False' si es usado : ");
                auto.nuevo = Boolean.Parse(Console.ReadLine());

                Console.ReadLine();
            }
            public static void mostrar(car auto) // nombro el objeto de tipo car
            {

                Console.Write(" Auto: {0} -  Modelo: {1} - Año: {2} - Nuevo:{3} ",auto.marca,auto.modelo,auto.year,auto.nuevo);
            
                Console.ReadLine();
            }
        }
    }
}
