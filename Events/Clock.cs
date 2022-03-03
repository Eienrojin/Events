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
            int _minute = _sec / 60;
            int _hour = _minute / 60;

            Console.WriteLine($"{_sec} Seconds");
            Console.WriteLine($"{_minute} Minutes");
            Console.WriteLine($"{_hour} Hours");
        }
    }
}
