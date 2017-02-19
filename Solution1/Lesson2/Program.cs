using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Backpack instance = new Backpack();
            Item[] items = { new Item(60, 20), new Item(100, 50), new Item(120, 30),
                new Item(100, 50) };
            Double testResult = 200;
            Double volumeOfBackpack = 4;
            Double numberOfThings = 60;

            Console.WriteLine(instance.CalculateTotalSum(items, 60,4));
        }
    }
}
