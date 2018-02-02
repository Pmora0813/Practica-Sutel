using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutel_Sln
{
    public interface ISutel
    {
        string Proveedor { get; }
        int numTelefono { get; set; }
        int minutos { get; set; }

        int calcularFactura();

    }
}
