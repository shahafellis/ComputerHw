using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHw
{
    class Program
    {

        static void Main(string[] args)
        {
            Computer1 Dell = new Computer1()
            {
                _model = "Dell",

                _price = 8000,

                _numberOfProcessors = 5,

                _isTurnOn = true,

                _screenSize = 32


            };

            Computer1 HP = new Computer1()
            {
                _model = "HP",

                _price = 5000,

                _numberOfProcessors = 4,

                _isTurnOn = false,

                _screenSize = 28
            };

            Computer1 Lenovo = new Computer1()
            {

                _model = "Lenovo",

                _price = 10000,

                _numberOfProcessors = 6,

                _isTurnOn = true,

                _screenSize = 34
            };



            Console.WriteLine(Dell);





        }
    }
}