using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VKNewSpecFlowProject1.ComponentHelper;
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

        private readonly Dictionary<string, By> _locators = new Dictionary<string, By>
        {
            { "username", By.XPath("//input[@name='username']") },
            { "password", By.XPath("//input[@name='password']") },
            { "login", By.TagName("button") },
            { "dashboard", By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module'][text()='Dashboard']") },
            { "leftnavadmin", By.XPath("//span[text()='Admin']") },
            { "admin", By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module'][text()='Admin']") }
        };

        public By GetLocator(string keyword)
        {
            if (_locators.TryGetValue(keyword.ToLower(), out By locator))
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

    }
}