using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Enter the value
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //From 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //To
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //convert
        private void button1_Click(object sender, EventArgs e)
        {
            double idr=0.0,result=0.0;
            double convertInput = Double.Parse(textBox1.Text);

            string fromtext = (String)comboBox1.SelectedItem;

            string totext = (String)comboBox2.SelectedItem;

            //Diubah ke base yaitu rupiah
            if (fromtext.Equals("EUR"))
            {
                idr = 17019.80 * convertInput;
            }
            else if (fromtext.Equals("IDR"))
            {
                idr = convertInput;
            }
            else if (fromtext.Equals("USD"))
            {
                idr = 14447.409 * convertInput;
            }
            else if (fromtext.Equals("AUD"))
            {
                idr = 11041.893 * convertInput;
            }
            else if (fromtext.Equals("JPY"))
            {
                idr = 131.66181 * convertInput;
            }
            else if (fromtext.Equals("SGD"))
            {
                idr = 10720.01 * convertInput;
            }

            //Diubah ke tujuan
            if (totext.Equals("EUR"))
            {
                result = 0.000058778578 * idr;
            }
            else if (totext.Equals("USD"))
            {
                result = 0.000069216981 * idr;
            }
            else if (totext.Equals("IDR"))
            {
                result = idr;
            }
            else if (totext.Equals("AUD"))
            {
                result = 0.000090647702 * idr;
            }
            else if (totext.Equals("JPY"))
            {
                result = 0.0075955627 * idr;
            }
            else if (totext.Equals("SGD"))
            {
                result = 0.000093292337 * idr;
            }

            textBox1.Text = result.ToString();

        }

        //clear
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
