using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductHelper p = new ProductHelper();
            //Console.WriteLine(p.ObtenerEtiquetaProducto(123,"Agua",1500));

            //Problema2 p2 = new Problema2();
            //Console.WriteLine(p2.CrearResumenVenta(123, "Agua", 2, 1500));

            //Problema3 p3 = new Problema3();
            //Product prod = new Product();
            //prod.SetDescripcionProducto("Descripcion Original");
            //Console.Write(p3.CompararCopias(5, prod));

            //Problema4 p4 = new Problema4();
            //Console.WriteLine(p4.CalcularPromedio(null, 10, 15));

            //Problema5 p5 = new Problema5();
            //RetailSale r = new RetailSale();
            //r.importebase= 1000;
            //Console.WriteLine(p5.ObtenerImporteFinal(r)); 
            //WholesaleSale w = new WholesaleSale();
            //w.importebase = 1000;
            //Console.WriteLine(p5.ObtenerImporteFinal(w));

            Problema6 p6 = new Problema6();
            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
            Console.WriteLine(p6.NormalizarCodigoProducto(null));

        }
    }
}
