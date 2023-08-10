using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IteratorSample
{
   // Collection Item
    public class Elempoyee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Elempoyee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}