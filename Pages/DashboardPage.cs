using VKNewSpecFlowProject1.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace VKNewSpecFlowProject1.Pages
{
    public class DashboardPage
    {
        private IWebDriver driver;

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly Dictionary<string, By> _locators = new Dictionary<string, By>
        {
            { "dashboard", By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']") },
            { "leftnavdashboard", By.XPath("//a[@class='oxd-main-menu-item active']") }
        };

        // Method to get locator by keyword
        public By GetLocator(string keyword)
        {
            if (_locators.TryGetValue(keyword.ToLower(), out By locator))
            {
                return locator;
            }
            throw new KeyNotFoundException($"Locator for keyword '{keyword}' not found.");
        }

        // Verify page is displayed
        public void pagedisplay(String keyword)
        {
            By locator = GetLocator(keyword);
            IWebElement page = driver.FindElement(locator);
            if (page.Displayed)
            {
                Console.WriteLine(page.Text + " page is displayed");
            }
            else
            {
                Console.WriteLine(page.Text + " page is not displayed");
            }
        }

        public void leftnavtabhighlighted(String keyword)
        {
            By locator = GetLocator(keyword);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement LeftNavTab = driver.FindElement(locator);
            wait.Until(d => LeftNavTab.Displayed);
            Console.WriteLine(LeftNavTab.Text + " tab highlighted");
        }
    }
}
