using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal interface IEngine
    {
        bool isHaveEngine { get; set; }
        int powerOfEngine { get; set; }
        string typeOfFuel { get; set; }
        int weightOfEngine { get; set; }
        string ShowInfoOfEngine();
    }
}
