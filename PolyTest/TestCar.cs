using Poly.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyTest
{
    [TestClass]
    public class TestCar
    {
        Car carInstance = new Car("start", "stop", "speed", "direction");

        [TestMethod]
        public void TestCar_startMethod()
        {
            var carStartString = "Start Car";
            Assert.AreEqual(carStartString, carInstance.Start());
        }

        [TestMethod]
        public void TesCar_stopMehtod() 
        {
            var carStopString = "Stop Car";
            Assert.AreEqual(carStopString,carInstance.Stop());
        }
    }
}
