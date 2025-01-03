using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VKNewSpecFlowProject1.ComponentHelper;
using VKNewSpecFlowProject1.Utility;

namespace VKNewSpecFlowProject1.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        private ButtonClickHelper buttonClickHelper;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            buttonClickHelper = new ButtonClickHelper(driver);
        }

        private readonly Dictionary<string, By> _locators = new Dictionary<string, By>
        {
            { "username", By.XPath("//input[@name='username']") },
            { "password", By.XPath("//input[@name='password']") },
            { "login", By.TagName("button") },
            { "error message", By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']") }
        };

        public By GetLocator(string keyword)
        {
            if (_locators.TryGetValue(keyword.ToLower(), out By locator))
            {
                return locator;
            }
            throw new KeyNotFoundException($"Locator for keyword '{keyword}' not found.");
        }

        public void launchbrowser()
        {
            driver.Navigate().GoToUrl(ConfigReader.BaseUrl);
        }

        public void entertext(string keyword, string text)
        {
            By locator = GetLocator(text);
            driver.FindElement(locator).SendKeys(keyword);
        }

        public void loginerror()
        {
            By locator = GetLocator("error message");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement errorMessage = wait.Until(d => d.FindElement(locator));
            string eMessage = errorMessage.Text;
            Assert.AreEqual("Invalid credentials", eMessage);
            Console.WriteLine("Error Message is: " + eMessage);
        }
    }
}