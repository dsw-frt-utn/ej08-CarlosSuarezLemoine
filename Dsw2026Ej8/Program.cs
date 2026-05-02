using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductHelper p = new ProductHelper();
            //Console.WriteLine(p.ObtenerEtiquetaProducto(123,"Agua",1500));
            Problema2 p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(123, "Agua", 2, 1500));
        }
    }
}
