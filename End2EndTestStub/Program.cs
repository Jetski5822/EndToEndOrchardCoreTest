using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace End2EndTestStub
{
    public class Program
    {
        public static void Main(string[] args)
            => BuildWebHost(args).Run();

        public static IWebHost BuildWebHost(string[] args)
            => CreateWebHostBuilder(args)
                .Build();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder<Startup>(args);
    }
}
