using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class ConstructorExpresion
    {
        public string ExpresionActual { get; private set; } = string.Empty;


        public void AgregarElemento(string valor)
        {
            ExpresionActual += valor;
        }


        public void AgregarResultado(string resultado)
        {
            ExpresionActual += "=" + resultado;
        }


        public void Limpiar()
        {
            ExpresionActual = string.Empty;
        }
    }
}

