using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblio.Data;

namespace Biblio
{
    public class Program
    {
        private static Bibl2DbContext context;
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            DataToAdd.AutorsData(context);
            DataToAdd.GramatasData(context);
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
