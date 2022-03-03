using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Clock
    {
        public void Parsetime(int _sec)
        {
            Console.Clear();

            Console.WriteLine($"{_sec} Seconds");

            if(_sec > 60)
            {
                int _minute = _sec / 60;
                Console.WriteLine($"It's {_minute} Minutes");
            }

            if (_sec > 3600)
            { 
                int _hour = _sec % 3600;
                Console.WriteLine($"It's {_hour} Hours");
            }
        }
    }
}
