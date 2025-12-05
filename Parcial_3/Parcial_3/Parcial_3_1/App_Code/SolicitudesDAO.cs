using System.Data.SqlClient;

public class SolicitudesDAO
{
    Conexion conexion = new Conexion();

    public void Registrar(int idSolicitante, string observaciones)
    {
        SqlCommand cmd = new SqlCommand(
            "INSERT INTO SolicitudesPasaporte (IdSolicitante, Estado, Observaciones) " +
            "VALUES (@id, 'Pendiente', @obs)",
            conexion.cn);

        cmd.Parameters.AddWithValue("@id", idSolicitante);
        cmd.Parameters.AddWithValue("@obs", observaciones);

        conexion.cn.Open();
        cmd.ExecuteNonQuery();
        conexion.cn.Close();
    }
}
