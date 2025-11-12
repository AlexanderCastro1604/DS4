namespace Parcial_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Button btnKelvin;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;

        private void InitializeComponent()
        {
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnKelvin = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(20, 30);
            this.lblFahrenheit.Text = "Fahrenheit";
            
            this.txtFahrenheit.Location = new System.Drawing.Point(100, 25);
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 27);
            
            this.btnFahrenheit.Location = new System.Drawing.Point(220, 25);
            this.btnFahrenheit.Size = new System.Drawing.Size(40, 27);
            this.btnFahrenheit.Text = "→";
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
           
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(20, 80);
            this.lblCelsius.Text = "Celsius";
            
            this.txtCelsius.Location = new System.Drawing.Point(100, 75);
            this.txtCelsius.Size = new System.Drawing.Size(100, 27);
            
            this.btnCelsius.Location = new System.Drawing.Point(220, 75);
            this.btnCelsius.Size = new System.Drawing.Size(40, 27);
            this.btnCelsius.Text = "→";
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(20, 130);
            this.lblKelvin.Text = "Kelvin";
            
            this.txtKelvin.Location = new System.Drawing.Point(100, 125);
            this.txtKelvin.Size = new System.Drawing.Size(100, 27);
            
            
             
            this.btnKelvin.Location = new System.Drawing.Point(220, 125);
            this.btnKelvin.Size = new System.Drawing.Size(40, 27);
            this.btnKelvin.Text = "→";
            this.btnKelvin.Click += new System.EventHandler(this.btnKelvin_Click);
            
            
            
            this.lstHistorial.Location = new System.Drawing.Point(20, 180);
            this.lstHistorial.Size = new System.Drawing.Size(350, 200);
            
             
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.btnKelvin);
            this.Controls.Add(this.lstHistorial);
            this.Text = "Conversor de Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

