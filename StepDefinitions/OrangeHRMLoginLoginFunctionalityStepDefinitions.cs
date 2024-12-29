using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using VKNewSpecFlowProject1.Utility;
using VKNewSpecFlowProject1.Pages;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMLoginLoginFunctionalityStepDefinitions 
    {
        private IWebDriver driver;
        LoginPage loginPage;
        DashboardPage dashboardPage;

        public OrangeHRMLoginLoginFunctionalityStepDefinitions (IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            loginPage.launchbrowser();
            Thread.Sleep(5000);
        }

        [When(@"User enters ""([^""]*)"" in the ""([^""]*)"" text box")]
        public void WhenUserEntersInTheTextBox(string logindetails, string textboxinputvalue)
        {
            loginPage.entertext(logindetails, textboxinputvalue);
        }  

        [When(@"User clicks on the ""([^""]*)"" button")]
        public void WhenUserClicksOnTheButton(string button)
        {
            loginPage.submit(button);
            Thread.Sleep(5000);
        }

        [Then(@"User is navigated to ""([^""]*)"" page")]
        public void ThenUserIsNavigatedToPage(string pagename)
        {
            dashboardPage.pagedisplay(pagename);
        }

        [Then(@"User is on login page and error message is displayed")]
        public void ThenUserIsOnLoginPageAndErrorMessageIsDisplayed()
        {
            loginPage.loginerror();
        }
    }
}