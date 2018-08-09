using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_P2_CustomException
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }
    }
}
