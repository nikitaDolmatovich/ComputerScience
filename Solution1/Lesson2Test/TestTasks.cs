using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson2;
using System.Collections.Generic;

namespace Lesson2Test
{
    [TestClass]
    public class TestTasks
    {
        [TestMethod]
        public void TestVideoRegistrator()
        {
            VideoRegistrator instance = new VideoRegistrator();
            Double[] events = new Double[] { 1, 1.1, 1.6, 2.2, 2.4, 2.7, 3.9, 8.1, 9.1, 5.5, 3.7 };
            Double[] testValues = new Double[] { 1.0, 2.2, 3.7, 5.5, 8.1 };

            Double[] result = instance.CalculateStartTimes(events, 1);

            for (var i = 0; i < result.Length; i++)
            {
                Assert.AreEqual<Double>(result[i], testValues[i]);
            }
            
        }

        [TestMethod]
        public void TestSheduler()
        {
            Sheduler instance = new Sheduler();
            Event[] events = {new Event(0, 3), new Event(0, 1), new Event(1, 2), new Event(3, 5),
                new Event(1, 3), new Event(1, 3), new Event(1, 3), new Event(3, 6),
                new Event(2, 7), new Event(2, 3), new Event(2, 7), new Event(7, 9),
                new Event(3, 5), new Event(2, 4), new Event(2, 3), new Event(3, 7),
                new Event(4, 5), new Event(6, 7), new Event(6, 9), new Event(7, 9),
                new Event(8, 9), new Event(4, 6), new Event(8, 10), new Event(7, 10)
            };
            List<Event> testValues = new List<Event> { new Event(0,1), new Event(1,2), new Event(2,3), new Event(3,5),
                new Event(6,7), new Event(8,9)};

            List<Event> result = instance.GetOptimalSheduler(events, 0, 10);

            for(var i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(result[i], testValues[i]);
            }
        }

        [TestMethod]
        public void TestBackpack()
        {
            Backpack instance = new Backpack();
            Item[] items = { new Item(60, 20), new Item(100, 50), new Item(120, 30),
                new Item(100, 50) };
            Double testResult = 200;
            Int32 volumeOfBackpack = 4;
            Int32 numberOfThings = 60;

            Double result = instance.CalculateTotalSum(items, numberOfThings, volumeOfBackpack);

            Assert.AreEqual<Double>(result, testResult);
        }
    }
}
