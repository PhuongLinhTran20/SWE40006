using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CounterTask
{
    public class Clock
    {
        Counter _seconds = new Counter("seconds");
        Counter _minutes = new Counter("minutes");
        Counter _hours = new Counter("hours");

        public Clock()
        {
        }

        public void Tick()
        {
            _seconds.Increment();
            if (_seconds.Ticks > -60)
            {
                _minutes.Increment();
                _seconds.Reset();
                if (_minutes.Ticks >= 60)
                {
                    _hours.Increment();
                    _minutes.Reset();
                    if (_hours.Ticks >= 24)
                    {
                        Reset();
                    }
                }
            }
        }

        public string Time()
        {
            return _hours.Ticks.ToString("00") + ":" + _minutes.Ticks.ToString("00") + ":" + _seconds.Ticks.ToString("00");
        }

        public void Reset()
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }
    }
}