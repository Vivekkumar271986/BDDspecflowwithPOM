using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VKNewSpecFlowProject1.ComponentHelper;
using VKNewSpecFlowProject1.Locators.OrangeHR;
using VKNewSpecFlowProject1.Utility;

namespace VKNewSpecFlowProject1.Pages
{
    public class CommonStepsPage
    {
        private IWebDriver driver;
        private ButtonClickHelper buttonClickHelper;

        public CommonStepsPage(IWebDriver driver)
        {
            this.driver = driver;
            buttonClickHelper = new ButtonClickHelper(driver);
        }

        public By GetLocator(string keyword)
        {
            if (CommonStepsPageLocators.Locators.TryGetValue(keyword.ToLower(), out By locator))
            {
                return locator;
            }
            throw new KeyNotFoundException($"Locator for keyword '{keyword}' not found.");
        }

        public void clickbutton(string keyword)
        {
            By locator = GetLocator(keyword);
            buttonClickHelper.ClickButton(locator);
        }

        public void pagedisplay(string keyword)
        {
            By locator = GetLocator(keyword);
            IWebElement page = driver.FindElement(locator);
            if (page.Displayed)
            {
                Console.WriteLine(page.Text + " page is displayed");
            }
            else
            {
                Console.WriteLine(page.Text + " page is not displayed");
            }
        }

        public void WaitForElementToLoad(string keyword, int timeoutInSeconds = 10)
        {
            By locator = GetLocator(keyword);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            IWebElement element = driver.FindElement(locator);
            wait.Until(d => element.Displayed);
        }
    }
}