using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poly.Class;

namespace PolyTest
{
    [TestClass]
    public class TestVehicle
    {
        Vehicle vehicleInstance = new("start", "stop", "speed", "direction");

        [TestMethod]
        public void TestStart_forVehicle_superclass()
        {    
            var startString = "start";
            Assert.AreEqual(startString, vehicleInstance.Start());
        }
        [TestMethod]
        public void TestStop_forVehicle_superclass()
        {
            var stopString = "stop";
            Assert.AreEqual(stopString, vehicleInstance.Stop());
        }
        public void TestDirection_forVehicle_superclass()
        {
            var directionString = "direction";
            Assert.AreEqual(directionString, vehicleInstance.Direction());
        }
    }
}