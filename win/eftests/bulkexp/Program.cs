
using bulkexp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;

namespace bulkexp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var app = host.Services.GetService<App>();
            app.Run();
            host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((host, services) =>
                {
                    services.AddDbContext<ABCContext>(options => options.UseSqlServer(host.Configuration.GetConnectionString("Default")));
                    services.AddTransient<App>();
                });
        }
    }
}
