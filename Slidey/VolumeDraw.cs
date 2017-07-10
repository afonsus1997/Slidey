using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slidey
{
    class VolumeDraw
    {
        public static int Hpos1 = 220;
        public static int Vpos1 = 22;
        public static int knob1posVer = 248;
        public static int knob2posVer = 354;
        public static int knobpos100 = 34;
        public static int knobpos0 = 234;

        public static int changeKnobPos(int value)
        {     
                return 234 - value*2;
        }


    }
}
