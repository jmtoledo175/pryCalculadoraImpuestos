using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalculadoraImpuestos
{
    public partial class fmrImpuestos : Form
    {
        public fmrImpuestos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmrImpuestos_Load(object sender, EventArgs e)
        {
            

        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            
            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            if (cboPais.SelectedItem != null)
            {
               
                string pais = cboPais.SelectedItem.ToString();

                switch (pais)
                {
                    case "Estados Unidos":
                        precio = precio +(precio * 0.07m) ;
                        break;
                    case "Canadá":
                        precio = precio + (precio * 0.05m);
                        break;
                    case "México":
                        precio = precio + (precio * 0.16m);
                        break;
                    case "Otros":
                        precio = precio + (precio * 0.10m);
                        break;
                }
                lblResultado.Text = $"El precio con IVA es: {precio:C}";

            }
            else
            {
                MessageBox.Show("Seleccione un Pais");
            }

        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if(txtPrecio.Text == "")
            {
                cmdCalcular.Enabled = false;
            }
            else
            {
                cmdCalcular.Enabled = true;
            }
        }
    } 
}
