using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    public class JulieClass
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public JulieClass(string name, string address) 
        { 
            Name = name;
            Address = address;
        }
    }
}
