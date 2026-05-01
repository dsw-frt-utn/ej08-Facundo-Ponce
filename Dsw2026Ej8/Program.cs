namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema5 problema5 = new Problema5();

            RetailSale ventaMinorista = new RetailSale();
            ventaMinorista.SetMontoBase(1000m);

            WholesaleSale ventaMayorista = new WholesaleSale();
            ventaMayorista.SetMontoBase(1000m);

            Console.WriteLine("------ Demostracion Problema 5 ------");

            decimal resultadoMinorista = problema5.ObtenerImporteFinal(ventaMinorista);
            Console.WriteLine($"Importe Venta Minorista: ${resultadoMinorista}");

            decimal resultadoMayorista = problema5.ObtenerImporteFinal(ventaMayorista);
            Console.WriteLine($"Importe Venta Mayorista: ${resultadoMayorista}");
        }
    }
}
