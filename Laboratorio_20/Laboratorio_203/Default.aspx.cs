using System;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio203
{
    public partial class Default : System.Web.UI.Page
    {
        string connectionString = @"Server=.\sqlexpress;Database=productos;Trusted_Connection=True;";
        bool nuevo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                EstadoInicial();
        }

        void EstadoInicial()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;

            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtBuscarID.Text = "";
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();

            nuevo = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            try
            {
                SqlCommand cmd;

                if (nuevo)
                {
                    cmd = new SqlCommand(
                        "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@N, @P, @S)", con);

                    cmd.Parameters.AddWithValue("@N", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@P", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@S", txtStock.Text);
                }
                else
                {
                    cmd = new SqlCommand(
                        "UPDATE LAPTOPS SET NOMBRE=@N, PRECIO=@P, STOCK=@S WHERE ID=@ID", con);

                    cmd.Parameters.AddWithValue("@N", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@P", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@S", txtStock.Text);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                }

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Response.Write("<script>alert('Operación realizada correctamente');</script>");
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('ERROR: {ex.Message}');</script>");
            }
            finally
            {
                con.Close();
            }

            EstadoInicial();
            Limpiar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            Limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("DELETE FROM LAPTOPS WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);

            con.Open();
            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Response.Write("<script>alert('Registro eliminado correctamente');</script>");
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('ERROR: {ex.Message}');</script>");
            }
            finally
            {
                con.Close();
            }

            EstadoInicial();
            Limpiar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM LAPTOPS WHERE ID=@ID", con);

            cmd.Parameters.AddWithValue("@ID", txtBuscarID.Text);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtID.Text = reader["ID"].ToString();
                txtNombre.Text = reader["NOMBRE"].ToString();
                txtPrecio.Text = reader["PRECIO"].ToString();
                txtStock.Text = reader["STOCK"].ToString();

                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEliminar.Enabled = true;

                txtNombre.Enabled = true;
                txtPrecio.Enabled = true;
                txtStock.Enabled = true;

                nuevo = false;
            }
            else
            {
                Response.Write("<script>alert('No encontrado');</script>");
            }

            con.Close();
        }
    }
}
