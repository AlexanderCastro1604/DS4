using System.Configuration;
using System.Data.SqlClient;

public class Conexion
{
    public SqlConnection cn;

    public Conexion()
    {
        string cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        cn = new SqlConnection(cadena);
    }
}
