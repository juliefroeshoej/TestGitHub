using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub.ClassSarah
{
    public class Sarah
    {
        private int alder = 25;

        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        public Sarah(int alder)
        {
            Alder = alder;
        }
    }
}
