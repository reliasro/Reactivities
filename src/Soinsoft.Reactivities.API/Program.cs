using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Soinsoft.Reactivities.Persistence;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Aqui configuro para recuperar el servicio de Datacontext y 
            //Lograr que las migraciones se apliquen a la base de datos
            //automaticamente cada vez que yo corra el aplicativo. 
            //Si deseo puedo hacer este paso manualmente con dotnet ef database update <migracion>
            var host=CreateHostBuilder(args).Build();
            using var scope=host.Services.CreateScope();
            var services=scope.ServiceProvider;

            try
            {
                //recupero el servicio contexto de la bd
                var context =  services.GetRequiredService<DataContext>();
                await context.Database.MigrateAsync();
                await Seed.SeedData(context);

            }
            catch (System.Exception ex)
            {
                //Recupero el servicio Logger
                var logger= services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex,"Bueno acaba de suceder un error");
            }
            //Fin corrida migraciones automaticamente
            
            await host.RunAsync();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
