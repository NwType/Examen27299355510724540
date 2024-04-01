namespace SistemasVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(new ClientesVistas.ClientesListarVista()); //CONSULTA 1
            Application.Run(new ProveedorVistas.ProveedorListarVista()); //CONSULTA 2
            Application.Run(new MarcaVistas.MarcaListarVista()); //CONSULTA 3
            Application.Run(new ProductoVistas.ProductoListarVista()); //CONSULTA 4
            Application.Run(new ProductoVistas.Consulta5()); //CONSULTA 5
            Application.Run(new VentaVistas.VentaListarVista()); //CONSULTA 6
            Application.Run(new ClientesVistas.Consulta7()); //CONSULTA 7
            Application.Run(new ProveedorVistas.consulta8()); //CONSULTA 8
            Application.Run(new ProductoVistas.Consulta9()); //CONSULTA 9
            Application.Run(new ClientesVistas.Consulta10()); //CONSULTA 10
        }
    }
}