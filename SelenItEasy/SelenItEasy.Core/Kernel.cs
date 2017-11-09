using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace SelenItEasy.Core
{
    public class Kernel
    {
        private static object _lock = new object();
        private static IKernel _kernel;

        private Kernel()
        {}

        public static IKernel Instance
        {
            get
            {
                if (_kernel == null)
                {
                    lock (_lock)
                    {
                        if (_kernel == null)
                            _kernel = new StandardKernel(new Binding());
                    }
                }

                return _kernel;
            }
        }
    }
}
