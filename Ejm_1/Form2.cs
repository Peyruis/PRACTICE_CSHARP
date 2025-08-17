using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejm_1
{
    public partial class Form2 : Form

    {

        double monitor, disco, laptop, impresora, camara, suma, subtotal,igv, total;

 
        private void Form2_Load(object sender, EventArgs e)
        {
            chkCamara.CheckedChanged += pbCamara_Click;
            chkDiscoDuro.CheckedChanged += pbDisco_Click;
            chkLaptop.CheckedChanged += pbLaptop_Click;
            chkMonitor.CheckedChanged += pbMonitor_Click;
            chkImpresora.CheckedChanged += pbImpresora_Click;


        }



        //    METHODOS PARA LAS IMAGENES

        private void pbCamara_Click(object sender, EventArgs e)
        {
            pbCamara.Visible = chkCamara.Checked;
        }

        private void pbImpresora_Click(object sender, EventArgs e)
        {
            pbImpresora.Visible = chkImpresora.Checked;
        }

        private void pbLaptop_Click(object sender, EventArgs e)
        {
            pbLaptop.Visible = chkLaptop.Checked;
        }
        private void pbMonitor_Click(object sender, EventArgs e)
        {
            pbMonitor.Visible =chkMonitor.Checked;
        }

        private void pbDisco_Click(object sender, EventArgs e)
        {
            pbDisco.Visible = chkDiscoDuro.Checked;
        }

        // Method exit

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        // METHOD CLEAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = string.Empty;
            txtIgv.Text = string.Empty;
            txtTotal.Clear();

            // chk - 

            chkMonitor.Checked = false; 
            chkDiscoDuro.Checked = false;  
            chkLaptop.Checked = false;  
            chkImpresora.Checked = false;
            chkCamara.Checked = false;
        }



        public const double IGV = 0.18;

        // Constructor
        public Form2()
        {
            InitializeComponent();
            monitor = 680;
            disco = 195;
            laptop = 3800;
            impresora = 699.90;
            camara = 125.50;

            // Visibilidad
            pbMonitor.Visible = false;  
            pbDisco.Visible = false;    
            pbImpresora.Visible = false;    
            pbCamara.Visible = false;   
            pbLaptop.Visible = false;   
        }

  

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            suma = 0;

            if (chkMonitor.Checked)
            {
                suma += monitor;
               // pbMonitor.Visible = true;
            }
            if (chkDiscoDuro.Checked) 
            {
                suma += disco;
               // pbDisco.Visible = true; 
            }
            if (chkLaptop.Checked)
            {
                suma += laptop;
                // pbLaptop .Visible = true;
            }

            if (chkImpresora.Checked)
            {
                suma += impresora;
              //  pbImpresora .Visible = true;
            }

            if (chkCamara.Checked)
            {
                suma += camara;
                //pbCamara.Visible = true; 
            }

            subtotal = suma;
            txtSubtotal.Text = subtotal.ToString();

            igv = subtotal * IGV;
            txtIgv.Text = igv.ToString();   

            total = Math.Round((subtotal+igv),2);

            txtTotal.Text = total.ToString();   
            
        }
    }
}
