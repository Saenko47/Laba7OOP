using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal class AirBaloon: Device
    {
        Random random = new Random();
        public string name;
      
        bool isHaveElectricalDevices => false;
        public Parts part;
        public string type = "AirBaloon";
        

        public static Parts isEverthingOkay(Parts parts)
        {
            if (parts.wheels > 0) { throw new Exception("Baloon with wheel?"); }
            if (parts.doors > 0) { throw new Exception("Baloon with door?"); }
            if (parts.seats < 1 && parts.doors >= 8) { throw new Exception("Theres no seats in Baloon"); }
            if (!parts.engine.isHaveEngine) { throw new Exception("Baloon without engine"); }
            if (parts.baloon ==  null) { throw new Exception("Theres no balooon in Balooon"); }
            return parts;
        }
        public AirBaloon(Parts part, string name) : base(part, name)
        {
            this.part = isEverthingOkay(part);
            this.name = name;
            
        }
        override public int Weight()
        {
            int weight = random.Next(100, 151);
           
            weight += part.seats * 8;
            weight += part.engine._weightOfEngine;
            weight += part.baloon.weight;
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
            return "Baloon name" + " " + base.ShowInfoOfDevice();
        }
    }
}
