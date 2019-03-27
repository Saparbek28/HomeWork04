using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane[] airplanes = new Airplane[5];
            airplanes[0] = new Airplane("Су-220", "Белый - Красный", "Пассажирский", 2500, 30, 50);
            airplanes[1] = new Airplane("Су-830", "Желтый - Белый", "Грузовой", 2501, 70, 90);
            airplanes[2] = new Airplane("Су-160", "Синий - Зеленый", "Президентский", 2520, 35, 55);
            airplanes[3] = new Airplane("Су-520", "Красный - Желтый", "военный грузовой", 2600, 40, 60);
            airplanes[4] = new Airplane("Су-640", "Белый - Красный", "Международный", 2530, 60, 80);

            for (int i = 0; i < airplanes.Length; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("[" + i + "]\n" + airplanes[i].AirplaneInfo());
                Console.WriteLine("-----------------------------------");
            }
            Console.ReadLine();
        }
    }
}
