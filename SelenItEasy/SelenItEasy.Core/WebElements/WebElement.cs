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
        protected readonly IWebElement _webElement;

        public WebElement(IWebElement seleniumWebElement)
        {
            _webElement = seleniumWebElement;
        }

        public WebElement(By by)
        {
            _webElement = DriverManager.GetDriver().FindElement(by);
        }

        public WebElement(By by, IWebDriver driver)
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
