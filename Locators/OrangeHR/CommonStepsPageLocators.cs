using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VKNewSpecFlowProject1.Locators.OrangeHR
{
    public static class CommonStepsPageLocators
    {
        public static readonly Dictionary<string, By> Locators = new Dictionary<string, By>
        {
            { "username", By.XPath("//input[@name='username']") },
            { "password", By.XPath("//input[@name='password']") },
            { "login", By.TagName("button") },
            { "dashboard", By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module'][text()='Dashboard']") },
            { "leftnavadmin", By.XPath("//span[text()='Admin']") },
            { "admin", By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module'][text()='Admin']") },
            { "leftnavdashboard", By.XPath("//a[@class='oxd-main-menu-item active']") },
            { "systemusersusername", By.XPath("(//input[@class='oxd-input oxd-input--active'])[2]") },
            { "userrole", By.XPath("(//div[@class='oxd-select-text-input'])[1]") }
        };
    }
}
