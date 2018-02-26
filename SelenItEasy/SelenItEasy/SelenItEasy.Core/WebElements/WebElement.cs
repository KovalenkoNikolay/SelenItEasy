using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public abstract class WebElement
    {
        public string TagName => _webElement.TagName;
        public bool IsDisplayed => _webElement.Displayed;
        public bool IsEnabled => _webElement.Enabled;
        public Point Location => _webElement.Location;
        public Size Size => _webElement.Size;

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

        public string GetAttribute(string attributeName)
        {
            return _webElement.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            return _webElement.GetProperty(propertyName);
        }

        public string GetCssValue(string propertyName)
        {
            return _webElement.GetCssValue(propertyName);
        }
    }
}
