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
        private readonly IWebDriver _driver;
        private readonly By _by;

        public Link(IWebDriver driver, By by) : base(driver, by)
        {
            _driver = driver;
            _by = by;
        }

        public Link Click()
        {
            _driver.FindElement(_by).Click();
            return this;
        }
    }
}
