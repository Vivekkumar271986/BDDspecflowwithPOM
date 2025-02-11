using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using VKNewSpecFlowProject1.Pages;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMLoginPageStepDefinitions
    {
        private IWebDriver driver;
        LoginPage loginPage;
        DashboardPage dashboardPage;
        CommonStepsPage commonStepsPage;

        public OrangeHRMLoginPageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
            commonStepsPage = new CommonStepsPage(driver);
        }

        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            loginPage.launchbrowser();
        }

        [When(@"User enters ""([^""]*)"" in the ""([^""]*)"" text box")]
        public void WhenUserEntersInTheTextBox(string logindetails, string textboxinputvalue)
        {
            commonStepsPage.entertext(logindetails, textboxinputvalue);
        }

        [Then(@"User is on login page and error message is displayed")]
        public void ThenUserIsOnLoginPageAndErrorMessageIsDisplayed()
        {
            loginPage.loginerror();
        }
    }
}