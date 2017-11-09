using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace SelenItEasy.Core
{
    public class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<Storage>().ToSelf().InThreadScope();
        }
    }
}
