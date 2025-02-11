using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VKNewSpecFlowProject1.ActionHelper
{
    public class ButtonClickHelper
    {
        private IWebDriver driver;
        public ButtonClickHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}