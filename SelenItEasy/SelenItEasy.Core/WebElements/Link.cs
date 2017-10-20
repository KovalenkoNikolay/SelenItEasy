using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class Link : WebElement
    {
        private IWebElement _webElement;

        public Link(IWebDriver driver, By by) : base(driver, by)
        {
            _webElement = driver.FindElement(by);
        }

        public Link Click()
        {
            _webElement.Click();
            return this;
        }
    }
}
