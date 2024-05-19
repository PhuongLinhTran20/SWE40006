using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTask
{
    public class Counter
    {
        private int _value;
        private string _name;
    public Counter(string name)
        {
            _name = name;
            _value = 0;
        }
        public void Increment()
        {
            _value++;
        }

    public void Reset()
        {
            _value = 0;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Ticks
        {
            get => _value;

        }
    }
}