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


#region MODES
            public const int MASTER = 0;
            public const int ESPECIFIC = 1;
#endregion




        public int currentValue = 0;
        public int currentMode = MASTER;
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


        public void changeVolume(int value)
        {
            if(currentMode == MASTER)
            {
                //change master Volume
            }

            else if(currentMode == ESPECIFIC)
            {
                //changeVolume of focused
            }


        }




    }
}
