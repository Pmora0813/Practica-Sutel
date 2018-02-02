using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutel_Sln
{
    class Kolbi : ISutel
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
                return "Kolbi";
            }
        }

        public int calcularFactura()
        {
            int total = 0;

            if (minutos <= 5)
            {
                total = minutos * 30;
            }
            else
            {
                if (minutos <= 15)
                {
                    total = (5 * 30) + (minutos - 5) + (minutos*25);
                }
                else
                {
                    total = (5 * 30) + (10 * 25) + ((minutos-15)* 20);
                }
            }

            return total;
        }
    }
}
