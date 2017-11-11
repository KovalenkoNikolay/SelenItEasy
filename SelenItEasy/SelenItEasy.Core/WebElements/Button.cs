using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SelenItEasy.Core.WebElements
{
    public class Button : WebElement
    {
        private readonly IWebDriver _driver;
        private readonly By _by;

        public Button(IWebDriver driver, By by) : base(by)
        {
            //var kernel = new StandardKernel(new NInjectBindings());
            //_driver = kernel.Get<IWebDriver>();
            _by = by;
        }

        public void Click()
        {
            _driver.FindElement(_by).Click();
        }
    }
}
