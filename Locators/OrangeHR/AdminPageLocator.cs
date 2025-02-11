using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VKNewSpecFlowProject1.Locators.OrangeHR
{
    public static class AdminPageLocators
    {
        public static readonly Dictionary<string, By> Locators = new Dictionary<string, By>
        {
            { "userrole", By.XPath("(//div[@class=\"oxd-select-text-input\"])[1]") }
        };
    }
}
