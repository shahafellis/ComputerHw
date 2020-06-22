using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHw
{
    [DebuggerDisplay("{_model}")]

    class Computer1
    {

        public string _model;

        public int _price;

        public int _numberOfProcessors;

        public float _screenSize;

        public bool _isTurnOn;

        public int tellMeThePrice()
        {
            return _price;
        }

        public float tellMeTheScreenSize()
        {
            return _screenSize;
        }

        public bool turnOnOrOff()
        {
            if (_isTurnOn == true)

                Console.WriteLine($"The coumputer is turn on");

            else
            {
                Console.WriteLine($"The coumputer is turn off");
            }

            return _isTurnOn;
        }

        public int addProcessor()

        {
            return _numberOfProcessors;
        }

        public override string ToString()
        {
            return $"Class computer mode {_model} price = {_price} number of processors = {_numberOfProcessors} screen size = {_screenSize} the computer is on or off ? {turnOnOrOff()} ";
        }


    }

}
