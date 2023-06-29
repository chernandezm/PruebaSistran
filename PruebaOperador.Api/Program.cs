
namespace PruebaOperador.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Log.Logger = InicializarConfiguracionSerilog.ConfiguracionSerilog().CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
