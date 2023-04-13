using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Price currentPrice = Price.Size9_12;
        public Form1()
        {
            InitializeComponent();
        }
        private void RadioButton1(object sender, EventArgs e)
        {

        }
        private void RadioButton2(object sender, EventArgs e)
        {

        }
        private void RadioButton3(object sender, EventArgs e)
        {

        }
        private void TextBox1(object sender, EventArgs e)
        {

        }
        void ResizePanel()
        {
            if (currentPrice == Price.Size9_12)
            {
                panel1.Width = 90;
                panel1.Height = 120;
            }
            else if (currentPrice == Price.Size12_15)
            {
                panel1.Width = 120;
                panel1.Height = 150;
            }
            else if (currentPrice == Price.Size18_24)
            {
                panel1.Width = 180;
                panel1.Height = 240;
            }
            panel1.Enabled = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentPrice = Price.Size9_12;
            ResizePanel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            currentPrice = Price.Size12_15;
            ResizePanel();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            currentPrice = Price.Size18_24;
            ResizePanel();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = PriceService.GetPrice(currentPrice, Convert.ToInt32(numericUpDown1.Value)) + " грн.";
        }
    } 
}
