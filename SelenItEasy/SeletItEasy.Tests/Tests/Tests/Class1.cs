using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using Xunit;
using static SelenItEasy.Core.Main;

namespace Tests
{
    public class Class1
    {
        [Fact]
        public void Test1()
        {
            StartChrome();
        }
    }
}
