using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console.Base
{
    internal class Enemy
    {
        private static Enemy instance;
        public static Enemy Instance
        {
            get
            {
                if(instance  == null)
                {
                    instance = new Enemy();
                }

                return instance;
            }
        }

        public string name;
        public int life;
    }
}
