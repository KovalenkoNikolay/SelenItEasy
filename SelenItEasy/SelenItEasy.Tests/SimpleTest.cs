using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using static SelenItEasy.Core.Common;

namespace SelenItEasy.Tests
{
    [TestFixture]
    public class SimpleTest
    {
        [SetUp]
        public void Setup()
        {
            StartChrome();
        }

        [TearDown]
        public void TearDown()
        {
            CurrentBrowser().Quit();
        }

        [Test]
        public void Test()
        {
            CurrentBrowser().Open("http://automated-testing.info/t/razbor-i-kritika-primera-ispolzovaniya-selenium-webdriver-nunit-c/2479");

            var href = LinkCollection(By.XPath("//a[@id]"));
        }

        [Test]
        public void Test1()
        {
            CurrentBrowser().Open("http://automated-testing.info/t/razbor-i-kritika-primera-ispolzovaniya-selenium-webdriver-nunit-c/2479");

            Link(By.XPath("//button[contains(@class,'sign-up-button')]")).Click();
        }

        [Test]
        public void Test2()
        {
            CurrentBrowser().Open("http://automated-testing.info/t/razbor-i-kritika-primera-ispolzovaniya-selenium-webdriver-nunit-c/2479");

            Link(By.XPath("//button[contains(@class,'sign-up-button')]")).Click();
        }

        [Test]
        public void Test3()
        {
            CurrentBrowser().Open("http://automated-testing.info/t/razbor-i-kritika-primera-ispolzovaniya-selenium-webdriver-nunit-c/2479");

            Link(By.XPath("//button[contains(@class,'sign-up-button')]")).Click();
        }
    }
}
