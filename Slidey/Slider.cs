using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Slidey
{
    class Slider
    {
        public int currentValue = 0;
        public string name;

        public Slider(string inName)
        {
            name = inName;
        }


        public void SendValues(int value)
        {
            if(value != currentValue)
            {
                
                SerialEmulator.fromSliderToProgram = name + " " + value.ToString();
                currentValue = value;
            }
        }

        
    }
}
