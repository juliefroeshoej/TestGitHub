using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub.ClassSarah
{
    public class Class1
    {
		private int alder = 25;

		public int Alder
		{
			get { return alder; }
			set { alder = value; }
		}

		public Class1(int alder)
		{
			Alder = alder;
		}
	}
}
