using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VKNewSpecFlowProject1.ComponentHelper;
using VKNewSpecFlowProject1.Utility;

namespace VKNewSpecFlowProject1.Pages
{
    public class AngularPracticePage
    {
        private IWebDriver driver;
        private ButtonClickHelper buttonClickHelper;

        public AngularPracticePage(IWebDriver driver)
        {
            this.driver = driver;
            buttonClickHelper = new ButtonClickHelper(driver);
        }

        private readonly Dictionary<string, By> _locators = new Dictionary<string, By>
        {
            { "protocommerce", By.XPath("//a[@class='navbar-brand']") },
            { "name", By.XPath("//div[@class='form-group']//input[@name='name']") },
            { "email", By.XPath("//input[@name='email']") },
            { "password", By.XPath("//input[@id='exampleInputPassword1']") },
            { "gender", By.XPath("//select[@id='exampleFormControlSelect1']") },
            { "dateofbirth", By.XPath("//input[@name='bday']") }
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

        public void WhenISeeInHeader(string keyword)
        {
            By locator = GetLocator(keyword);
            IWebElement PageHeader = driver.FindElement(locator);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => PageHeader.Displayed);
            Console.WriteLine(PageHeader.Text + " is displayed");
        }

        public void WaitForElementToLoad(string keyword, int timeoutInSeconds = 10)
        {
            By locator = GetLocator(keyword);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            IWebElement element = driver.FindElement(locator);
            wait.Until(d => element.Displayed);
        }

        public void FillTheRegistrationForm(Table table)
        {
            //By locator = GetLocator(keyword);

            foreach (var row in table.Rows)
            {
                string Name = row["Name"];
                driver.FindElement(GetLocator("name")).SendKeys(Name);
                string Email = row["Email"];
                driver.FindElement(GetLocator("email")).SendKeys(Email);
                string Password = row["Password"];
                driver.FindElement(GetLocator("password")).SendKeys(Email);
                string Gender = row["Gender"];
                IWebElement dropdown = driver.FindElement(GetLocator("gender"));
                Assert.IsNotNull(dropdown);
                SelectElement select = new SelectElement(dropdown);
                select.SelectByText(Gender);
                string DateofBirth = row["DateofBirth"];
                driver.FindElement(GetLocator("dateofbirth")).SendKeys(DateofBirth);
                //driver.FindElement(By.XPath("//input[@id='inlineRadio1']")).Click();

            }
        }
    }
}