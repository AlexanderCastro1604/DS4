using System;
using System.Windows.Forms;

namespace AppTriangulo
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
           
            double ladoA, ladoB, ladoC;

            try
            {
                ladoA = Convert.ToDouble(txtA.Text);
                ladoB = Convert.ToDouble(txtB.Text);
                ladoC = Convert.ToDouble(txtC.Text);

                double semiP = (ladoA + ladoB + ladoC) / 2;
                txtResultadoSP.Text = semiP.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos correctos en los lados.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(txtA.Text, out double a) &&
                double.TryParse(txtB.Text, out double b) &&
                double.TryParse(txtC.Text, out double c))
            {
                double sp = (a + b + c) / 2;
                double resultado = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
                txtResultadoArea.Text = $"{resultado:F3}";
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
        
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;
            }
            txtA.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

       
        private void txtA_TextChanged(object sender, EventArgs e) { }
        private void txtB_TextChanged(object sender, EventArgs e) { }
        private void txtC_TextChanged(object sender, EventArgs e) { }
        private void txtResultadoSP_TextChanged(object sender, EventArgs e) { }
        private void txtResultadoArea_TextChanged(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
    }
}
