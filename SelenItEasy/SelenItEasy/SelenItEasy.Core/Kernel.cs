using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace SelenItEasy.Core
{
    internal class Kernel
    {
        private static readonly object Lock = new object();
        private static IKernel _kernel;

        private Kernel()
        {}

        public static IKernel Instance
        {
            get
            {
                if (_kernel == null)
                {
                    lock (Lock)
                    {
                        if (_kernel == null)
                            _kernel = new StandardKernel(new NinjectBinding());
                    }
                }

                return _kernel;
            }
        }
    }
}
