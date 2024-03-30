using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console.Base
{
    internal class Player
    {
        private static Player instance;

        public static Player Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Player();
                }

                return instance;
            }
        }

        private Player() { 
            Backpack = new Backpack();
        }

        public string Name;
        public int Life;
        public double Coins;

        public Backpack Backpack;
    }
}
