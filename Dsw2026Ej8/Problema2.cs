using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {

        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total;

            if (quantity <= 0)
            {
                total = 0;
            }
            else 
            { 
                total = quantity * unitPrice; 
            }

           var Venta = new { code = productCode, description = productDescription,quantity = quantity,total = total};

            return Venta.code + " - " + Venta.description + " - " + Venta.total;
        }
    }
}
