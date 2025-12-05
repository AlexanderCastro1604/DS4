using System;
using System.Text;

namespace Laboratorio201
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            litTabla.Text = "";

            if (!int.TryParse(txtNumero.Text.Trim(), out int n))
            {
                litTabla.Text = "<span style='color:red;'>Ingrese un número válido.</span>";
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1' cellpadding='5' style='border-collapse:collapse;'>");
            sb.Append("<tr><th>Operación</th><th>Resultado</th></tr>");

            for (int i = 1; i <= 25; i++)
            {
                sb.Append($"<tr><td>{n} x {i}</td><td>{n * i}</td></tr>");
            }

            sb.Append("</table>");
            litTabla.Text = sb.ToString();
        }
    }
}
