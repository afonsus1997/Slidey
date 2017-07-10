using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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

        #region DLLS
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

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
                String appname = GetActiveWindowTitle();
                IntPtr hwnd = GetForegroundWindow();
                uint pid;
                GetWindowThreadProcessId(hwnd, out pid);
                Process p = Process.GetProcessById((int)pid);
                //Console.WriteLine(p.MainWindowTitle);
                int pid1 = p.Id;
                //appname = "Spotify";
                VolumeHandler.SetApplicationVolume(pid1, value);


            }

            /*
            void serialTextConverter()
            {
                string text = SerialEmulator.fromSliderToProgram;
                int value;
                int sliderNumber;
                if (text[0] == 'S' && Int32.TryParse(text[1].ToString(), out value))
                {


                    value = Convert.ToInt32(text.Substring(2));
                    String appname = GetActiveWindowTitle();
                    IntPtr hwnd = GetForegroundWindow();
                    uint pid;
                    GetWindowThreadProcessId(hwnd, out pid);
                    Process p = Process.GetProcessById((int)pid);
                    //Console.WriteLine(p.MainWindowTitle);
                    int pid1 = p.Id;
                    //appname = "Spotify";
                    VolumeHandler.SetApplicationVolume(pid1, value);
                }

            }*/



        }




    }
}
