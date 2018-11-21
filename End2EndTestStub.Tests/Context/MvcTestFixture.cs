using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace End2EndTestStub.Tests.Context
{
    public class OrchardTestFixture<TStartup> : WebApplicationFactory<TStartup>
        where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            var shellsApplicationDataPath = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");

            if (Directory.Exists(shellsApplicationDataPath))
            {
                Directory.Delete(shellsApplicationDataPath, true);
            }

            builder.UseContentRoot(Directory.GetCurrentDirectory());
        }

        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            return WebHostBuilderFactory.CreateFromAssemblyEntryPoint(
                typeof(End2EndTestStub.Startup).Assembly, Array.Empty<string>())
                .UseStartup<TStartup>();
        }
    }
}