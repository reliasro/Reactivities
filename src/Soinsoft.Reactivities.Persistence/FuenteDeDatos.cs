using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Soinsoft.Reactivities.Persistence
{
    public static class FuenteDeDatos
    {

        public static IServiceCollection AgregarFuenteDB(this IServiceCollection services, string coneccion){
                 
                 services.AddDbContext<DataContext>(opt=>{
                     opt.UseSqlite(coneccion);
                 });
                 return services;
        }
    }
}