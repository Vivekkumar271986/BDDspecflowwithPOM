using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;
using VKNewSpecFlowProject1.Pages;

namespace VKNewSpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMCommonSteppDefinitions
    {
        private IWebDriver driver;
        CommonStepsPage commonsteps;

        public OrangeHRMCommonSteppDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            commonsteps = new CommonStepsPage(driver);
        }

        [When(@"User clicks on the ""([^""]*)"" button")]
        public void WhenUserClicksOnTheButton(string button)
        {
            commonsteps.clickbutton(button);
            Thread.Sleep(5000);
        }

        [When(@"User is navigated to ""([^""]*)"" page")]
        [Then(@"User is navigated to ""([^""]*)"" page")]
        public void ThenUserIsNavigatedToPage(string pagename)
        {
            commonsteps.pagedisplay(pagename);
        }

        [Then(@"User waits for the ""(.*)"" element to load")]
        [When(@"User waits for the ""(.*)"" element to load")]
        public void WhenUserWaitsForTheElementToLoad(string keyword)
        {
            commonsteps.WaitForElementToLoad(keyword);
        }
    }
}
