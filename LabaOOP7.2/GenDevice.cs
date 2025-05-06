using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal class GenDevice
    {
        static Random rnd = new Random();
        public static string[] Nairplanes = new string[]
 {
    "Boeing 747",
    "Airbus A320",
    "Cessna 172",
    "Piper Cherokee",
    "Embraer E190"
 };

        // Для вертольотів
        public static string[] Nhelicopters = new string[]
        {
    "Bell 206",
    "Eurocopter AS350",
    "Sikorsky UH-60 Black Hawk",
    "Robinson R44",
    "Mi-8"
        };

        // Для повітряних шарів
        public static string[] NhotAirBalloons = new string[]
        {
    "Montgolfier",
    "Firefly",
    "Thunderbolt",
    "SkyDancer",
    "Ballooning Adventure"
        };

        // Для дельтапланів
        public static string[] NhangGliders = new string[]
        {
    "Wills Wing T2C",
    "Moyes Litespeed RX",
    "GliderX Swift",
    "NorthWing Addiction",
    "ICARO 2000 Laminar"
        };
        public static AirPlane[] GetAirplane(int i)
        {
            AirPlane[] airplanes = new AirPlane[i];
            for (int k = 0; k < i; ++k)
            {
                airplanes[k] = new AirPlane(new Parts(rnd.Next(2, 6), rnd.Next(1, 5), rnd.Next(2, 7), rnd.Next(1, 9), new Engine(true, rnd.Next(50, 101), "Gas", rnd.Next(500, 601)), new Wing(2, rnd.Next(50, 101))), Nairplanes[rnd.Next(0, Nairplanes.Length)]);
            }
            return airplanes;
        }
        public static Helicopter[] GetHelicopter(int i)
        {
            Helicopter[] helicopters = new Helicopter[i];
            for (int k = 0; k < i; ++k)
            {
                helicopters[k] = new Helicopter(new Parts(rnd.Next(2, 6), rnd.Next(1, 5), rnd.Next(2, 7), rnd.Next(1, 9), new Engine(true, rnd.Next(50, 101), "Gas", rnd.Next(500, 601)), new Blades(rnd.Next(2, 7), rnd.Next(50, 101))), Nhelicopters[rnd.Next(0, Nhelicopters.Length)]);
            }
            return helicopters;
        }
        public static AirBaloon[] GetAirBaloon(int i)
        {
            AirBaloon[] airBaloons = new AirBaloon[i];
            for (int k = 0; k < i; ++k)
            {
                airBaloons[k] = new AirBaloon(new Parts(rnd.Next(1, 9), new Engine(true, rnd.Next(500, 750), "Coal/Gas", rnd.Next(50, 121)), new Baloon(rnd.Next(150, 500))), NhotAirBalloons[rnd.Next(0, NhotAirBalloons.Length)]);
            }
            return airBaloons;
        }
        public static hang_glider[] GetHangGlider(int i)
        {
            hang_glider[] hangGliders = new hang_glider[i];
            for (int k = 0; k < i; ++k)
            {
                hangGliders[k] = new hang_glider(NhangGliders[rnd.Next(0, NhangGliders.Length)], new Parts(new Wing(2, rnd.Next(10, 16))));
            }
            return hangGliders;
        }
        public static Device[] GetAeroPark(int totalPerType)
        {
            int totalCount = totalPerType * 4;
            Device[] aeroPark = new Device[totalCount];
            int index = 0;


            for (int i = 0; i < totalPerType; i++, index++)
            {
                aeroPark[index] = new AirPlane(
                    new Parts(
                        rnd.Next(2, 6),
                        rnd.Next(1, 5),
                        rnd.Next(2, 7),
                        rnd.Next(1, 9),
                        new Engine(true, rnd.Next(50, 101), "Gas", rnd.Next(500, 601)),
                        new Wing(2, rnd.Next(50, 101))
                    ),
                    Nairplanes[rnd.Next(Nairplanes.Length)]
                );
            }


            for (int i = 0; i < totalPerType; i++, index++)
            {
                aeroPark[index] = new Helicopter(
                    new Parts(
                        rnd.Next(2, 6),
                        rnd.Next(1, 5),
                        rnd.Next(2, 7),
                        rnd.Next(1, 9),
                        new Engine(true, rnd.Next(50, 101), "Gas", rnd.Next(500, 601)),
                        new Blades(rnd.Next(2, 7), rnd.Next(50, 101))
                    ),
                    Nhelicopters[rnd.Next(Nhelicopters.Length)]
                );
            }


            for (int i = 0; i < totalPerType; i++, index++)
            {
                aeroPark[index] = new AirBaloon(
                    new Parts(
                        rnd.Next(1, 5),
                        new Engine(true, rnd.Next(50, 101), "Gas", rnd.Next(500, 601)),
                        new Baloon(rnd.Next(50, 101))
                    ),
                    NhotAirBalloons[rnd.Next(NhotAirBalloons.Length)]
                );
            }


            for (int i = 0; i < totalPerType; i++, index++)
            {
                aeroPark[index] = new hang_glider(
                    NhangGliders[rnd.Next(NhangGliders.Length)],
                    new Parts(new Wing(2, rnd.Next(10, 16)))
                );
            }

            return aeroPark;
        }
    }

}

