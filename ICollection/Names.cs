using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection
{
    internal class Names 
    {
        public string Name { get; set; }
        public Names(string names)
        {
            Name = names;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
