using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Console.Base;

namespace Game_Console.Scenarios
{
    internal class Menu : Scene
    {
        public Menu()
        {
            Add("1) Play");
            Add("2) Exit");
        }

        public override void ProcessOption(string playerOption)
        {
            if (playerOption == "1")
            {
                Move(new PlayerName());
            }
            else if (playerOption == "2")
            {
                Environment.Exit(0);
            } else
            {
                Console.Clear();
                Show();
            }
        }
    }
}
