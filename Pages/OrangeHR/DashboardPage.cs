using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VKNewSpecFlowProject1.ActionHelper    ;
using VKNewSpecFlowProject1.Locators.OrangeHR;

namespace VKNewSpecFlowProject1.Pages
{
    public class DashboardPage
    {
        private IWebDriver driver;
        private ButtonClickHelper buttonClickHelper;

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
            buttonClickHelper = new ButtonClickHelper(driver);
        }

        public By GetLocator(string keyword)
        {
            if (DashboardPageLocators.Locators.TryGetValue(keyword.ToLower(), out By locator))
            {
                return locator;
            }
            throw new KeyNotFoundException($"Locator for keyword '{keyword}' not found.");
        }

        public void leftnavtabhighlighted(string keyword)
        {
            By locator = GetLocator(keyword);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement LeftNavTab = driver.FindElement(locator);
            wait.Until(d => LeftNavTab.Displayed);
            Console.WriteLine(LeftNavTab.Text + " tab highlighted");
        }
    }
}