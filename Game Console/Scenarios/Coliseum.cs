using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Console.Base;

namespace Game_Console.Scenarios 
{
    internal class Coliseum : Scene
    {
        public Coliseum()
        {
            Add("Welcome to the Coliseum");
            Add("Would you like to battle?");
            Add("1) Yes");
            Add("2) No");
        }
        public override void ProcessOption(string playerOption)
        {
            switch(playerOption)
            {
                case "1":
                    Enemy.Instance.life = 30;
                    Enemy.Instance.name = "Warrior";
                    Move(new Battle(false));
                    break;
                case "2":
                    Move(new City());
                    break;
                default:
                    Console.Clear();
                    Show();
                    break;
            }
        }
    }
}
