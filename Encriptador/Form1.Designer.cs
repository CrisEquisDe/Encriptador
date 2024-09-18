namespace Encriptador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFolioOrigen = new System.Windows.Forms.Label();
            this.lblClaveRegistro = new System.Windows.Forms.Label();
            this.lblInstitucionContraparte = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblReferenciaNumerica = new System.Windows.Forms.Label();
            this.lblTipoCuentaBeneficiario = new System.Windows.Forms.Label();
            this.lblCausaDevolucion = new System.Windows.Forms.Label();
            this.lblCuentaOrdenante = new System.Windows.Forms.Label();
            this.lblTipoCuentaOrdenante = new System.Windows.Forms.Label();
            this.lblCuentaBenef = new System.Windows.Forms.Label();
            this.lblFechaOperacion = new System.Windows.Forms.Label();
            this.txtFolioOrigen = new System.Windows.Forms.TextBox();
            this.txtClaveRastreo = new System.Windows.Forms.TextBox();
            this.txtInstitucionContraparte = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtReferenciaNumerica = new System.Windows.Forms.TextBox();
            this.txtTipoCuentaBeneficiario = new System.Windows.Forms.TextBox();
            this.txtCausaDevolucion = new System.Windows.Forms.TextBox();
            this.txtCuentaOrdenante = new System.Windows.Forms.TextBox();
            this.txtTipoCuentaOrdenante = new System.Windows.Forms.TextBox();
            this.txtCuentaBeneficiario = new System.Windows.Forms.TextBox();
            this.txtFechaOperacion = new System.Windows.Forms.TextBox();
            this.txtCadenaGenerada = new System.Windows.Forms.TextBox();
            this.lblCadenaGenerada = new System.Windows.Forms.Label();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.lblCadenaEncriptada = new System.Windows.Forms.Label();
            this.txtCadenaEncriptada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFolioOrigen
            // 
            this.lblFolioOrigen.AutoSize = true;
            this.lblFolioOrigen.Location = new System.Drawing.Point(18, 23);
            this.lblFolioOrigen.Name = "lblFolioOrigen";
            this.lblFolioOrigen.Size = new System.Drawing.Size(63, 13);
            this.lblFolioOrigen.TabIndex = 0;
            this.lblFolioOrigen.Text = "Folio Origen";
            // 
            // lblClaveRegistro
            // 
            this.lblClaveRegistro.AutoSize = true;
            this.lblClaveRegistro.Location = new System.Drawing.Point(18, 48);
            this.lblClaveRegistro.Name = "lblClaveRegistro";
            this.lblClaveRegistro.Size = new System.Drawing.Size(74, 13);
            this.lblClaveRegistro.TabIndex = 1;
            this.lblClaveRegistro.Text = "Clave Rastreo";
            // 
            // lblInstitucionContraparte
            // 
            this.lblInstitucionContraparte.AutoSize = true;
            this.lblInstitucionContraparte.Location = new System.Drawing.Point(18, 73);
            this.lblInstitucionContraparte.Name = "lblInstitucionContraparte";
            this.lblInstitucionContraparte.Size = new System.Drawing.Size(113, 13);
            this.lblInstitucionContraparte.TabIndex = 2;
            this.lblInstitucionContraparte.Text = "Institución Contraparte";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(18, 97);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto";
            // 
            // lblReferenciaNumerica
            // 
            this.lblReferenciaNumerica.AutoSize = true;
            this.lblReferenciaNumerica.Location = new System.Drawing.Point(18, 121);
            this.lblReferenciaNumerica.Name = "lblReferenciaNumerica";
            this.lblReferenciaNumerica.Size = new System.Drawing.Size(107, 13);
            this.lblReferenciaNumerica.TabIndex = 4;
            this.lblReferenciaNumerica.Text = "Referencia Numérica";
            // 
            // lblTipoCuentaBeneficiario
            // 
            this.lblTipoCuentaBeneficiario.AutoSize = true;
            this.lblTipoCuentaBeneficiario.Location = new System.Drawing.Point(18, 144);
            this.lblTipoCuentaBeneficiario.Name = "lblTipoCuentaBeneficiario";
            this.lblTipoCuentaBeneficiario.Size = new System.Drawing.Size(123, 13);
            this.lblTipoCuentaBeneficiario.TabIndex = 5;
            this.lblTipoCuentaBeneficiario.Text = "Tipo Cuenta Beneficiario";
            // 
            // lblCausaDevolucion
            // 
            this.lblCausaDevolucion.AutoSize = true;
            this.lblCausaDevolucion.Location = new System.Drawing.Point(18, 170);
            this.lblCausaDevolucion.Name = "lblCausaDevolucion";
            this.lblCausaDevolucion.Size = new System.Drawing.Size(94, 13);
            this.lblCausaDevolucion.TabIndex = 6;
            this.lblCausaDevolucion.Text = "Causa Devolución";
            // 
            // lblCuentaOrdenante
            // 
            this.lblCuentaOrdenante.AutoSize = true;
            this.lblCuentaOrdenante.Location = new System.Drawing.Point(18, 194);
            this.lblCuentaOrdenante.Name = "lblCuentaOrdenante";
            this.lblCuentaOrdenante.Size = new System.Drawing.Size(94, 13);
            this.lblCuentaOrdenante.TabIndex = 7;
            this.lblCuentaOrdenante.Text = "Cuenta Ordenante";
            // 
            // lblTipoCuentaOrdenante
            // 
            this.lblTipoCuentaOrdenante.AutoSize = true;
            this.lblTipoCuentaOrdenante.Location = new System.Drawing.Point(18, 216);
            this.lblTipoCuentaOrdenante.Name = "lblTipoCuentaOrdenante";
            this.lblTipoCuentaOrdenante.Size = new System.Drawing.Size(118, 13);
            this.lblTipoCuentaOrdenante.TabIndex = 8;
            this.lblTipoCuentaOrdenante.Text = "Tipo Cuenta Ordenante";
            // 
            // lblCuentaBenef
            // 
            this.lblCuentaBenef.AutoSize = true;
            this.lblCuentaBenef.Location = new System.Drawing.Point(18, 242);
            this.lblCuentaBenef.Name = "lblCuentaBenef";
            this.lblCuentaBenef.Size = new System.Drawing.Size(99, 13);
            this.lblCuentaBenef.TabIndex = 9;
            this.lblCuentaBenef.Text = "Cuenta Beneficiario";
            // 
            // lblFechaOperacion
            // 
            this.lblFechaOperacion.AutoSize = true;
            this.lblFechaOperacion.Location = new System.Drawing.Point(18, 266);
            this.lblFechaOperacion.Name = "lblFechaOperacion";
            this.lblFechaOperacion.Size = new System.Drawing.Size(89, 13);
            this.lblFechaOperacion.TabIndex = 10;
            this.lblFechaOperacion.Text = "Fecha Operación";
            // 
            // txtFolioOrigen
            // 
            this.txtFolioOrigen.Location = new System.Drawing.Point(145, 20);
            this.txtFolioOrigen.Name = "txtFolioOrigen";
            this.txtFolioOrigen.Size = new System.Drawing.Size(207, 20);
            this.txtFolioOrigen.TabIndex = 11;
            this.txtFolioOrigen.Leave += new System.EventHandler(this.txtFolioOrigen_Leave);
            // 
            // txtClaveRastreo
            // 
            this.txtClaveRastreo.Location = new System.Drawing.Point(145, 45);
            this.txtClaveRastreo.Name = "txtClaveRastreo";
            this.txtClaveRastreo.Size = new System.Drawing.Size(207, 20);
            this.txtClaveRastreo.TabIndex = 12;
            this.txtClaveRastreo.Leave += new System.EventHandler(this.txtClaveRastreo_Leave);
            // 
            // txtInstitucionContraparte
            // 
            this.txtInstitucionContraparte.Location = new System.Drawing.Point(145, 70);
            this.txtInstitucionContraparte.Name = "txtInstitucionContraparte";
            this.txtInstitucionContraparte.Size = new System.Drawing.Size(207, 20);
            this.txtInstitucionContraparte.TabIndex = 13;
            this.txtInstitucionContraparte.Leave += new System.EventHandler(this.txtInstitucionContraparte_Leave);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(145, 94);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(207, 20);
            this.txtMonto.TabIndex = 14;
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // txtReferenciaNumerica
            // 
            this.txtReferenciaNumerica.Location = new System.Drawing.Point(145, 118);
            this.txtReferenciaNumerica.Name = "txtReferenciaNumerica";
            this.txtReferenciaNumerica.Size = new System.Drawing.Size(207, 20);
            this.txtReferenciaNumerica.TabIndex = 15;
            this.txtReferenciaNumerica.Leave += new System.EventHandler(this.txtReferenciaNumerica_Leave);
            // 
            // txtTipoCuentaBeneficiario
            // 
            this.txtTipoCuentaBeneficiario.Location = new System.Drawing.Point(145, 141);
            this.txtTipoCuentaBeneficiario.Name = "txtTipoCuentaBeneficiario";
            this.txtTipoCuentaBeneficiario.Size = new System.Drawing.Size(207, 20);
            this.txtTipoCuentaBeneficiario.TabIndex = 16;
            this.txtTipoCuentaBeneficiario.Leave += new System.EventHandler(this.txtTipoCuentaBeneficiario_Leave);
            // 
            // txtCausaDevolucion
            // 
            this.txtCausaDevolucion.Location = new System.Drawing.Point(145, 167);
            this.txtCausaDevolucion.Name = "txtCausaDevolucion";
            this.txtCausaDevolucion.Size = new System.Drawing.Size(207, 20);
            this.txtCausaDevolucion.TabIndex = 17;
            this.txtCausaDevolucion.Leave += new System.EventHandler(this.txtCausaDevolucion_Leave);
            // 
            // txtCuentaOrdenante
            // 
            this.txtCuentaOrdenante.Location = new System.Drawing.Point(145, 191);
            this.txtCuentaOrdenante.Name = "txtCuentaOrdenante";
            this.txtCuentaOrdenante.Size = new System.Drawing.Size(207, 20);
            this.txtCuentaOrdenante.TabIndex = 18;
            this.txtCuentaOrdenante.Leave += new System.EventHandler(this.txtCuentaOrdenante_Leave);
            // 
            // txtTipoCuentaOrdenante
            // 
            this.txtTipoCuentaOrdenante.Location = new System.Drawing.Point(145, 213);
            this.txtTipoCuentaOrdenante.Name = "txtTipoCuentaOrdenante";
            this.txtTipoCuentaOrdenante.Size = new System.Drawing.Size(207, 20);
            this.txtTipoCuentaOrdenante.TabIndex = 19;
            this.txtTipoCuentaOrdenante.Leave += new System.EventHandler(this.txtTipoCuentaOrdenante_Leave);
            // 
            // txtCuentaBeneficiario
            // 
            this.txtCuentaBeneficiario.Location = new System.Drawing.Point(145, 239);
            this.txtCuentaBeneficiario.Name = "txtCuentaBeneficiario";
            this.txtCuentaBeneficiario.Size = new System.Drawing.Size(207, 20);
            this.txtCuentaBeneficiario.TabIndex = 20;
            this.txtCuentaBeneficiario.Leave += new System.EventHandler(this.txtCuentaBeneficiario_Leave);
            // 
            // txtFechaOperacion
            // 
            this.txtFechaOperacion.Location = new System.Drawing.Point(145, 263);
            this.txtFechaOperacion.Name = "txtFechaOperacion";
            this.txtFechaOperacion.Size = new System.Drawing.Size(207, 20);
            this.txtFechaOperacion.TabIndex = 21;
            this.txtFechaOperacion.Leave += new System.EventHandler(this.txtFechaOperacion_Leave);
            // 
            // txtCadenaGenerada
            // 
            this.txtCadenaGenerada.Location = new System.Drawing.Point(426, 70);
            this.txtCadenaGenerada.Name = "txtCadenaGenerada";
            this.txtCadenaGenerada.Size = new System.Drawing.Size(327, 20);
            this.txtCadenaGenerada.TabIndex = 22;
            // 
            // lblCadenaGenerada
            // 
            this.lblCadenaGenerada.AutoSize = true;
            this.lblCadenaGenerada.Location = new System.Drawing.Point(538, 48);
            this.lblCadenaGenerada.Name = "lblCadenaGenerada";
            this.lblCadenaGenerada.Size = new System.Drawing.Size(94, 13);
            this.lblCadenaGenerada.TabIndex = 23;
            this.lblCadenaGenerada.Text = "Cadena Genedara";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(491, 97);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(198, 64);
            this.btnEncriptar.TabIndex = 24;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // lblCadenaEncriptada
            // 
            this.lblCadenaEncriptada.AutoSize = true;
            this.lblCadenaEncriptada.Location = new System.Drawing.Point(534, 194);
            this.lblCadenaEncriptada.Name = "lblCadenaEncriptada";
            this.lblCadenaEncriptada.Size = new System.Drawing.Size(98, 13);
            this.lblCadenaEncriptada.TabIndex = 25;
            this.lblCadenaEncriptada.Text = "Cadena Encriptada";
            // 
            // txtCadenaEncriptada
            // 
            this.txtCadenaEncriptada.Location = new System.Drawing.Point(426, 213);
            this.txtCadenaEncriptada.Multiline = true;
            this.txtCadenaEncriptada.Name = "txtCadenaEncriptada";
            this.txtCadenaEncriptada.Size = new System.Drawing.Size(327, 70);
            this.txtCadenaEncriptada.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCadenaEncriptada);
            this.Controls.Add(this.lblCadenaEncriptada);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.lblCadenaGenerada);
            this.Controls.Add(this.txtCadenaGenerada);
            this.Controls.Add(this.txtFechaOperacion);
            this.Controls.Add(this.txtCuentaBeneficiario);
            this.Controls.Add(this.txtTipoCuentaOrdenante);
            this.Controls.Add(this.txtCuentaOrdenante);
            this.Controls.Add(this.txtCausaDevolucion);
            this.Controls.Add(this.txtTipoCuentaBeneficiario);
            this.Controls.Add(this.txtReferenciaNumerica);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtInstitucionContraparte);
            this.Controls.Add(this.txtClaveRastreo);
            this.Controls.Add(this.txtFolioOrigen);
            this.Controls.Add(this.lblFechaOperacion);
            this.Controls.Add(this.lblCuentaBenef);
            this.Controls.Add(this.lblTipoCuentaOrdenante);
            this.Controls.Add(this.lblCuentaOrdenante);
            this.Controls.Add(this.lblCausaDevolucion);
            this.Controls.Add(this.lblTipoCuentaBeneficiario);
            this.Controls.Add(this.lblReferenciaNumerica);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblInstitucionContraparte);
            this.Controls.Add(this.lblClaveRegistro);
            this.Controls.Add(this.lblFolioOrigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolioOrigen;
        private System.Windows.Forms.Label lblClaveRegistro;
        private System.Windows.Forms.Label lblInstitucionContraparte;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblReferenciaNumerica;
        private System.Windows.Forms.Label lblTipoCuentaBeneficiario;
        private System.Windows.Forms.Label lblCausaDevolucion;
        private System.Windows.Forms.Label lblCuentaOrdenante;
        private System.Windows.Forms.Label lblTipoCuentaOrdenante;
        private System.Windows.Forms.Label lblCuentaBenef;
        private System.Windows.Forms.Label lblFechaOperacion;
        private System.Windows.Forms.TextBox txtFolioOrigen;
        private System.Windows.Forms.TextBox txtClaveRastreo;
        private System.Windows.Forms.TextBox txtInstitucionContraparte;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtReferenciaNumerica;
        private System.Windows.Forms.TextBox txtTipoCuentaBeneficiario;
        private System.Windows.Forms.TextBox txtCausaDevolucion;
        private System.Windows.Forms.TextBox txtCuentaOrdenante;
        private System.Windows.Forms.TextBox txtTipoCuentaOrdenante;
        private System.Windows.Forms.TextBox txtCuentaBeneficiario;
        private System.Windows.Forms.TextBox txtFechaOperacion;
        private System.Windows.Forms.TextBox txtCadenaGenerada;
        private System.Windows.Forms.Label lblCadenaGenerada;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Label lblCadenaEncriptada;
        private System.Windows.Forms.TextBox txtCadenaEncriptada;
    }
}

