using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String cadena = String.Empty;
        private void btnEncriptar_Click(object sender, EventArgs e)
        {

        }

        private void txtFolioOrigen_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtFolioOrigen.Text.ToLower();   
        }
        private void txtClaveRastreo_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtClaveRastreo.Text.Trim().ToLower(); 
        }
        private void txtInstitucionContraparte_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtInstitucionContraparte.Text.Trim();
        }
        private void txtMonto_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtMonto.Text.Trim();
        }
        private void txtReferenciaNumerica_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtReferenciaNumerica.Text.Trim();
        }
        private void txtTipoCuentaBeneficiario_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtTipoCuentaBeneficiario.Text.Trim();
        }
        private void txtCausaDevolucion_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtCausaDevolucion.Text.Trim().ToLower();
        }
        private void txtCuentaOrdenante_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtCuentaOrdenante.Text.Trim();
        }
        private void txtTipoCuentaOrdenante_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtTipoCuentaOrdenante.Text.Trim();
        }
        private void txtCuentaBeneficiario_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtCuentaBeneficiario.Text.Trim();
        }
        private void txtFechaOperacion_Leave(object sender, EventArgs e)
        {
            txtCadenaGenerada.Text = txtCadenaGenerada.Text.Trim() + txtFechaOperacion.Text.Trim();
        }
    }
}
