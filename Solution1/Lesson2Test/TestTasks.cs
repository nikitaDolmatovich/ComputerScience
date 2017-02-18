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
    }
}
