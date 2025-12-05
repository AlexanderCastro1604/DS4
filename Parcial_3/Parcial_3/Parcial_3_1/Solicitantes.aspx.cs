using System;

namespace Parcial_3_1
{
    public partial class Solicitantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            SolicitantesDAO dao = new SolicitantesDAO();
            dao.Guardar(txtCedula.Text, txtNombre.Text, txtApellido.Text);
            lblMensaje.Text = "Solicitante guardado correctamente.";
        }
    }
}
