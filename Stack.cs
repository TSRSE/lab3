using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_stack_queue_deck
{
    class Stack
    {
        public string ElementName { get; set; }
        public int Place { get; set; }

        public Stack(string _name, int _place)
        {
            ElementName = _name;
            Place = _place;
        }
    }
}
