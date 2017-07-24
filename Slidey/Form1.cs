﻿using System;
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
using System.Threading;
using Slidey.Properties;

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
            updateVolumeSerial(rxString);
        }


        #endregion



        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            timer1.Start();
            body1.Location = new Point(VolumeDraw.Hpos1, VolumeDraw.Vpos1);
            MaximizeBox = false;
            Slider1.currentMode = Properties.Settings.Default.slider1Status;
            Slider2.currentMode = Properties.Settings.Default.slider2Status;

            if (Slider1.currentMode == 0)  { comboS1.Text = "Master"; S1Box.Text = Slider1.modeHelpText[0]; appCombo1.Enabled = false; }
            if (Slider1.currentMode == 1) { comboS1.Text = "Current App"; S1Box.Text = Slider1.modeHelpText[1]; appCombo1.Enabled = false; }
            if (Slider1.currentMode == 2) { comboS1.Text = "Choose App..."; S1Box.Text = Slider1.modeHelpText[2]; appCombo1.Enabled = true; }


            if (Slider2.currentMode == 0) { comboS2.Text = "Master"; S2Box.Text = Slider2.modeHelpText[0]; appCombo1.Enabled = false; }
            if (Slider2.currentMode == 1) { comboS2.Text = "Current App"; S2Box.Text = Slider2.modeHelpText[1]; appCombo1.Enabled = false; }
            if (Slider1.currentMode == 2) { comboS2.Text = "Choose App..."; S2Box.Text = Slider2.modeHelpText[2]; appCombo1.Enabled = true; }






        }
        



        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();


            int value1 = Slider1.getVolume();


            if (value1 != Slider1.currentValue)
            {
                knob1.Location = new Point(VolumeDraw.knob1posVer, VolumeDraw.changeKnobPos(Slider1.getVolume()));
                Slider1.currentValue = value1;
                string send;
                if(Slider1.currentValue == 0)
                {
                    send = "0";
                }

                else if (Slider1.currentValue == 100)
                {
                    send = "99";
                }
                else
                {
                    send = Slider1.currentValue.ToString();
                }
                Console.WriteLine("Sent " + send);
                //Convert.ToInt32(send);
                if (serialPort1.IsOpen) { serialPort1.Write(send+'\n'); }
                
            }

            if (Slider1.currentMode == 0) { S1Box.Text = Slider1.modeHelpText[0]; appCombo1.Enabled = false; }
            if (Slider1.currentMode == 1) { S1Box.Text = Slider1.modeHelpText[1]; appCombo1.Enabled = false; }
            if (Slider1.currentMode == 2) { S1Box.Text = Slider1.modeHelpText[2]; appCombo1.Enabled = true; }
            if (Slider2.currentMode == 0) { S2Box.Text = Slider2.modeHelpText[0]; appCombo2.Enabled = false; }
            if (Slider2.currentMode == 1) { S2Box.Text = Slider2.modeHelpText[1]; appCombo2.Enabled = false; }
            if (Slider2.currentMode == 2) { S2Box.Text = Slider2.modeHelpText[2]; appCombo2.Enabled = true; }




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
                serialPort1.Close();
            Properties.Settings.Default.slider1Status= Slider1.currentMode ;
            Properties.Settings.Default.slider1Status=Slider1.currentMode  ;
            Properties.Settings.Default.Save();
            //fecha a porta
        }




        #endregion

        private void comboS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboS1.Text == "Master") { Slider1.currentMode = 0; }
            else if (comboS1.Text == "Current App") { Slider1.currentMode = 1; }
            else if (comboS1.Text == "Choose App...") { Slider1.currentMode = 2; }
        }

        private void comboS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboS2.Text == "Master") { Slider2.currentMode = 0; }
            else if (comboS2.Text == "Current App") { Slider2.currentMode = 1; }
            else if (comboS2.Text == "Choose App...") { Slider2.currentMode = 2; }
        }

        void updateVolumeSerial(string rxString) //when recieve from serial
        {
            int value;
            try
            {
                if (rxString[0] == 'S' && Int32.TryParse(rxString[1].ToString(), out value))
                {
                    if (value == 1) //if 1st knob
                    {
                        Slider1.changeVolume(Convert.ToInt32(rxString.Substring(2)));
                        //set 1st knob
                        int thing = Convert.ToInt32(rxString.Substring(2));
                        int pos = VolumeDraw.changeKnobPos(thing);
                        knob1.Location = new Point(VolumeDraw.knob1posVer, pos);
                    }
                    if (value == 2)
                    {
                        Slider2.changeVolume(Convert.ToInt32(rxString.Substring(2)));
                        //set 2nd knob
                        int pos = VolumeDraw.changeKnobPos(Convert.ToInt32(rxString.Substring(2)));
                        knob2.Location = new Point(VolumeDraw.knob1posVer, pos);

                    }
                }
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
            serialPort1.Close();
            Properties.Settings.Default["slider1Status"] = Slider1.currentMode;
            Properties.Settings.Default["slider2Status"] = Slider2.currentMode;
            Properties.Settings.Default.Save();
        }

        private void appCombo1_DropDown(object sender, EventArgs e)
        {
            appCombo1.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    appCombo1.Items.Add(p.MainWindowTitle);
                }
            }
        }

        private void appCombo2_DropDown(object sender, EventArgs e)
        {
            appCombo2.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    appCombo2.Items.Add(p.MainWindowTitle);
                }
            }
        }

        private void appCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slider1.chosenAPP = appCombo1.Text;
        }

        private void appCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Slider2.chosenAPP = appCombo1.Text;
        }



    }
}
