using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;
using VKNewSpecFlowProject1.Pages;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMDashboardleftnavvalidationStepDefinitions
    {
        private IWebDriver driver;
        LoginPage loginPage;
        DashboardPage dashboardPage;

        public OrangeHRMDashboardleftnavvalidationStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [Then(@"User sees ""([^""]*)"" tab highlighted")]
        public void ThenUserSeesTabHighlighted(string tabhighlighted)
        {
            dashboardPage.leftnavtabhighlighted(tabhighlighted);
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
