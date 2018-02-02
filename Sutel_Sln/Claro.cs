using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutel_Sln
{
    class Claro : ISutel
    {
        public int minutos
        {
            get;
            set;

        }

        public int numTelefono
        {
            get;
            set;
        }

        public string Proveedor
        {
            get
            {
                return "Claro";
            }
        }

        public int calcularFactura()
        {
            int total = 0;

            if (minutos <= 10)
            {
                total = minutos * 15;
            }
            else
            {
                total = (10 * 15) + ((minutos - 10) * 25);
            }

            return total;
        }
    }
}