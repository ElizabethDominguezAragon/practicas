using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num, resu;
            resu = 1;
            Num = int.Parse(Numero.Text);
            for (int i = 1; i <= Num; i++) {
                resu = resu * i;  
            }
            textResultado.Text = resu.ToString();  
        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
