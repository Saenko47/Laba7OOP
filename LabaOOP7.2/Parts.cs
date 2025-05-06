using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP7._2
{
    internal class Parts: IPart
    {


        public int _wheels;
        public int _doors;
        public int _windows;
        public int _seats;
        public bool _isHaveEngine;
        public Wing? wing;
        public Blades? blades;
        public Baloon? baloon;
        public Engine? _engine;

        public Parts(int wheels, int doors, int windows, int seats, Engine engine, Wing wing)
        {
            _wheels = wheels;
            _doors = doors;
            _windows = windows;
            _seats = seats;
            _engine = engine;
            this.wing = wing;
        }
        public Parts(  int seats, Engine engine, Baloon baloon)
        {
            
            
            
            _seats = seats;  
            _engine = engine;
            this.baloon = baloon;
        }
        public Parts(int wheels, int doors, int windows, int seats, Engine engine, Blades blades)
        {
            _wheels = wheels;
            _doors = doors;
            _windows = windows;
            _seats = seats;
            _engine = engine;
            this.blades = blades;
        }
        public Parts(Wing wing)
        {
            this.wing = wing;
        }


        public int wheels
        {
            get { return _wheels; }
            set { _wheels = value; }
        }

        public int doors
        {
            get { return _doors; }
            set { _doors = value; }
        }

        public int windows
        {
            get { return _windows; }
            set { _windows = value; }
        }

        public int seats
        {
            get { return _seats; }
            set { _seats = value; }
        }

        public Wing wings
        {
            get { return wing; }
            set { wing = value; }
        }
        public Blades Blades
        {
            get { return blades; }
            set { blades = value; }
        }
        public Baloon Baloon
        {
            get { return baloon; }
            set { baloon = value; }
        }
        public Engine engine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        public string WhatKindOfPart()
        {
            string text = "It doest have anything";
            if (wing != null) { text = $"It has {wing.count} wings"; }
            if (blades != null) { text = $"It has {blades.count} blades"; }
            if (baloon != null) { text = $"this baloon"; }
            return text;
           
        }
        public virtual string ShowInfoOfParts()
        {
            return $"Wheels: {wheels}, Doors: {doors}, Windows: {windows}, Seats: {seats},{WhatKindOfPart()}";
        }
    }
}

