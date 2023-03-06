using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void T_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Op= cbOperaciones.SelectedItem.ToString();
            switch (Op){
                case "+":
                    tBResultado.Text = (int.Parse(txt1.Text) + int.Parse(txt2.Text)).ToString();
                    break;
                case "-":
                    tBResultado.Text = (int.Parse(txt1.Text) - int.Parse(txt2.Text)).ToString();
                    break;
                case "*":
                    tBResultado.Text = (int.Parse(txt1.Text) * int.Parse(txt2.Text)).ToString();
                    break;
                case "/":
                    tBResultado.Text = (int.Parse(txt1.Text) / int.Parse(txt2.Text)).ToString();
                    break;
                default:
                    break;


            }
        }

        private void Opciones_Click(object sender, EventArgs e)
        {

        }
    }
}
