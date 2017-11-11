using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace SelenItEasy.Core
{
    internal class NinjectBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<DriverStorage>().ToSelf().InThreadScope();
        }
    }
}
