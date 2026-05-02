using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }

    internal class Sale
    {
        public decimal importebase;

        public virtual decimal CalculateTotal()
        {
            return importebase;
        }
    }

    class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return importebase;
        }
    }

    class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return importebase * 0.9m;
        }
    }

}

