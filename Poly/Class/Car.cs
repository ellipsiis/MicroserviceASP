using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly.Class
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor <c>Car</c> gets the parameter inhereted from Vehicle class.
        /// </summary>
        /// <param name="start"></param> string to start value.
        /// <param name="stop"></param> string to stop value.
        /// <param name="speed"></param> string to speed value.
        /// <param name="direction"></param> string to direction value.
        public Car(string start, string stop, string speed, string direction) : base(start, stop, speed, direction)
        {
        }
        /// <summary>
        /// Method <c>Start</c> return the string "Start Car".
        /// </summary>
        /// <returns></returns>
        new public String Start() => "Start Car";
        /// <summary>
        /// Method <c>Stop</c> retunr the string "Stop Car".
        /// </summary>
        /// <returns></returns>
        new public String Stop() => "Stop Car";
        
    }
}
