using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRUTERIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Peso_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Fruta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kg = double.Parse(Peso.Text), total=0.00;
            CuadrodeTexto.Text = "";
            if (Peso.Text !=  "" ) {
                switch (Fruta.Text) {
                    case "Mango":
                        total = 20.50 * kg;
                        if (kg>1){
                            CuadrodeTexto.Text = "Obtubiste 2x1 por comprar mas de 1Kg \nEl total de Mango: "+ (kg*2) + "Kg\nEl total a pagar es: $" + total.ToString(); ;
         
                        } else{
                            CuadrodeTexto.Text = "Total de Mango: " + kg.ToString() + "Kg \nEl total a pagar es: $" + total.ToString();
                        }
                        break;
                    case "Manzana":
                        total = 48.50 * kg;
                        if (kg > 3) {
                            CuadrodeTexto.Text = "Al comprar mas de 3Kg solo debes pagar el 80 %\nTotal de Manana: " + kg.ToString() + "Kg \nEl total a pagar es: $" + (total*0.80).ToString() ;
                        } else {
                            CuadrodeTexto.Text += "Total de Manana: " + kg.ToString() + "Kg \nEl total a pagar es: $" + total.ToString();
                        }
                        break;
                    case "Uvas":
                        total = 79.00 * kg;
                        if (kg > 5) {
                            double TotalConDescuento= total- (total * 0.10);    
                            CuadrodeTexto.Text = "Al comprar mas de 5Kg te regalamos 1kg mas y tienes un descuento del 10%\nTotal de Uvas: "+(kg+1).ToString()+"Kg \nEl total a pagar es: $" + TotalConDescuento.ToString();
                        }else {
                            CuadrodeTexto.Text += "Total de Uvas: " + kg.ToString() + "Kg \nEl total a pagar es: $" + total.ToString();
                        }
                        break;
                    case "Pera":
                        total = 42.00 * kg;
                        if (kg < 3)
                        {
                            double TotalConExtra= total + (total * 0.05);
                            CuadrodeTexto.Text = "Al comprar menos de 3Kg tentra un cobro extra del 5%\nTotal de Pera: " + kg.ToString() + "Kg\nEl total a pagar es: $" + TotalConExtra.ToString();  
                        }else {
                            CuadrodeTexto.Text += "Total de Pera: " + kg.ToString() + "Kg\nEl total a pagar es: $" + total.ToString();
                        }
                        break;  
                    default: 

                        break;

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
