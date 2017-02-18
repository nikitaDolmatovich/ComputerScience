using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class VideoRegistrator
    {
        public Double[] CalculateStartTimes(Double[] events, Double workDuration)
        {
            List<Double> result = new List<Double>();
            Int32 index = 0;

            Array.Sort(events);

            result.Add(events[index++]);

            while( index < events.Length)
            {
                Double startWork = events[index];

                if(result[result.Count - 1] + workDuration < startWork)
                {
                    result.Add(startWork);
                }
                index++;
            }

            return result.ToArray<Double>();
        }
    }
}
