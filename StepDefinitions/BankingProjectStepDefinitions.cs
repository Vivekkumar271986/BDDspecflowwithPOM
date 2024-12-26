using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class BankingProjectStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public BankingProjectStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }

        [Given(@"User launches Banking project")]
        public void GivenUserLaunchesBankingProject()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
        }

        [When(@"I see ""([^""]*)"" button")]
        public void WhenISeeButton(string seebutton)
        {
            Thread.Sleep(2000);
            IWebElement Seebutton = _driver.FindElement(By.XPath(seebutton));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => Seebutton.Displayed);
        }

        [Then(@"I see ""([^""]*)"" button")]
        public void ThenISeeButton(string seebutton)
        {
            Thread.Sleep(3000); 
            IWebElement Seebutton = _driver.FindElement(By.XPath(seebutton));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => Seebutton.Displayed);
        }


        [When(@"I see ""([^""]*)"" heading")]
        public void WhenISeeheading(string heading)
        {
            Thread.Sleep(2000);
            IWebElement Heading = _driver.FindElement(By.XPath(heading));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => Heading.Displayed);
        }

        [Then(@"I click ""([^""]*)"" button")]
        public void ThenIClickButton(string button)
        {
            _driver.FindElement(By.XPath(button)).Click();

        }

        [Then(@"I see ""([^""]*)"" text")]
        public void ThenISeeText(string text)
        {
            Thread.Sleep(5000);
            IWebElement Text = _driver.FindElement(By.XPath(text));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => Text.Displayed);
            Console.WriteLine("Text disaplayed is " + Text.Text);
        }


        [Then(@"I click ""([^""]*)"" from ""([^""]*)"" dropdown")]
        public void ThenIClickFromDropdown(string Username, string Dropdown)
        {
            _driver.FindElement(By.XPath(Dropdown)).Click();
            Assert.IsNotNull(Dropdown);
            var select = new SelectElement(_driver.FindElement(By.XPath(Dropdown)));
            Thread.Sleep(1000);
            select.SelectByText((Username));
        }

        [Then(@"I fill open account form")]
        public void ThenIFillOpenAccountForm(Table table)
        {
            foreach (var row in table.Rows)
            {
                //Select Customer
                string Customer = row["Customer"];
                IWebElement customerdropdown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));
                Assert.IsNotNull(customerdropdown);
                SelectElement selectcustomer = new SelectElement(customerdropdown);
                selectcustomer.SelectByText(Customer);

                //Select Currency
                string Currency = row["Currency"];
                IWebElement currencydropdown = _driver.FindElement(By.XPath("//select[@id='currency']"));
                Assert.IsNotNull(currencydropdown);
                SelectElement selectcurrency = new SelectElement(currencydropdown);
                selectcurrency.SelectByText(Currency);

                _driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                IAlert alt = _driver.SwitchTo().Alert();
                string alertText = alt.Text;
                Console.WriteLine(alertText);
                alt.Accept();
            }
        }

    }
}
