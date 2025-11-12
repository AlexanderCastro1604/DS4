using System;
using System.Windows.Forms;

namespace ProyectoFisica
{
    public partial class FrmCalculoDistancia : Form
    {
        public FrmCalculoDistancia()
        {
            InitializeComponent();
        }

        private void FrmCalculoDistancia_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Cálculo de Distancia (Física Básica)";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
           
            if (double.TryParse(txtVelocidad.Text, out double v) &&
                double.TryParse(txtTiempo.Text, out double t))
            {
                double d = v * t;
                txtResultado.Text = d.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = "";
            }
            txtVelocidad.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void txtVelocidad_TextChanged(object sender, EventArgs e) { }
        private void txtTiempo_TextChanged(object sender, EventArgs e) { }
        private void txtResultado_TextChanged(object sender, EventArgs e) { }
    }
}
