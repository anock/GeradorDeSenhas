using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeradorDeSenhas
{
    public partial class Form1 : Form
    {
        int num_senhas = 10;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1Gerar_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuvxz";
            if (checkBox1Maius.Checked)
                chars += "ABCDEFGHIJKLMNOPQRSTUVXZ";
            if (checkBox2Alga.Checked)
                chars += "0123456789";
            if (checkBox3Simbol.Checked)
                chars += "#?/=-@$%";

            listBox1Senhas.Items.Clear();
            Random rnd = new Random();

            for (int n = 1;n <= num_senhas; n++)
            {
                StringBuilder str = new StringBuilder();
                for(int m = 1;m<= count_char.Value; m++)
                {
                    int pos = rnd.Next(0, chars.Length);//associa a string 
                    str.Append(chars[pos].ToString());
                }

                listBox1Senhas.Items.Add(str.ToString());

            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
