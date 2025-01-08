using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VKNewSpecFlowProject1.ComponentHelper;
using VKNewSpecFlowProject1.Locators.OrangeHR;
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

        public By GetLocator(string keyword)
        {
            if (LoginPageLocators.Locators.TryGetValue(keyword.ToLower(), out By locator))
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