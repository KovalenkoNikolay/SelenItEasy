using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelenItEasy.Core;
using SelenItEasy.Core.WebElements;

namespace SelenItEasy.Tests
{
    [TestFixture]
    public class SimpleTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://automated-testing.info/t/razbor-i-kritika-primera-ispolzovaniya-selenium-webdriver-nunit-c/2479");

            var button = new Link(driver, By.XPath("//button[contains(@class,'sign-up-button')]"));
            button.Click();
        }
    }
}
