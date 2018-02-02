using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutel_Sln
{
    class Movistar : ISutel
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
                return "Movistar";
            }
        }

        public int calcularFactura()
        {
            int total = 0;

            if (minutos <= 10)
            {
                total = minutos * 28;
            }
            else
            {
                if (minutos <= 20)
                {
                    total = (10 * 28) + (minutos - 10) + (minutos * 22);
                }
                else
                {
                    total = (10 * 28) + (10 * 22) + ((minutos - 20) * 18);
                }
            }

            return total;
        }
    }
}