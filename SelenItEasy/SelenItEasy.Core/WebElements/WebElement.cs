using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public abstract class WebElement
    {
        private readonly IWebElement _webElement;

        public WebElement(IWebDriver driver, By by)
        {
            _webElement = driver.FindElement(by);
        }

        public WebElement Click()
        {
            _webElement.Click();
            return this;
        }
    }
}
