using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal class Registr
    {
        public static void ShowAllDevices(Device[] devices)
        {
            foreach (var device in devices)
            {
                Console.WriteLine(device.ShowInfoOfDevice());
            }
        }
        public static void ShowAllElectronicInDEvice(Device[] devices)
        {
            foreach (var device in devices)
            {
                Console.WriteLine(device.Electronic());
            }
        }
        public static void ShowAllDeviceWithoutElectricalDevices(Device[] devices)
        {
            foreach (var device in devices)
            {
                if (!device.isHaveElectricalDevices)
                {
                    Console.WriteLine(device.ShowInfoOfDevice());
                }
            }
        }
        public static void ShowAllDeviceWithoutEngine(Device[] devices)
        {
            foreach (var device in devices)
            {
                if (!device.parts.engine.isHaveEngine)
                {
                    Console.WriteLine(device.ShowInfoOfDevice());
                }
            }
        }

    }
}
