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
        private IWebDriver _driver;

        public WebElement(IWebDriver driver, By by)
        {
            _driver = driver;
        }
    }
}
