using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //use lazy initialization to avoid race conditions on multithreading applications
    public sealed class Singleton
    {
        private static volatile Singleton instance = null;

        private Singleton() { }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton getInstance()
        {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            return instance;
        }
    }
}
