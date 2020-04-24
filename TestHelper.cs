namespace IOptionsPattern
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class TestHelper
    {
        private static readonly IConfigurationRoot ConfigurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        public static BandWidthSettings BandWidth
        {
            get
            {
                BandWidthSettings bandWidthSettings = new BandWidthSettings();

                ConfigurationRoot.GetSection(BandWidthSettings.SECTION).Bind(bandWidthSettings);

                return bandWidthSettings;
            }
        }
    }
}