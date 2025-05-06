using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal class hang_glider:Device
    {
        Random random = new Random();
        public string name;
        public Parts part;
       
        public int weight => random.Next(25, 40);
        public bool isHaveElectricalDevices => false;
        public hang_glider(string name, Parts part) : base(part,name)
        {
            this.name = name;
            this.part = (parts.wing.count == 2)? part: throw new Exception("Thres problem with wings of hang glider");
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
        override public int Weight()
        {
            int weight = random.Next(500, 801);
            weight += part.wheels * 4;
            weight += part.doors * 200;
            weight += part.windows * 25;
            weight += part.seats * 8;
            weight += part.engine._weightOfEngine;
            weight += part.wings.count * 500;
            return weight;
        }
        public override string ShowInfoOfDevice()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"Type: {part.ShowInfoOfParts()}");
            sb.AppendLine($"Weight: {weight}");
            sb.AppendLine($"Is have electrical devices: {isHaveElectricalDevices}");
            return sb.ToString();
        }

    }
}
