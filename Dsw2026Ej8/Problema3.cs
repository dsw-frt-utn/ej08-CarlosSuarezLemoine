using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
       
        public string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            copia++;
            Product productoCopia = product;
            productoCopia.SetDescripcionProducto("Descripcion Modificada");


            return originalValue + "-" + copia + "-" + product.GetDescripcionProducto();
        }


    }

    internal class Product
    {
        public int valorCopia;
        public string descripcionProducto;

        public int GetValorCopia()
        {
            return valorCopia;
        }

        public void SetValorCopia(int value)
        {
            valorCopia = value;
        }

        public string GetDescripcionProducto()
        {
            return descripcionProducto;
        }

        public void SetDescripcionProducto(string value)
        {
            descripcionProducto = value;
        }

    }
}
