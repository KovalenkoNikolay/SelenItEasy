using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenItEasy.Core
{
    public class DriverStorage
    {
        private static IKernel _kernel;

        public static void StoreDriver(IWebDriver driver)
        {
            _kernel = new StandardKernel(new NInjectBindings(driver));
        }

        public static IWebDriver GetDriver()
        {
            return _kernel.Get<NInjectBindings>().Driver;
        }
    }
}
