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
                    services.AddHostedService<CHSensorService>();
                    services.AddTransient<CHClientService>();
                });
    }
}
