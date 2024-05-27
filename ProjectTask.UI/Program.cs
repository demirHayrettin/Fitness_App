using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectTask.DAL;

namespace ProjectTask.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = Host.CreateDefaultBuilder();
            builder.ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            });

            builder.ConfigureServices((context, services) =>
            {
                var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(connectionString));

                services.AddScoped<Form1>();
            });

            var host = builder.Build();

            ApplicationConfiguration.Initialize();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var form1 = services.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }
    }
}
