using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenItEasy.Core
{
    public class By1
    {
        internal string Locator;

        public static By1 Xpath(string xpath)
        {
            return new By1
            {
                Locator = xpath
            };
        }
    }
}
