using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using VKNewSpecFlowProject1.Pages;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMLoginFunctionalityStepDefinitions
    {
        private IWebDriver driver;
        LoginPage loginPage;
        DashboardPage dashboardPage;

        public OrangeHRMLoginFunctionalityStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            loginPage.launchbrowser();
        }

        [When(@"User enters ""([^""]*)"" in the ""([^""]*)"" text box")]
        public void WhenUserEntersInTheTextBox(string logindetails, string textboxinputvalue)
        {
            loginPage.entertext(logindetails, textboxinputvalue);
        }

        [Then(@"User is on login page and error message is displayed")]
        public void ThenUserIsOnLoginPageAndErrorMessageIsDisplayed()
        {
            loginPage.loginerror();
        }
    }
}