using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=ALEXCASTRO1604;Database=TempHist;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtFahrenheit.Text, out double f))
                {
                    double c = (f - 32) * 5 / 9;
                    double k = c + 273.15;

                    txtCelsius.Text = c.ToString("N2");
                    txtKelvin.Text = k.ToString("N2");

                    string registro = $"{f}°F -> {c}°C, {k}K";
                    lstHistorial.Items.Add(registro);

                    GuardarConversion(f, c, k, "Fahrenheit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtCelsius.Text, out double c))
                {
                    double f = (c * 9 / 5) + 32;
                    double k = c + 273.15;

                    txtFahrenheit.Text = f.ToString("N2");
                    txtKelvin.Text = k.ToString("N2");

                    string registro = $"{c}°C -> {f}°F, {k}K";
                    lstHistorial.Items.Add(registro);

                    GuardarConversion(c, f, k, "Celsius");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtKelvin.Text, out double k))
                {
                    double c = k - 273.15;
                    double f = (c * 9 / 5) + 32;

                    txtCelsius.Text = c.ToString("N2");
                    txtFahrenheit.Text = f.ToString("N2");

                    string registro = $"{k}K -> {c}°C, {f}°F";
                    lstHistorial.Items.Add(registro);

                    GuardarConversion(k, c, f, "Kelvin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        
        private void GuardarConversion(double entrada, double salida1, double salida2, string tipo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string qry = @"INSERT INTO temp_hist (ValorEntrada, ValorConvertido, TipoConversion, Fecha)
                               VALUES (@entrada, @convertido, @tipo, GETDATE())";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@entrada", entrada);
                cmd.Parameters.AddWithValue("@convertido", $"{salida1}, {salida2}"); 
                cmd.Parameters.AddWithValue("@tipo", tipo);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

