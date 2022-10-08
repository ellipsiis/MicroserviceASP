using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly.Class
{
    /// <summary>
    /// Class <c>Vehicle</c> model for gave characteristics to diversal type of vehicles
    /// </summary>
    public class Vehicle
    {
        protected String start;
        protected String stop;
        protected String speed;
        protected String direction;

        /// <summary>
        /// Constructor <c>Vehicle</c> constructor to Vehicle object
        /// </summary>
        /// <param name="start"></param> string to start value
        /// <param name="stop"></param> string to stop value
        /// <param name="speed"></param> string to speed value
        /// <param name="direction"></param> string to direction value 
        public Vehicle(String start, String stop, String speed, String direction)
        {
            this.start = start;
            this.stop = stop;
            this.speed = speed;
            this.direction = direction;
        }
        /// <summary>
        /// Method <c>Start</c> returning "start" string value
        /// </summary>
        /// <returns></returns>
        public String Start() => "start";
        /// <summary>
        /// Method  <c>Stop</c> return "stop" string value
        /// </summary>
        /// <returns></returns>
        public String Stop() => "stop";
        /// <summary>
        /// Method <c>Speed</c> return "speed" string value
        /// </summary>
        /// <returns></returns>
        public String Speed() => "speed";
        /// <summary>
        /// Method <c>Directions</c> return "direction" string value
        /// </summary>
        /// <returns></returns>
        public String Direction() => "direction";

    }
}
