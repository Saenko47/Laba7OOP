using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal class AirPlane: Device
    {
        Random random = new Random();
        public string[] ElectricalDevices = new string[] {  "GPS Navigator",
    "VHF Radio",
    "Transponder (Mode C/S)",
    "Attitude Indicator",
    "Heading Indicator",
    "Altimeter",
    "Airspeed Indicator",
    "Vertical Speed Indicator",
    "Autopilot",
    "EFIS (Electronic Flight Instrument System)"};
        bool isHaveElectricalDevices => true;
        public Parts part;
        public string name;
        public string type => "airplane";
        public int weight => Weight();
       
        public static Parts isEverthingOkay(Parts parts) {
            if (parts.windows <= 0) { throw new Exception("Thres problem with window"); }
            if (parts.wheels < 2 && parts.doors >= 4) { throw new Exception("thres problem with wheels of airplain"); }
            if (parts.doors <= 0 && parts.doors >= 5) {throw new Exception("thres problem with doors of airplain"); }
            if (parts.seats < 1 && parts.doors >= 8 ) { throw new Exception("Theres no seats in airplane"); }
            if (!parts.engine.isHaveEngine) { throw new Exception("Theres no engine in airplane"); }
            if (parts.wings.count != 2) { throw new Exception("Theres no wings in airplane"); }
            return parts;
        }
       
        public AirPlane(Parts part, string name) : base(part, name)
        {
            this.part = isEverthingOkay(part);
            this.name = name;
            
        }
        public Parts Part
        {
            get { return part; }
            set { part = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        override public int Weight()
        {
            int weight = random.Next(500,801);
            weight += part.wheels * 4;
            weight += part.doors * 200;
            weight += part.windows * 25;
            weight += part.seats * 8;
            weight += part.engine._weightOfEngine;
            weight += part.wings.count * part.wing.weight;
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
            return "airplane name"+ " " + base.ShowInfoOfDevice();
        }

    }
}
