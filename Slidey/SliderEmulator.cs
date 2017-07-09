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

namespace Slidey
{
    public partial class SliderEmulator : MetroFramework.Forms.MetroForm
    {

        Slider Slider1 = new Slider("S1");
        Slider Slider2 = new Slider("S2");
        

        public SliderEmulator()
        {
            InitializeComponent();
            sendTimer.Start();
            

        }

        private void sendTimer_Tick(object sender, EventArgs e)
        {
            Slider1.SendValues(TrackBar1.Value); label1.Text = TrackBar1.Value.ToString();
            Slider2.SendValues(TrackBar2.Value); label2.Text = TrackBar2.Value.ToString();

        }
    }
}
