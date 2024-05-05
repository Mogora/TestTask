using System;
using System.Collections.Generic;
using System.Linq;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> objects = new List<string>();

            Console.WriteLine("Введите объекты (конец ввода - exit):");
            string value;
            while ((value = Console.ReadLine()) != "exit")
            {
                objects.Add(value);
            }

            Dictionary<string, int> colorOrder = new Dictionary<string, int>();

            Console.WriteLine("Задайте отношение порядка цветов (конец ввода - exit):");
            while (true)
            {
                Console.Write("Введите цвет: ");
                string color = Console.ReadLine();
                if (color == "exit") break;

                Console.Write("Введите порядок (целое число): ");
                int order = int.Parse(Console.ReadLine());

                colorOrder[color] = order;
            }

            var orderedObjects = objects.OrderBy(obj => colorOrder.ContainsKey(obj) ? colorOrder[obj] : int.MaxValue);

            Console.WriteLine("Отсортированный набор объектов:");
            foreach (var obj in orderedObjects)
            {
                Console.Write(obj + " ");
            }

            Console.ReadLine();
        }
    }
}
