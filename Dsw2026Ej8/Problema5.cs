using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal (Sale sale) 
        {
            return sale.CalculateTotal();
        }
    }

    public class Sale
    {
        public decimal montoBase;

        public decimal GetMontobase()
        {
            return montoBase;
        }

        public void SetMontoBase(decimal nuevoMonto)
        {
            montoBase = nuevoMonto;
        }

        public virtual decimal CalculateTotal()
        {
            return GetMontobase();
        }
    }

    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return GetMontobase();
        }
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return GetMontobase() - (GetMontobase() * 0.10m);
        }
    }
}
