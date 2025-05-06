using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal interface IPart
    {
        int wheels { get; set; }
        int doors { get; set; }
        int windows { get; set; }
        int seats { get; set; }
        Wing wings { get; set; }
        Blades Blades { get; set; }
        Baloon Baloon { get; set; }
        string WhatKindOfPart();

        Engine engine { get; set; }
        string ShowInfoOfParts();

    }
}
