using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using OpenQA.Selenium;

namespace SelenItEasy.Core
{
    public class Browser
    {
        public Browser(IWebDriver driver)
        {
            Kernel.Instance.Get<Storage>().driver = driver;
            var _driver = Kernel.Instance.Get<Storage>().driver;
        }
    }
}
