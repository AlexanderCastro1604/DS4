using System;
using System.Web.UI;

namespace Laboratorio_15_4
{
    public partial class _Default : Page
    {
        protected void ButtonSumar_Click(object sender, EventArgs e)
        {
            int num1, num2;

            // Validar que ambos TextBox tienen números
            if (int.TryParse(TextBoxA.Text, out num1) && int.TryParse(TextBoxB.Text, out num2))
            {
                int suma = num1 + num2;
                LabelResultado.Text = "La suma es: " + suma;
            }
            else
            {
                LabelResultado.Text = "Por favor ingresa solo números.";
            }
        }
    }
}
