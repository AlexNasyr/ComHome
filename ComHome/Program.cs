using ComHome.Hubs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComHome.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ComHome {
    public class Program {
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureServices(services => {
                    IConfiguration conf = new ConfigurationBuilder().AddJsonFile("secrets.json").Build();
                    services.AddHostedService<CHSensorService>();
                    //services.AddTransient<IComHomeDBContext, DbMssqlContext>();
                    //services.AddDbContext<DbMssqlContext>(options => options.UseSqlServer(conf.GetConnectionString("MssqlDB")));
                    services.AddTransient<IComHomeDBContext, DbPgContext>();
                    services.AddDbContext<DbPgContext>(options => options.UseNpgsql(conf.GetConnectionString("PgSqlDB"))); 
                    
                    services.AddTransient<IComHomeRepository, ComHomeRepository>();
                    services.AddTransient<CHClientService>();
                });
    }
}


