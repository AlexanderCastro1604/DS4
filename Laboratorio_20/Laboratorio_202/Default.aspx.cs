using System;
using System.Text;

namespace Laboratorio202
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            litMatriz.Text = "";

            if (!int.TryParse(txtN.Text.Trim(), out int N) || N <= 0)
            {
                litMatriz.Text = "<span style='color:red;'>Ingrese un número válido mayor que 0.</span>";
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1' cellpadding='5' style='border-collapse:collapse;'>");

            for (int i = 0; i < N; i++)
            {
                sb.Append("<tr>");

                for (int j = 0; j < N; j++)
                {
                    int val = (i + j == N - 1) ? 1 : 0;
                    sb.Append($"<td style='width:30px; text-align:center;'>{val}</td>");
                }

                sb.Append("</tr>");
            }

            sb.Append("</table>");
            litMatriz.Text = sb.ToString();
        }
    }
}
