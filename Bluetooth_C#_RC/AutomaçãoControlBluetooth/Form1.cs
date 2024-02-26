﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaçãoControlBluetooth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int l1 = 0, l2 = 0, l3 = 0, l4 = 0;
        
        int F = 0, B = 0, L = 0, R = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string x = comboBox1.SelectedItem.ToString();
            serialPort1.PortName = x;
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Porta serial Selecionada");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (l1 == 0)
                {
                    byte[] chr = new byte[] { 1 };
                    serialPort1.Write(chr, 0, 1); //(Escreva 1 caractere na porta serial)
                    l1++;
                }
                else
                {
                    byte[] chr = new byte[] { 2 };
                    serialPort1.Write(chr, 0, 1);
                    l1--;
                }
            }
            else
            {
                MessageBox.Show("Dispositivo não conectado");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (l2 == 0)
                {
                    byte[] chr = new byte[] { 3 };
                    serialPort1.Write(chr, 0, 1);
                    l2++;
                }
                else
                {
                    byte[] chr = new byte[] { 4 };
                    serialPort1.Write(chr, 0, 1);
                    l2--;
                }
            }
            else
            {
                MessageBox.Show("Dispositivo não conectado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (l3 == 0)
                {
                    byte[] chr = new byte[] { 5 };
                    serialPort1.Write(chr, 0, 1);
                    l3++;
                }
                else
                {
                    byte[] chr = new byte[] { 6 };
                    serialPort1.Write(chr, 0, 1);
                    l3--;
                }

            }
            else
            {
                MessageBox.Show("Dispositivo não conectado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (l4 == 0)
                {
                    byte[] chr = new byte[] { 7 };
                    serialPort1.Write(chr, 0, 1);
                    l4++;
                }
                else
                {
                    byte[] chr = new byte[] { 8 };
                    serialPort1.Write(chr, 0, 1);
                    l4--;
                }
            }
            else
            {
                MessageBox.Show("Dispositivo não conectado");
            }
        }

        //motor sentido horario
        private void button8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (F == 0)
                {
                    byte[] chr = new byte[] { 9 };
                    serialPort1.Write("F");
                    serialPort1.Write(chr, 0, 1);
                    F++;
                }
                else
                {
                    byte[] chr = new byte[] { 10 };
                    serialPort1.Write("S");
                    serialPort1.Write(chr, 0, 1);
                    F--;
                }
            }
        }

        //motor sentido anti-horario
        private void button9_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (B == 0)
                {
                    byte[] chr = new byte[] { 11 };
                    serialPort1.Write("B");
                    serialPort1.Write(chr, 0, 1);
                    B++;
                }
                else
                {
                    byte[] chr = new byte[] { 12 };
                    serialPort1.Write("S");
                    serialPort1.Write(chr, 0, 1);
                    B--;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (L == 0)
                {
                    byte[] chr = new byte[] { 13 };
                    serialPort1.Write("L");
                    serialPort1.Write(chr, 0, 1);
                    L++;
                }
                else
                {
                    byte[] chr = new byte[] { 14 };
                    serialPort1.Write("S");
                    serialPort1.Write(chr, 0, 1);
                    L--;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                if (R == 0)
                {
                    byte[] chr = new byte[] { 15 };
                    serialPort1.Write("R");
                    serialPort1.Write(chr, 0, 1);
                    R++;
                }
                else
                {
                    byte[] chr = new byte[] { 16 };
                    serialPort1.Write("S");
                    serialPort1.Write(chr, 0, 1);
                    R--;
                }
            }
        }
    }
}