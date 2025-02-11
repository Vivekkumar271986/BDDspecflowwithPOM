using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using VKNewSpecFlowProject1.Pages;

namespace VKNewSpecFlowProject1.StepDefinitions.OrangeHR
{
    [Binding]
    public class OrangeHRMDashboardPageStepDefinitions
    {
        private IWebDriver driver;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        CommonStepsPage commonStepsPage;

    public OrangeHRMDashboardPageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
            commonStepsPage = new CommonStepsPage(driver);
        }

        [Then(@"User sees ""([^""]*)"" tab highlighted")]
        public void ThenUserSeesTabHighlighted(string tabhighlighted)
        {
            dashboardPage.leftnavtabhighlighted(tabhighlighted);
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

        [Then(@"User enters ""([^""]*)"" text in ""([^""]*)"" textfield")]
        public void ThenUserEntersTextInTextfield(string text, string field)
        {
            commonStepsPage.entertext(text, field);
        }
    }
}
