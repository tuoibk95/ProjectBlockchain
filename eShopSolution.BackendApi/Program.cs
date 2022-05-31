using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Tạo web host
        /// </summary>
        /// <param name="args"></param>
        /// <returns>Trả về một đối tượng IHostBuilder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            // CreateDefaultBuilder tạo 1 server kestrel là một web server của dot net core mặc định
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
                {
                    // Dùng start up để cấu hình
                    webBuilder.UseStartup<Startup>();
                });
    }
}
