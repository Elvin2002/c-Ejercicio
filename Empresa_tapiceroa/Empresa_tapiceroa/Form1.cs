using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_tapiceroa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Calcular()
        {
            clsTapiceria Datos = new clsTapiceria();
            Datos.Precio = Convert.ToDouble(txtPrecio.Text);
            txtDescuento.Text = String.Format("{0:f}",Datos.Descuentos());
            txtPrecioVenta.Text = String.Format("{0:f}", Datos.precio_final()); 

        }

        private void btnHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh: mm - ss -tt");
            lblfecha.Text = DateTime.Now.ToString("dddd / M / yyyyy");

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtNro_TextChanged(object sender, EventArgs e)
        {
            
            int Num = 0;
            Num = Num + 1;
            txtNro.Text = Num.ToString("0000");
           

           
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtDescuento.Clear();
            txtMueble.Clear();
            txtPrecio.Clear();
            txtPrecioVenta.Clear();
            txtNro.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
