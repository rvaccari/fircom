using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace FirCom
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var config = new ConfigurationBuilder().AddCommandLine(args).Build();
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseConfiguration(config)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();

            // var config = new ConfigurationBuilder()
            //     .AddCommandLine(args)
            //     .AddEnvironmentVariables(prefix: "ASPNETCORE_")
            //     .Build();

            // var host = new WebHostBuilder()
            //     .UseConfiguration(config)
            //     .UseKestrel()
            //     .UseContentRoot(Directory.GetCurrentDirectory())
            //     .UseIISIntegration()
            //     .UseStartup<Startup>()
            //     .Build();

            // host.Run();
        }
    }
}
