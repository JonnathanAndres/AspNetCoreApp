using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MyFirstAspNetCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilderModificadoDos(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static IWebHostBuilder CreateWebHostBuilderModificado(string[] args)
        {
            var webHostBuilder = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(AppContext.BaseDirectory)
                .UseIISIntegration()
                .UseStartup<Startup>();
            return webHostBuilder;
        }

        public static IWebHostBuilder CreateWebHostBuilderModificadoDos(string[] args)
        {
            var webHostBuilder = new WebHostBuilder()
                .UseHttpSys()
                .UseUrls("http://localhost:9998", "http://localhost:9999")
                .UseContentRoot(AppContext.BaseDirectory)
                .UseStartup<AppInitialization>();
            return webHostBuilder;
        }
    }
}
