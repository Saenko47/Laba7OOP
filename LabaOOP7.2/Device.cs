using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
   abstract internal class Device: IDevice, IComparable<Device>

    {
        public string[] ElectricalDevices { get; set; }
        public bool isHaveElectricalDevices { get; set; }
        public Parts parts;
        public string name;
        public string type;
        public int weight;

        public Device(Parts parts, string name, string[] electricalDevices)
        {
            this.parts = parts;
            this.name = name;
            ElectricalDevices = electricalDevices;
            
        }
        public Device(Parts parts, string name)
        {
            this.parts = parts;
            this.name = name;
            
        }

        public Parts Parts
        {
            get { return parts; }
            set { parts = value; }
        }

       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        abstract public string Electronic();

        abstract public int Weight();

        public virtual string ShowInfoOfDevice()
        {
           return $" {name}\n,weight {Weight()}, Parts:{parts.ShowInfoOfParts()}, {Electronic()}";
            
            
        }
        public int CompareTo(Device other)
        {
            if (other == null) return 1;
            else
                return this.Weight().CompareTo(other.Weight());
        }
        public int Compare(Device? x, Device? y)
        {
            if (x == null || y == null) return 0;
            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
   
}
