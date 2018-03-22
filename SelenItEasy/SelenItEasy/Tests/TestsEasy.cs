using OpenQA.Selenium;
using Xunit;
using static SelenItEasy.Core.Main;

namespace Tests
{
    public class TestsEasy
    {
        [Fact]
        public void CheckBoxSelected()
        {
            StartChrome();

            Open(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            //Open(@"http://google.com");

            var checkbox1 = CheckBox(By.Id("checkbox1"));
            var checkbox2 = CheckBox(By.Id("checkbox2"));

            var selected1 = checkbox1.IsSelected;
            var selected2 = checkbox1.SetSelected(true).IsSelected;
            var selected3 = checkbox2.IsSelected;
            var selected4 = checkbox2.SetSelected(false).IsSelected;
            
            CurrentBrowser().Quit();
        }

        [Fact]
        public void CheckBoxSelected1()
        {
            StartChrome();

            Open(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            //Open(@"http://google.com");

            var checkbox1 = CheckBox(By.Id("checkbox1"));
            var checkbox2 = CheckBox(By.Id("checkbox2"));

            var selected1 = checkbox1.IsSelected;
            var selected2 = checkbox1.SetSelected(true).IsSelected;
            var selected3 = checkbox2.IsSelected;
            var selected4 = checkbox2.SetSelected(false).IsSelected;

            CurrentBrowser().Quit();
        }

        [Fact]
        public void CheckBoxSelected2()
        {
            StartChrome();

            Open(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            //Open(@"http://google.com");

            var checkbox1 = CheckBox(By.Id("checkbox1"));
            var checkbox2 = CheckBox(By.Id("checkbox2"));

            var selected1 = checkbox1.IsSelected;
            var selected2 = checkbox1.SetSelected(true).IsSelected;
            var selected3 = checkbox2.IsSelected;
            var selected4 = checkbox2.SetSelected(false).IsSelected;

            CurrentBrowser().Quit();
        }

        [Fact]
        public void CheckBoxSelected3()
        {
            StartChrome();

            Open(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            //Open(@"http://google.com");

            var checkbox1 = CheckBox(By.Id("checkbox1"));
            var checkbox2 = CheckBox(By.Id("checkbox2"));

            var selected1 = checkbox1.IsSelected;
            var selected2 = checkbox1.SetSelected(true).IsSelected;
            var selected3 = checkbox2.IsSelected;
            var selected4 = checkbox2.SetSelected(false).IsSelected;

            CurrentBrowser().Quit();
        }

        [Fact]
        public void CheckBoxSelected4()
        {
            StartChrome();

            Open(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            //Open(@"http://google.com");

            var checkbox1 = CheckBox(By.Id("checkbox1"));
            var checkbox2 = CheckBox(By.Id("checkbox2"));

            var selected1 = checkbox1.IsSelected;
            var selected2 = checkbox1.SetSelected(true).IsSelected;
            var selected3 = checkbox2.IsSelected;
            var selected4 = checkbox2.SetSelected(false).IsSelected;

            CurrentBrowser().Quit();
        }

        [Fact]
        public void CheckBoxSelected5()
        {
            StartChrome();

            Open(@"G:\Programming\Git\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            //Open(@"http://google.com");

            var checkbox1 = CheckBox(By.Id("checkbox1"));
            var checkbox2 = CheckBox(By.Id("checkbox2"));

            var selected1 = checkbox1.IsSelected;
            var selected2 = checkbox1.SetSelected(true).IsSelected;
            var selected3 = checkbox2.IsSelected;
            var selected4 = checkbox2.SetSelected(false).IsSelected;

            CurrentBrowser().Quit();
        }
    }
}