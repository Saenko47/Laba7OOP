using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal interface IDevice
    {
        Parts Parts { get; set; }
       
        string Name { get; set; }
        bool isHaveElectricalDevices { get; set; }

        string ShowInfoOfDevice();


    }
}
