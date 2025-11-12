using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class RegistroHistorial
    {
        private List<string> historial = new List<string>();


        public void Agregar(string operacion)
        {
            historial.Add(operacion);
        }


        public List<string> ObtenerHistorial()
        {
            return historial;
        }


        public void Limpiar()
        {
            historial.Clear();
        }
    }
}

