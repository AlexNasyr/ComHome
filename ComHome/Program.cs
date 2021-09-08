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
                    IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("secrets.json").Build();
                    services.AddHostedService<CHSensorService>();
                    services.AddDbContext<DbMsSqlContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultDB")));
                    services.AddTransient<IComHomeDBContext, DbMsSqlContext>();
                    services.AddTransient<IComHomeRepository, ComHomeRepository>();
                    services.AddTransient<CHClientService>();
                });
    }
}
