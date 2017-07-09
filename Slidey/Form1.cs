using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Slidey
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //int lastVolume1 = SerialEmulator.fromSliderToProgram;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);





        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            //metroStyleManager1.Style = 
            Form Slider = new SliderEmulator();
            Slider.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fromSerial.Text = SerialEmulator.fromSliderToProgram;
            serialTextConverter();
        }

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

        void serialTextConverter()
        {
            string text = SerialEmulator.fromSliderToProgram;
            int value;
            int sliderNumber;
            if(text[0]=='S' && Int32.TryParse(text[1].ToString(), out value))
            {
                
                
                value = Convert.ToInt32(text.Substring(2));
                String appname = GetActiveWindowTitle();
              
                IntPtr hwnd = GetForegroundWindow();
                uint pid;
                GetWindowThreadProcessId(hwnd, out pid);
                Process p = Process.GetProcessById((int)pid);
                Console.WriteLine(p.MainWindowTitle);
                int pid1 = p.Id;
                //appname = "Spotify";
                VolumeHandler.SetApplicationVolume(pid1, value);
            }

        }


































        private void Form1_Leave(object sender, EventArgs e)
        {

            metroStyleManager1.Style = MetroColorStyle.Silver;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroColorStyle.Silver;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroColorStyle.Orange;
        }
    }
}
