using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VKNewSpecFlowProject1.Locators.OrangeHR
{
    public static class LoginPageLocators
    {
        public static readonly Dictionary<string, By> Locators = new Dictionary<string, By>
        {
            { "username", By.XPath("//input[@name='username']") },
            { "password", By.XPath("//input[@name='password']") },
            { "login", By.TagName("button") },
            { "error message", By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']") }
        };
    }
}
