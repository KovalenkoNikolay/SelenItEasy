using Xunit;
using static SelenItEasy.Core.Main;

namespace Tests
{
    public class Tests
    {


        [Fact]
        public void CheckBox()
        {
            StartChrome();

            StartChrome();

            Open(@"G:\Programming\GitHub\SelenItEasy\SelenItEasy\SelenItEasy\SelenItEasy\Tests\Site\Index.html");

            Open(@"http://google.com");
        }
    }
}
