using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using VKNewSpecFlowProject1.Pages;
using VKNewSpecFlowProject1.Utility;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class FeatureToRegisterForRahulshettyAcadamiesAngularPracticeSessionStepDefinitions
    {
        private IWebDriver driver;
        AngularPracticePage angularPracticePage;

        public FeatureToRegisterForRahulshettyAcadamiesAngularPracticeSessionStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            angularPracticePage = new AngularPracticePage(driver);
        }

        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            driver.Navigate().GoToUrl(ConfigReader.BaseUrl);
        }

        [When(@"I see ""([^""]*)"" in header")]
        public void WhenISeeInHeader(string label)
        {
            angularPracticePage.WhenISeeInHeader(label);
        }

        [Then(@"I fill the registration form")]
        public void ThenIFillTheRegistrationForm(Table table)
        {
            angularPracticePage.FillTheRegistrationForm(table);
        }
    }
}