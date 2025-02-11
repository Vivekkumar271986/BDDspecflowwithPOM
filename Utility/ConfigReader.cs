using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.Extensions.Configuration;

namespace VKNewSpecFlowProject1.Utility
{
    class ConfigReader
    {
        public static string BaseUrl { get; private set; }
        public static string Browser { get; private set; }
        public static bool Headless { get; private set; }
        public static int ImplicitWait { get; private set; }
        public static int PageLoad { get; private set; }
        public static int AsynchronousJavaScript { get; private set; }
        public static int ViewportWidth { get; private set; }
        public static int ViewportHeight { get; private set; }
        public static bool Maximize { get; private set; }

        static ConfigReader()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath("C:\\Users\\vikum\\source\\repos\\VKNewSpecFlowProject1\\VKNewSpecFlowProject1\\Utility")      //use base path of the Config.json file
                .AddJsonFile("config.json", optional: false, reloadOnChange: true)
                .Build();

            var baseUrlsConfiguration = new ConfigurationBuilder()
                .SetBasePath("C:\\Users\\vikum\\source\\repos\\VKNewSpecFlowProject1\\VKNewSpecFlowProject1\\Utility")      //use base path of the BaseUrls.json file
                .AddJsonFile("brand-and-env.json", optional: false, reloadOnChange: true)
            .Build();

            BaseUrl = baseUrlsConfiguration[$"BaseUrls:{configuration["Brand"]}"];
            Browser = configuration["Browser"] ?? "chrome";
            Headless = bool.Parse(configuration["Headless"]);
            ImplicitWait = int.TryParse(configuration["Timeouts:ImplicitWait"], out var implicitWait) ? implicitWait : 10;
            PageLoad = int.TryParse(configuration["Timeouts:PageLoad"], out var pageLoad) ? pageLoad : 30;
            AsynchronousJavaScript = int.TryParse(configuration["Timeouts:AsynchronousJavaScript"], out var asyncJs) ? asyncJs : 30;
            ViewportWidth = int.TryParse(configuration["Viewport:Width"], out var viewportWidth) ? viewportWidth : 1920;
            ViewportHeight = int.TryParse(configuration["Viewport:Height"], out var viewportHeight) ? viewportHeight : 1080;
            Maximize = bool.Parse(configuration["Maximize"]);
        }
    }
}