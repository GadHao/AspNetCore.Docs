using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace LargeFilesSample
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
                    webBuilder.ConfigureKestrel((context, options) =>
                    {
                        // ��������Ĵ�С���ƣ�ʹ�ÿ����ϴ����ļ�
                        options.Limits.MaxRequestBodySize = long.MaxValue;
                    })
                    .UseStartup<Startup>();
                });
    }
}
