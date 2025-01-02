using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace VKNewSpecFlowProject1.Utility
{
    class ConfigReader
    {
        public static string OrangeHRBaseUrl { get; private set; }
        public static string Browser { get; private set; }
        public static bool Headless { get; private set; }

        static ConfigReader()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath("C:\\Users\\vikum\\source\\repos\\VKNewSpecFlowProject1\\VKNewSpecFlowProject1\\Utility")      //use base path of the Config.json file
                .AddJsonFile("config.json", optional: false, reloadOnChange: true)
                .Build();

            OrangeHRBaseUrl = configuration["OrangeHRBaseUrl"];
            Browser = configuration["Browser"];
            Headless = bool.Parse(configuration["Headless"]);
        }
    }
}