using Microsoft.Extensions.Configuration;

namespace Orthoweb.Tests
{
    public class TestConfiguration
    {
        public string SageX3ConnectionString { get; set; }
    }


    public static class TestsHelpers
    {
        public static IConfiguration GetConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddUserSecrets("32c34446-c3cf-46b6-b6a1-9fb50a55934c")
                .AddEnvironmentVariables()
                .Build();
        }

        public static TestConfiguration GetApplicationConfiguration(string outputPath)
        {
            var configuration = new TestConfiguration();
            var config = GetConfigurationRoot(outputPath);
            config.GetSection("TestApp").Bind(configuration);
            return configuration;
        }
    }
}