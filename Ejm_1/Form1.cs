using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejm_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            double n1, n2;
            string resultado = "";

            n1 = Double.Parse(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);  



            if (n1 > n2)
            {
                resultado = "Numero : " + n1 + " es mayor que " + n2;
            } else if (n1 < n2)
            {
                resultado = "Numero :" + n2 + " es mayor que " + n1;
            }else if(n1 == n2)
            {
                resultado = "Numero : " + n1 + " es igual a " + n2;
            }
            txtResultado.Text = resultado;
            MessageBox.Show(resultado, "Evaluar 2 numeros",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
