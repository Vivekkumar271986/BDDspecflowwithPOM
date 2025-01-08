using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using VKNewSpecFlowProject1.Utility;
using WebDriverManager.DriverConfigs.Impl;

namespace VKNewSpecFlowProject1.Drivers
{
    public class DriverFactory
    {
        public static ThreadLocal<IWebDriver> tlDriver = new ThreadLocal<IWebDriver>();

        public IWebDriver InitDriver(string browser)
        {
            Console.WriteLine("Browser value is: " + browser);
            if (browser.ToLower() == "chrome")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                ChromeOptions chromeOptions = new ChromeOptions();
                if (ConfigReader.Headless) chromeOptions.AddArguments("--headless");
                tlDriver.Value = new ChromeDriver(chromeOptions);
            }
            else if (browser.ToLower() == "firefox")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                if (ConfigReader.Headless) firefoxOptions.AddArguments("--headless");
                tlDriver.Value = new FirefoxDriver(firefoxOptions);
            }
            else if (browser.ToLower() == "edge")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                EdgeOptions edgeOptions = new EdgeOptions();
                if (ConfigReader.Headless) edgeOptions.AddArguments("--headless");
                tlDriver.Value = new EdgeDriver(edgeOptions);
            }
            else
            {
                throw new NotSupportedException($"Browser '{browser}' is not supported.");
            }

            if (ConfigReader.Maximize)
            {
                GetDriver().Manage().Window.Maximize();
            }
            else
            {
                GetDriver().Manage().Window.Size = new System.Drawing.Size(ConfigReader.ViewportWidth, ConfigReader.ViewportHeight);
            }

            GetDriver().Manage().Cookies.DeleteAllCookies();
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ConfigReader.ImplicitWait);
            GetDriver().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ConfigReader.PageLoad);
            GetDriver().Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(ConfigReader.AsynchronousJavaScript);

            return GetDriver();
        }

        public static IWebDriver GetDriver()
        {
            return tlDriver.Value ?? throw new InvalidOperationException("Local Thread WebDriver instance is not initialized.");
        }
    }
}