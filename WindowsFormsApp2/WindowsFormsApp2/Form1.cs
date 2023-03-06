using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e) {
            double total = 0, descuento = 0, extra = 0;
            Cuadro_texto.Text = "";
            if (Txt_Edad.Text != null || txt_M != null) {
                extra = 320.00 * 0.08;
                if (int.Parse(Txt_Edad.Text) >= 60) {
                    descuento = (320.00 + extra) * 0.20;
                    total = (320.00 + extra) - descuento;
                    if (double.Parse(txt_M.Text) > 200) {
                        Cuadro_texto.Text = "Los metros cuadrados son mayor a 200, se le cobrara un servicio extra de: $" + extra.ToString() + "\nPor ser una persona mayor a 60 años se le aplicara un descuento de: $" + descuento.ToString() + "\nEl total es de: $" + total.ToString();
                    } else {
                        descuento = 320.00 * 0.20;
                        Cuadro_texto.Text = "\nPor ser una persona mayor a 60 años se le aplicara un descuento de: $" + descuento.ToString() + "\nEl total es de: $" + total.ToString();
                    }
                }else if (double.Parse(txt_M.Text) > 200 && int.Parse(Txt_Edad.Text) < 60)
                {
                    total = (320.00 + extra);
                    Cuadro_texto.Text = "Los metros cuadrados son mayor a 200, se le cobrara un servicio extra de: $" + extra.ToString() + "\nEl total es de: $" + total.ToString();
                }else if (int.Parse(Txt_Edad.Text) < 60 && double.Parse(txt_M.Text) <=200 ) {
                    Cuadro_texto.Text = "El total es de: $320.00";
                }
            }else{
                Cuadro_texto.Text = "el programa no funciona con elementos vacios";
            }
        }
    }
}
