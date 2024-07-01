using Microsoft.Extensions.Configuration;

namespace LMTDatabase
{
    public class AppSettings
    {
        public string? WMConnection { get; set; }
        public string? HSTConnection { get; set; }

        public AppSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            WMConnection = config.GetConnectionString("WMConnection");
            HSTConnection = config.GetConnectionString("HSTConnection");
        }
    }
}
