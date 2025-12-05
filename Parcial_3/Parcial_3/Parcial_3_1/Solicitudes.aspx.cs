using System;

namespace Parcial_3_1
{
    public partial class Solicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdSolicitante.Text);
            string obs = txtObservaciones.Text;

            SolicitudesDAO dao = new SolicitudesDAO();
            dao.Registrar(id, obs);

            lblMensaje.Text = "Solicitud registrada exitosamente.";
        }
    }
}
