using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio_14
{
    public partial class frmGestionProductos : Form
    {
        private string cadenaConexion = @"Server=.\sqlexpress;Database=productos;Trusted_Connection=True;";
        private bool modoNuevo = false;

        public frmGestionProductos()
        {
            InitializeComponent();
        }

        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            CambiarEstadoControles(inicial: true);
        }

        private void CambiarEstadoControles(bool inicial)
        {
            tsbNuevo.Enabled = inicial;
            tsbGuardar.Enabled = !inicial;
            tsbCancelar.Enabled = !inicial;
            tsbEliminar.Enabled = false;

            txtID.Enabled = inicial;
            tsbBuscar.Enabled = inicial;

            txtNombre.Enabled = !inicial;
            txtPrecio.Enabled = !inicial;
            txtStock.Enabled = !inicial;
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            modoNuevo = true;
            CambiarEstadoControles(inicial: false);
            txtNombre.Focus();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            string consultaSQL = "";
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            if (modoNuevo)
            {
                consultaSQL = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@n, @p, @s)";
            }
            else
            {
                consultaSQL = "UPDATE LAPTOPS SET NOMBRE=@n, PRECIO=@p, STOCK=@s WHERE ID=@id";
            }

            SqlCommand comando = new SqlCommand(consultaSQL, conexion);
            comando.CommandType = CommandType.Text;

            comando.Parameters.AddWithValue("@n", txtNombre.Text);
            comando.Parameters.AddWithValue("@p", txtPrecio.Text);
            comando.Parameters.AddWithValue("@s", txtStock.Text);

            if (!modoNuevo)
                comando.Parameters.AddWithValue("@id", txtID.Text);

            try
            {
                conexion.Open();
                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    string mensaje = modoNuevo ? "Registro agregado correctamente." : "Registro actualizado correctamente.";
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operación:\n" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            LimpiarCampos();
            CambiarEstadoControles(inicial: true);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CambiarEstadoControles(inicial: true);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar este registro?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            string sql = "DELETE FROM LAPTOPS WHERE ID=@id";
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);

            try
            {
                con.Open();
                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                    MessageBox.Show("Registro eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            LimpiarCampos();
            CambiarEstadoControles(true);
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tstID.Text))
            {
                MessageBox.Show("Ingresa un ID para buscar.");
                return;
            }

            string sql = "SELECT * FROM LAPTOPS WHERE ID=@id";
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", tstID.Text);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtNombre.Text = dr["NOMBRE"].ToString();
                    txtPrecio.Text = dr["PRECIO"].ToString();
                    txtStock.Text = dr["STOCK"].ToString();

                    modoNuevo = false;
                    tsbEliminar.Enabled = true;
                    CambiarEstadoControles(inicial: false);
                }
                else
                {
                    MessageBox.Show("No se encontró un registro con el ID indicado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar:\n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            tstID.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



