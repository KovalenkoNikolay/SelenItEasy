using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenItEasy.Core
{
    public class NInjectBindings : NinjectModule
    {
        public static IWebDriver driver;

        public override void Load()
        {
            Bind<IWebDriver>().ToConstant(driver).InThreadScope();
        }
    }
}
