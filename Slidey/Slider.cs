using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayerController;
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


        public int SendValues(int value)
        {
            if (value != currentValue)
            {
                currentValue = value;
                return value;
            }
            else
            {
                return -1;
            }
        }

        int getCurrentPid()
        {
            String appname = GetActiveWindowTitle();
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            //Console.WriteLine(p.MainWindowTitle);
            return p.Id;
        }



         //CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;


        public int getVolume()
        {

            float? value;
            
            if (currentMode == MASTER)
            {
                float volume = AudioManager.GetMasterVolume();
                return Convert.ToInt32(volume);//Convert.ToInt32(defaultPlaybackDevice.Volume);
            }

            else if (currentMode == ESPECIFIC)
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
                
                value = VolumeHandler.GetApplicationVolume(pid1);
                return Convert.ToInt32(value);


            }
            return 0;
        }

        public void changeVolume(int value)
        {
            if(currentMode == MASTER)
            {
                AudioManager.SetMasterVolume(value);
                currentValue = value;
            }

            else if(currentMode == ESPECIFIC)
            {
                //changeVolume of focused
                if (value != currentValue) {
                    String appname = GetActiveWindowTitle();
                    IntPtr hwnd = GetForegroundWindow();
                    uint pid;
                    GetWindowThreadProcessId(hwnd, out pid);
                    Process p = Process.GetProcessById((int)pid);
                    //Console.WriteLine(p.MainWindowTitle);
                    int pid1 = p.Id;
                    //appname = "Spotify";
                    VolumeHandler.SetApplicationVolume(pid1, value);
                    currentValue = value;
                }
                


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
