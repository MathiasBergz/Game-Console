using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console
{
    internal class Singleton
    {
        private static Singleton instance;

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton() { }

        public string Name;
    }
}
