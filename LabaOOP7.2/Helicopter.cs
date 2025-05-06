using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal class Helicopter: Device
    {
        Random random = new Random();
        public string name;
        public Parts part;
        public string[] ElectricalDevices = new string[] {
    "GPS Navigator",
    "VHF Radio",
    "Transponder (Mode C/S)",
    "Attitude Indicator",
    "Heading Indicator",
    "Altitude Warning System",
    "Turbine Monitoring System",
    "Helicopter Terrain Awareness and Warning System (HTAWS)",
    "Power Turbine Indicator",
    "Rotor RPM Indicator"};
        bool isHaveElectricalDevices => true;
        public string type => "Helicopter";
       
        public static Parts isEverthingOkay(Parts parts)
        {
            if (parts.windows <= 0) { throw new Exception("Thres problem with window"); }
            if (parts.wheels < 2 && parts.doors >= 4) { throw new Exception("thres problem with wheels of Helicopter"); }
            if (parts.doors <= 0 && parts.doors >= 5) { throw new Exception("thres problem with doors of Helicopter"); }
            if (parts.seats < 1 && parts.doors >= 8) { throw new Exception("Theres no seats in Helicopter"); }
            if (!parts.engine.isHaveEngine) { throw new Exception("Theres no engine in Helicopter"); }
            if (parts.blades.count < 2 && parts.blades.count > 6) { throw new Exception("Theres no blades in Helicopter"); }
            return parts;
        }
        public Helicopter(Parts part, string name) : base(part, name)
        {
            this.part = isEverthingOkay(part);
            this.name = name;
           
        }
        public Parts Part
        {
            get { return parts; }
            set { parts = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        override public int Weight()
        {
            int weight = random.Next(650,751);
            weight += part.wheels * 4;
            weight += part.doors * 50;
            weight += part.windows * 15;
            weight += part.seats * 8;
            weight += part.engine._weightOfEngine;
            weight += part.blades.count * part.blades.weight;
            return weight;
        }
        override public string Electronic()
        {
            string text;
            StringBuilder sb = new StringBuilder();
            if (isHaveElectricalDevices)
            {
                sb.AppendLine("This device has electrical devices:");
                sb.AppendLine(string.Join(", ", ElectricalDevices));
                text = sb.ToString();
            }
            else { text = "Theres no electrical device in aircraft("; }
            return text;
        }
        public override string ShowInfoOfDevice()
        {
            return "Helicopter name" + " " + base.ShowInfoOfDevice();
        }
    }
    

    
}
