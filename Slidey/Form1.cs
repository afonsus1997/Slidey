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
        Slider Slider1 = new Slider("S1");
        Slider Slider2 = new Slider("S2");

        

        #region SERIAL COMM
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

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();
                    serialPort1.DataReceived += serialPort1_DataReceived;
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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
            SerialHandler.RXstring = rxString;
            serialLabel.Text = rxString;
            updateVolume(rxString);
        }


#endregion

        

        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();

        }


        



        #region miscEvents

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();         //fecha a porta
        }




        #endregion

        private void comboS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboS1.Text == "Master") { Slider1.currentMode = 0; }
            else if (comboS1.Text == "Current App") { Slider1.currentMode = 1; }
        }

        private void comboS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboS2.Text == "Master") { Slider2.currentMode = 0; }
            else if (comboS2.Text == "Current App") { Slider2.currentMode = 1; }
        }

        void updateVolume(string rxString)
        {
            int value;
            if (rxString[0] == 'S' && Int32.TryParse(rxString[1].ToString(), out value))
            {
                if (value == 1)
                {
                    Slider1.changeVolume(Convert.ToInt32(rxString.Substring(2)));
                }
                if (value == 2)
                {
                    Slider2.changeVolume(Convert.ToInt32(rxString.Substring(2)));
                }
            }
        }


        





    }
}
