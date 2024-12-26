using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMDashboardleftnavvalidationStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public OrangeHRMDashboardleftnavvalidationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }

        [When(@"User enters ""([^""]*)"" in the ""([^""]*)"" text box")]
        public void WhenUserEntersInTheTextBox(string logindetails,string textboxinputvalue)
        {
            _driver.FindElement(By.XPath(textboxinputvalue)).SendKeys(logindetails);
        }


        [Then(@"User is navigated to ""([^""]*)"" page with ""([^""]*)"" tab highlighted")]
        public void ThenUserIsNavigatedToPageWithTabHighlighted(string dashboard, string leftnavdashboard)
        {
            Thread.Sleep(7000);
            IWebElement PageHeader = _driver.FindElement(By.XPath(dashboard));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => PageHeader.Displayed);
            IWebElement LeftNavTab = _driver.FindElement(By.XPath(leftnavdashboard));
            wait.Until(d => LeftNavTab.Displayed);
            Console.WriteLine("User is in " + PageHeader.Text +"page with " +LeftNavTab.Text +" tab highlighted");
        }

        [When(@"User clicks on Admin button")]
        public void WhenUserClicksOnAdminButton()
        {
            throw new PendingStepException();
        }

        [Then(@"User selects city and country information")]
        public void ThenUserSelectsCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city, country);
            }
        }

    }
}
