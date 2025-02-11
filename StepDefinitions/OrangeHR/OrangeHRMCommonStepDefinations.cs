using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;
using VKNewSpecFlowProject1.Pages;

namespace VKNewSpecFlowProject1.CommonStepDefinitions
{
    [Binding]
    public class OrangeHRMCommonStepDefinitions
    {
        private IWebDriver driver;
        CommonStepsPage commonsteps;

        public OrangeHRMCommonStepDefinitions(IWebDriver driver)
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

        [Then(@"User selects ""([^""]*)"" from ""([^""]*)"" dropdown")]
        public void ThenUserSelectsFromDropdown(string option, string dropdown)
        {
            commonsteps.SelectsFromDropdown(option, dropdown);
        }

        [Then(@"User selects ""([^""]*)"" from ""([^""]*)"" divdropdown")]
        public void ThenUserSelectsFromDivdropdown(string option, string dropdown)
        {
            commonsteps.SelectFromDivDropdown(option, dropdown);
        }
    }
}
