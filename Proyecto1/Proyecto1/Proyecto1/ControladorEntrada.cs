using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class ControladorEntrada
    {
        private ConstructorExpresion constructor;
        private MotorCalculo motor;
        private RegistroHistorial historial;

        
        private const string CadenaConexion =
            @"Data Source=DESKTOP-CSL8HP7\MYSSQLSERVEROS;Initial Catalog=CalculadoraDB;Integrated Security=True;TrustServerCertificate=True";

        public ControladorEntrada()
        {
            constructor = new ConstructorExpresion();
            motor = new MotorCalculo();
            historial = new RegistroHistorial();
        }

        public string ProcesarEntrada(string entrada)
        {
            if (constructor.ExpresionActual.Contains("="))
                constructor.Limpiar();

            constructor.AgregarElemento(entrada);
            return constructor.ExpresionActual;
        }

        public string Evaluar()
        {
            string expr = constructor.ExpresionActual;
            if (string.IsNullOrWhiteSpace(expr)) return expr;

            
            while (expr.Length > 0 && "+-*/.".Contains(expr[expr.Length - 1]))
                expr = expr.Substring(0, expr.Length - 1);

            if (string.IsNullOrWhiteSpace(expr)) return constructor.ExpresionActual;

            string resultado = motor.EvaluarExpresion(expr);

         
            constructor.Limpiar();
            constructor.AgregarElemento(expr);
            constructor.AgregarResultado(resultado);

            string operacionCompleta = $"{expr}={resultado}";

            
            if (!resultado.Equals("Error", StringComparison.OrdinalIgnoreCase))
            {
                historial.Agregar(operacionCompleta); 
                GuardarEnBD(operacionCompleta);       
            }

            return constructor.ExpresionActual;
        }

        public string LimpiarTodo()
        {
            constructor.Limpiar();
            return constructor.ExpresionActual;
        }

        
        private void GuardarEnBD(string operacionCompleta)
        {
            using (var cn = new SqlConnection(CadenaConexion))
            using (var cmd = new SqlCommand(
                "INSERT INTO dbo.OperacionesLog (Operacion, FechaHora) VALUES (@op, GETDATE());", cn))
            {
                cmd.Parameters.AddWithValue("@op", operacionCompleta ?? string.Empty);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
    

