﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Timer
    {
        public delegate void TimeChange(int sec);
        public event TimeChange TimeChangeEvent;

        public void Start()
        {
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(10);
                TimeChangeEvent?.Invoke(i);
            }
        }
    }
}
