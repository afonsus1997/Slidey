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
using System.IO.Ports;

namespace Slidey
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //int lastVolume1 = SerialEmulator.fromSliderToProgram;
        #region DLLS
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);
        #endregion

        string rxString;

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }


        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            //metroStyleManager1.Style = 
            Form Slider = new SliderEmulator();
            //Slider.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
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

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    connectButton.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    connectButton.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }





        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();         //fecha a porta
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
            SerialHandler.RXstring = rxString;
            serialLabel.Text = rxString;
        }





    
    }
}
