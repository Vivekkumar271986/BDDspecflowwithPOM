using System.Collections.Generic;
using OpenQA.Selenium;

namespace VKNewSpecFlowProject1.Locators.RShetty
{
    public static class AngularPracticePageLocators
    {
        public static readonly Dictionary<string, By> Locators = new Dictionary<string, By>
        {
            { "protocommerce", By.XPath("//a[@class='navbar-brand']") },
            { "name", By.XPath("//div[@class='form-group']//input[@name='name']") },
            { "email", By.XPath("//input[@name='email']") },
            { "password", By.XPath("//input[@id='exampleInputPassword1']") },
            { "gender", By.XPath("//select[@id='exampleFormControlSelect1']") },
            { "dateofbirth", By.XPath("//input[@name='bday']") }
        };
    }
}