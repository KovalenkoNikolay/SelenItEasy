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
        public static StandardKernel _kernal;

        public Browser(IWebDriver driver)
        {
            NInjectBindings.driver = driver;

            _kernal = new StandardKernel(new NInjectBindings());
        }
    }
}
