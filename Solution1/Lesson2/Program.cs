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
            VideoRegistrator instance = new VideoRegistrator();
            double[] events = new double[] { 1, 1.1, 1.6, 2.2, 2.4, 2.7, 3.9, 8.1, 9.1, 5.5, 3.7 };
            Double[] starts = instance.CalculateStartTimes(events, 1); //рассчитаем моменты старта, с длинной сеанса 1
            foreach(var item in starts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
