using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class MotorCalculo
    {
        public string EvaluarExpresion(string expresion)
        {
            try
            {
                DataTable tabla = new DataTable();
                var resultado = tabla.Compute(expresion, "");
                return resultado.ToString();
            }
            catch
            {
                return "Error";
            }
        }
    }
}

