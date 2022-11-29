using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //calc3 c1 = new calc3();
        //c1.Add(2,3);                     //  5
        //c2.Subtract(5,2);               // 3
        //c3.Multiply(2, 3);              // 6
        //c3.Divide(5, 1);                // 1

        //Or
        int a = 3;
        int b = 5;
        int c = a + b;
        Console.WriteLine(c);

        int a = 3;
        int b = 5;
        int c = a - b;
        Console.WriteLine(c);

        int a = 3;
        int b = 5;
        int c = a * b;
        Console.WriteLine(c);
        
        int a = 5;
        int b = 5;
        int c = a / b;
        Console.WriteLine(c);
    }
}
