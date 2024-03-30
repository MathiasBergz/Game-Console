using Game_Console.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console.Scenarios
{
    internal class Battle : Scene
    {
        private int firstTurn = 1;
        private int isPlayerTurn = 1;

        public Battle(bool showInfo) : base(showInfo)
        {
            {
                if (firstTurn == 1 && isPlayerTurn == 1)
                {
                    Add("Battle starts");
                    Add("Your turn");
                    Add("");
                    Add("");
                    Add("");
                    Add("");
                    Add("");
                    Add("");
                    Add("What is going to be your move?");
                    Add($"{Player.Instance.Name} | Life: {Player.Instance.Life}");
                    Add("1) Attack");
                    Add("2) Defend");
                    Add("3) Backpack");
                }
                else
                {
                    if (isPlayerTurn == 1)
                    {
                        Add("Your turn");
                        Add("");
                        Add("");
                        Add("");
                        Add("");
                        Add("");
                        Add("");
                        Add("What is going to be your move?");
                        Add("1) Attack");
                        Add("2) Defend");
                        Add("3) Backpack");
                    }
                    else
                    {
                        Add("Enemy turn");
                    }
                }

            }
        }

        public override void ProcessOption(string playerOption)
        {
            Random rnd = new Random();
            switch (playerOption)
            {
                case "1":
                    int attack = rnd.Next(1, 5);
                    Enemy.Instance.life -= attack;
                    Console.WriteLine($"You have dealt {attack} damage to the enemy");
                    isPlayerTurn = 0;
                    firstTurn = 0;
                    Move(new Battle(false));
                    break;
                case "2":
                    int defense = rnd.Next(10, 50);
                    
                    break;
                case "3":
                    break;
                default:
                    Console.Clear();
                    Show();
                    break;
            }
        }
    }
}
