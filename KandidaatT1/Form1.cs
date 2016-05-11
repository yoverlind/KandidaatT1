using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_K8055_LC; //In api8055.cs
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

/*
        *
        *
        *
        *
*/

namespace KandidaatT1
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private int verbind;
        private string receiveText;
        string toets = string.Empty;
        int numpadKey;

        private delegate void dUpdateMijnLabel(int teller);

        private Thread tTeller;

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }


        private void btn_Verbindk8055_Click(object sender, EventArgs e)
        {
            verbind = api8055.OpenDevice(0);

            if (verbind == 0)
            {
                lblCon.Text = "verbonden met k8055" + verbind.ToString();
            }
            else
            {
                lblCon.Text = "geen kaart";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            api8055.CloseDevice();
        }

        #region Toetsenbord
        //inlezen van keyboard numpad
        private void TimeLeesInputs_Tick(object sender, EventArgs e)
        {
            
            
            double n = 0.0;

            TimeLeesInputs.Enabled = false;

            lblGedrukt.Text = "Char_hier";

            for (int i = 0; i < 3; i++)
            {
                n = Math.Pow(2, i);
                api8055.WriteAllDigital(Convert.ToInt16(n));
                Thread.Sleep(25);

                numpadKey = api8055.ReadAllDigital();

                Debug.Print("numpad = " + numpadKey);

                switch (Convert.ToInt16(n))
                {
                    case 8:
                        switch (numpadKey)
                        {
                            case 1:
                                toets += "*";
                                lblGedrukt.Text = toets;
                                txtAntwoord.Text += toets;
                                break;
                            case 2:
                                toets += "0";
                                lblGedrukt.Text = toets;
                                txtAntwoord.Text += toets;
                                break;
                            case 4:
                                toets += "#";
                                lblGedrukt.Text = toets;
                                break;
                        }
                        break;
                    case 4:
                        switch (numpadKey)
                        {
                            case 1:
                                toets += "7";
                                lblGedrukt.Text = toets;
                                break;
                            case 2:
                                toets += "8";
                                lblGedrukt.Text = toets;
                                break;
                            case 4:
                                toets += "9";
                                lblGedrukt.Text = toets;
                                break;
                        }
                        break;
                    case 2:
                        switch (numpadKey)
                        {
                            case 1:
                                toets += "4";
                                break;
                            case 2:
                                toets += "5";
                                break;
                            case 4:
                                toets += "6";
                                break;
                        }
                        break;
                    case 1:
                        switch (numpadKey)
                        {
                            case 1:
                                toets += "1";
                                break;
                            case 2:
                                toets += "2";
                                break;
                            case 4:
                                toets += "3";
                                break;
                            case 8:
                                toets += "A";
                                break;
                        }
                        break;
                }

            }

            TimeLeesInputs.Enabled = false;

        }
        #endregion
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int place1 = 0;
            int place2 = 0;

            receiveText += serialPort1.ReadExisting();

            place1 = receiveText.IndexOf((char)1);
            place2 = receiveText.IndexOf((char)2);

            if (place1 != -1 & place2 != -1)
            {
                receiveText = receiveText.Substring(place1 + 1);
                receiveText = receiveText.Substring(0, receiveText.Length - 1);

                txtVraag.Text += Environment.NewLine + Environment.NewLine + receiveText;
            }

        }

        private void btnVerzend_Click(object sender, EventArgs e)
        {

            string toBeSent = txtAntwoord.Text;

            try
            {
                serialPort1.Write((char)1 + toBeSent + (char)3);   //.Write(Chr(1) + teVersturen + Chr(2));
                txtAntwoord.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtAntwoord.Focus();

            }

        }



    }
}
