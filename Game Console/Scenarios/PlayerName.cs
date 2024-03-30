using Game_Console.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console.Scenarios
{
    internal class PlayerName : Scene
    {
        public PlayerName()
        {
            Add("Hello");
            Add("Create a name for your character");

            TextInput = "Insert the name";
        }

        public override void ProcessOption(string playerOption)
        {
            if(string.IsNullOrEmpty(playerOption))
            {
                Move(new PlayerName());
            } else
            {
                Player.Instance.Name = playerOption;
                Player.Instance.Life = 120;
                Player.Instance.Coins = 200;
                Move(new City());
            }
        }
    }
}
