using VKNewSpecFlowProject1.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace VKNewSpecFlowProject1.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // locators on the login page
        By usernameField = By.XPath("//input[@name = 'username']");
        By passwordField = By.XPath("//input[@name = 'password']");
        By loginFormLocator = By.TagName("button");
        By homepagedisplayed = By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]");
        By errormessage = By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']");

        // laucnh browser
        public void launchbrowser()
        {
            driver.Navigate().GoToUrl(Config.OrangeHRBaseUrl);
        }

        // enter username and password
        public void enterusername(String username)
        {
            driver.FindElement(usernameField).SendKeys(username);
        }

        public void enterpass(String password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        // submit method
        public void submit()
        {
            driver.FindElement(loginFormLocator).Click();
        }

        // home page is displayed
        public void homepagedisplay()
        {
            IWebElement homepage = driver.FindElement(homepagedisplayed);
            if (homepage.Displayed)
            {
                Console.WriteLine("Home page is displayed");
            }
            else
            {
                Console.WriteLine("Home page is not displayed");
            }
        }

        public void loginerror()
        {
            Thread.Sleep(3000);
            IWebElement ErrorMessage = driver.FindElement(errormessage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => ErrorMessage.Displayed);
            String EMessage = ErrorMessage.Text;
            Assert.AreEqual("Invalid credentials", EMessage);
            Console.WriteLine("Error Message is:" + EMessage);
        }
    }
}