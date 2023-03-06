using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resu;
           
            if (Lado.Text != ""){
                resu = double.Parse(Lado.Text)* double.Parse(Lado.Text);
                if (resu <= 10)
                {
                    R_Cuadrado.Text = "area: " + resu.ToString() + "\nFigura pequeña";
                }else if(resu >= 11 || resu < 25)
                {
                    R_Cuadrado.Text = "area: " + resu.ToString() + "\nFigura Mediana";
                }
                else
                {
                    R_Cuadrado.Text = "area: " + resu.ToString() + "\nFigura Grande";
                }
            }else
            {
                R_Cuadrado.Text = "es necesario el valor del lado";
            }
            if(Base.Text !=""||Altura.Text != "")
            {
                resu = (double.Parse(Base.Text)* double.Parse(Altura.Text))/2;
                if (resu <= 10)
                {
                    R_Triangulo.Text = "area: " + resu.ToString() + "\nFigura pequeña";
                }
                else if (resu >= 11 || resu < 25)
                {
                    R_Triangulo.Text = "area: " + resu.ToString() + "\nFigura Mediana";
                }
                else
                {
                    R_Triangulo.Text = "area: " + resu.ToString() + "\nFigura Grande";
                }
            }else
            {
                R_Triangulo.Text = "es necesario el valor de la base y altura";
            }
            if (Radio.Text != "")
            {
                resu = (double.Parse(Radio.Text) * double.Parse(Radio.Text))*3.1416;
                if (resu <= 10)
                {
                    R_Circulo.Text = "area: " + resu.ToString() + "\nFigura Pequeña";
                }
                else if (resu >= 11 || resu < 25)
                {
                    R_Circulo.Text = "area: " + resu.ToString() + "\nFigura Mediana";
                }
                else
                {
                    R_Circulo.Text = "area: " + resu.ToString() + "\nFigura Grande";;
                }
            }
            else
            {
                R_Cuadrado.Text = "es necesario el valor del Radio";
            }
        }
        private void Base_TextChanged(object sender, EventArgs e)
        {

        }
    }
           
}

