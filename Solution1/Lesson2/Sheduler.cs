using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Sheduler
    { 
        public List<Event> GetOptimalSheduler(Event[] events, Int32 from, Int32 to)
        {
            List<Event> list = new List<Event>();
            Array.Sort(events);

            Int32 nextEvent = from;

            for(var i = 0; i < events.Length; i++)
            {
                Event currentEvent = events[i];

                if(currentEvent.Start >= nextEvent && currentEvent.Finish <= to)
                {
                    nextEvent = currentEvent.Finish;
                    list.Add(currentEvent);
                }
            }

            return list;
        }
    }
}
