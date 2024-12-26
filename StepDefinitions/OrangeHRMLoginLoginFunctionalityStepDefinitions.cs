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

        public OrangeHRMLoginLoginFunctionalityStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
        }

        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            loginPage.launchbrowser();
            Thread.Sleep(5000);
        }

        [When(@"User enters ""([^""]*)"" in the Username text box")]
        public void WhenUserEntersTheAdminTextBox(String username)
        {
            loginPage.enterusername(username);
        }

        [When(@"User enters ""([^""]*)"" in the Password text box")]
        public void WhenUserEntersInTheTextBox(String password)
        {
            loginPage.enterpass(password);
        }

        [When(@"User clicks on the Login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            loginPage.submit();
            Thread.Sleep(5000);
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Thread.Sleep(5000);
            loginPage.submit();
        }

        [Then(@"User is on login page and error message is displayed")]
        public void ThenUserIsOnLoginPageAndErrorMessageIsDisplayed()
        {
            loginPage.loginerror();
        }
    }
}
