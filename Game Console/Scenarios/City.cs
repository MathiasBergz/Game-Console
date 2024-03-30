using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Console.Base;

namespace Game_Console.Scenarios
{
    internal class City : Scene
    {
        public City() {
            Add("You are at the city and it is to cold");
            Add("-----------------");
            Add("---            --");
            Add("---            --");
            Add("---            --");
            Add("---     ___    --");
            Add("---    |   |   --");
            Add("Which place you want to go?");
            Add("1) Castle");
            Add("2) Florest");
            Add("3) Battlefield");
            Add("4) Quarter");
            Add("5) Blacksmith");
            Add("6) Shop");
            Add("7) Coliseum");
            Add("8) Path to other city");
            Add("9) Anor Londo");
        }

        public override void ProcessOption(string playerOption)
        {
            if (playerOption == "1")
            {
                Castle c = new Castle();
                Move(c);
            }
            else if (playerOption == "2")
            {
                Florest f = new Florest();
                Move(f);
            }
            else if(playerOption == "3")
            {

            } else if(playerOption == "4")
            {

            } else if(playerOption == "5")
            {

            } else if(playerOption == "6")
            {
                Shop sh = new Shop();
                Move(sh);
            } else if(playerOption == "7")
            {
                Move(new Coliseum());
            } else if(playerOption == "8")
            {

            } else if(playerOption == "9")
            {

            } else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
