using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VKNewSpecFlowProject1.Locators.OrangeHR
{
    public static class DashboardPageLocators
    {
        public static readonly Dictionary<string, By> Locators = new Dictionary<string, By>
        {
            { "dashboard", By.XPath("//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module'][text()='Dashboard']") },
            { "leftnavdashboard", By.XPath("//a[@class='oxd-main-menu-item active']") }
        };
    }
}
