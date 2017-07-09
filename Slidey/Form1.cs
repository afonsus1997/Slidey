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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Form Slider = new SliderEmulator();
            Slider.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fromSerial.Text = SerialEmulator.fromSliderToProgram;
        }
    }
}
