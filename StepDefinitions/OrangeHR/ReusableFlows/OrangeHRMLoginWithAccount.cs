using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using VKNewSpecFlowProject1.Pages;
using VKNewSpecFlowProject1.StepDefinitions;

namespace VKNewSpecFlowProject1.StepDefinitions.OrangeHR.ReusableFlows
{
    [Binding]
    public class OrangeHRMLoginWithAccountStepDefinitions
    {
        private IWebDriver driver;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        CommonStepsPage commonsteps;

        public OrangeHRMLoginWithAccountStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
            commonsteps = new CommonStepsPage(driver);
        }

        [Given(@"User is logged in to the site with username <username> and password <password>")]
        public void GivenUserIsLoggedInToTheSiteWithUsernameUsernameAndPasswordPassword(Table table)
        {
            loginPage.launchbrowser();
            foreach (var row in table.Rows)
            {
                string Username = row["username"];
                string Password = row["password"];
                commonsteps.entertext(Username, "username");
                commonsteps.entertext(Password, "password");
                Console.WriteLine("Username entered: " + Username + " Password entered: " + Password);
            }
            commonsteps.clickbutton("login");
        }
    }
}


