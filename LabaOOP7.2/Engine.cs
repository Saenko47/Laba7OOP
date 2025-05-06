using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal class Engine: IEngine
    {


        public bool _isHaveEngine;
        
        public int _powerOfEngine;
        public string _typeOfFuel;
        public int _weightOfEngine;

        public Engine(bool isHaveEngine, int powerOfEngine, string typeOfFuel, int weightOfEngine)
        {
            _isHaveEngine = isHaveEngine;
          
            _powerOfEngine = powerOfEngine;
            _typeOfFuel = typeOfFuel;
            _weightOfEngine = weightOfEngine;
        }

        public bool isHaveEngine
        {
            get { return _isHaveEngine; }
            set { _isHaveEngine = value; }
        }

        

        public int powerOfEngine
        {
            get { return _powerOfEngine; }
            set { _powerOfEngine = value; }
        }

        public string typeOfFuel
        {
            get { return _typeOfFuel; }
            set { _typeOfFuel = value; }
        }

        public int weightOfEngine
        {
            get { return _weightOfEngine; }
            set { _weightOfEngine = value; }
        }

        public string ShowInfoOfEngine()
        {
            return $"Engine: Power: {powerOfEngine} HP, Fuel Type: {typeOfFuel}, Weight: {weightOfEngine} kg, Present: {isHaveEngine}";
        }

    }
}
