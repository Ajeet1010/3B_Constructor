using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Access_Constructor
{
    // UC1- Constructor
    internal class Constructor
    {
        // fields or members.
        public int ID;
        public string Name;

        //1. Empty constructor
        public Constructor()
        {

        }
        public Constructor(string x)
        {
            Name = x;

        }
        public Constructor(int x, string y)
        {
            ID = x;
            Name = y;
        }
    }
}
