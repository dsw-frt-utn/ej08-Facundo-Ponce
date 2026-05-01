using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias (int originalValue, Product product) 
        {
            int copiaValor = originalValue;
            copiaValor++;

            Product copiaProducto = product;

            copiaProducto.SetDescription("Nueva Descripcion");

            return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
        }
    }

    public class Product
    {
        private string description = "";

        public string GetDescription() 
        { 
            return description;
        }

        public void SetDescription(string nuevaDescription) 
        {
            description = nuevaDescription;
        }
    }
}
