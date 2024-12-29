using VKNewSpecFlowProject1.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

namespace VKNewSpecFlowProject1.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly Dictionary<string, By> _locators = new Dictionary<string, By>
        {
            { "username", By.XPath("//input[@name='username']") },
            { "password", By.XPath("//input[@name='password']") },
            { "login", By.TagName("button") },
            { "dashboard", By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']") },
            { "error message", By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']") }
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

        // launch browser
        public void launchbrowser()
        {
            driver.Navigate().GoToUrl(Config.OrangeHRBaseUrl);
        }

        // Enter text in a field
        public void entertext(string keyword, string text)
        {
            By locator = GetLocator(text);
            driver.FindElement(locator).SendKeys(keyword);
        }

        // submit method
        public void submit(string keyword)
        {
            By locator = GetLocator(keyword); 
            driver.FindElement(locator).Click();
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