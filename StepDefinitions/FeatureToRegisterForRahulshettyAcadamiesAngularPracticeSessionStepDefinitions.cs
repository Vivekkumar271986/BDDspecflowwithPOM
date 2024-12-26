using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class FeatureToRegisterForRahulshettyAcadamiesAngularPracticeSessionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public FeatureToRegisterForRahulshettyAcadamiesAngularPracticeSessionStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }

        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }

        [When(@"I see ""([^""]*)"" in header")]
        public void WhenISeeInHeader(string label)
        {
            Thread.Sleep(7000);
            IWebElement PageHeader = _driver.FindElement(By.XPath(label));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => PageHeader.Displayed);
            Console.WriteLine(PageHeader.Text +" is displayed");
        }

        [Then(@"I Then fill the registration form")]
        public void ThenIThenFillTheRegistrationForm(Table table)
        {
            foreach (var row in table.Rows)
            {
                string Name = row["Name"];
                _driver.FindElement(By.XPath("//div[@class='form-group']//input[@name='name']")).SendKeys(Name);
                string Email = row["Email"];
                _driver.FindElement(By.XPath("//input[@name='email']")).SendKeys(Email);
                string Password = row["Password"];
                string Gender = row["Gender"];
                _driver.FindElement(By.XPath("//input[@name='email']")).SendKeys(Gender);
                IWebElement dropdown = _driver.FindElement(By.XPath("//select[@id='exampleFormControlSelect1']"));
                Assert.IsNotNull(dropdown);
                SelectElement select = new SelectElement(dropdown);
                select.SelectByText("Male");
                string DateofBirth = row["DateofBirth"];
                _driver.FindElement(By.XPath("//input[@name='bday']")).SendKeys(DateofBirth);
                _driver.FindElement(By.XPath("//input[@id='inlineRadio1']")).Click();

            }
        }
    }
}