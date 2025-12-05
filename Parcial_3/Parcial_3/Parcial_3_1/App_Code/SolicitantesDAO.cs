using System.Data.SqlClient;

public class SolicitantesDAO
{
    Conexion conexion = new Conexion();

    public void Guardar(string cedula, string nombre, string apellido)
    {
        SqlCommand cmd = new SqlCommand(
            "INSERT INTO Solicitantes (Cedula, Nombre, Apellido) VALUES (@c, @n, @a)",
            conexion.cn);

        cmd.Parameters.AddWithValue("@c", cedula);
        cmd.Parameters.AddWithValue("@n", nombre);
        cmd.Parameters.AddWithValue("@a", apellido);

        conexion.cn.Open();
        cmd.ExecuteNonQuery();
        conexion.cn.Close();
    }
}
