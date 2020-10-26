using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_stack_queue_deck
{
    class Queue
    {
        public string ElementName { get; set; }
        public int Place { get; set; }

        public Queue(string _name, int _place)
        {
            ElementName = _name;
            Place = _place;
        }
    }
}
