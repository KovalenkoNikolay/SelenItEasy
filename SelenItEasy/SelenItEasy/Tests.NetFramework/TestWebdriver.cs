using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.NetFramework
{
    public class TestWebdriver
    {
        [Fact]
        public void Test_Driver()
        {
            string pathToChromeDriver = @"G:\";
            //var driver = new ChromeDriver(pathToChromeDriver);

            ChromeDriverService service = ChromeDriverService.CreateDefaultService(pathToChromeDriver);
            service.Port = 5555; // Some port value.
            service.Start();

            var chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = pathToChromeDriver;
            var driver = new RemoteWebDriver(new Uri("http://localhost:5555"), chromeOptions);

            driver.Navigate().GoToUrl(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            var checkbox1 = driver.FindElement(By.Id("checkbox1"));
            var checkbox2 = driver.FindElement(By.Id("checkbox2"));

            var selected1 = checkbox1.Selected;
            checkbox1.Click();
            var selected2 = checkbox1.Selected;

            var selected3 = checkbox2.Selected;
            checkbox2.Click();
            var selected4 = checkbox2.Selected;

            driver.Quit();
        }
        [Fact]
        public void Test_Driver1()
        {
            string pathToChromeDriver = @"G:\";
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(pathToChromeDriver);
            service.Port = 5555; // Some port value.
            service.Start();

            var chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = pathToChromeDriver;
            var driver = new RemoteWebDriver(new Uri("http://localhost:5555"), chromeOptions);

            driver.Navigate().GoToUrl(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            var checkbox1 = driver.FindElement(By.Id("checkbox1"));
            var checkbox2 = driver.FindElement(By.Id("checkbox2"));

            var selected1 = checkbox1.Selected;
            checkbox1.Click();
            var selected2 = checkbox1.Selected;

            var selected3 = checkbox2.Selected;
            checkbox2.Click();
            var selected4 = checkbox2.Selected;

            driver.Quit();
        }
        [Fact]
        public void Test_Driver2()
        {
            string pathToChromeDriver = @"G:\";
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(pathToChromeDriver);
            service.Port = 5555; // Some port value.
            service.Start();

            var chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = pathToChromeDriver;
            var driver = new RemoteWebDriver(new Uri("http://localhost:5555"), chromeOptions);

            driver.Navigate().GoToUrl(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            var checkbox1 = driver.FindElement(By.Id("checkbox1"));
            var checkbox2 = driver.FindElement(By.Id("checkbox2"));

            var selected1 = checkbox1.Selected;
            checkbox1.Click();
            var selected2 = checkbox1.Selected;

            var selected3 = checkbox2.Selected;
            checkbox2.Click();
            var selected4 = checkbox2.Selected;

            driver.Quit();
        }
        [Fact]
        public void Test_Driver3()
        {
            string pathToChromeDriver = @"G:\";
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(pathToChromeDriver);
            service.Port = 5555; // Some port value.
            service.Start();

            var chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = pathToChromeDriver;
            var driver = new RemoteWebDriver(new Uri("http://localhost:5555"), chromeOptions);

            driver.Navigate().GoToUrl(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            var checkbox1 = driver.FindElement(By.Id("checkbox1"));
            var checkbox2 = driver.FindElement(By.Id("checkbox2"));

            var selected1 = checkbox1.Selected;
            checkbox1.Click();
            var selected2 = checkbox1.Selected;

            var selected3 = checkbox2.Selected;
            checkbox2.Click();
            var selected4 = checkbox2.Selected;

            driver.Quit();
        }
        [Fact]
        public void Test_Driver4()
        {
            string pathToChromeDriver = @"G:\";
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(pathToChromeDriver);
            service.Port = 5555; // Some port value.
            service.Start();

            var chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = pathToChromeDriver;
            var driver = new RemoteWebDriver(new Uri("http://localhost:5555"), chromeOptions);

            driver.Navigate().GoToUrl(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            var checkbox1 = driver.FindElement(By.Id("checkbox1"));
            var checkbox2 = driver.FindElement(By.Id("checkbox2"));

            var selected1 = checkbox1.Selected;
            checkbox1.Click();
            var selected2 = checkbox1.Selected;

            var selected3 = checkbox2.Selected;
            checkbox2.Click();
            var selected4 = checkbox2.Selected;

            driver.Quit();
        }
        [Fact]
        public void Test_Driver5()
        {
            string pathToChromeDriver = @"G:\";
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(pathToChromeDriver);
            service.Port = 5555; // Some port value.
            service.Start();

            var chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = pathToChromeDriver;
            var driver = new RemoteWebDriver(new Uri("http://localhost:5555"), chromeOptions);

            driver.Navigate().GoToUrl(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            var checkbox1 = driver.FindElement(By.Id("checkbox1"));
            var checkbox2 = driver.FindElement(By.Id("checkbox2"));

            var selected1 = checkbox1.Selected;
            checkbox1.Click();
            var selected2 = checkbox1.Selected;

            var selected3 = checkbox2.Selected;
            checkbox2.Click();
            var selected4 = checkbox2.Selected;

            driver.Quit();
        }
    }
}
