using Game_Console.Base;
using System;
using System.Collections;
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
        private int enemyTurn;
        private int playerAttack;
        private int enemyAttack;
        private int playerDefense;
        private int enemyDefense;

        public Battle(bool showInfo) : base(showInfo)
        {
            if (firstTurn == 1)
            {
                Add("Battle starts");
            }

            if (isPlayerTurn == 1)
            {
                Add("Your turn");
                Add("What is going to be your move?");
                Add($"{Player.Instance.Name} | Life: {Player.Instance.Life}");
                Add("1) Attack");
                Add("2) Defend");
                if (firstTurn == 1)
                {
                    firstTurn = 0;
                }
            }
            else
            {
                Add("Enemy turn");
            }
        }

        public override void ProcessOption(string playerOption)
        {
            if (Enemy.Instance.life <= 0)
            {
                Console.WriteLine("Enemy defeated");
            }

            if (Player.Instance.Life <= 0)
            {
                Console.WriteLine("Game over");
                Environment.Exit(0);
            }

            Random rnd = new Random();

            if (isPlayerTurn == 1)
            {
                if (playerOption == "1")
                {
                    playerAttack = rnd.Next(1, 5);  
                }
                else if (playerOption == "2")
                {
                    playerDefense = rnd.Next(10, 50);
                }
                isPlayerTurn = 0;
            }
            else
            {
                enemyTurn = rnd.Next(0, 1);
                if (enemyTurn == 0)
                {
                    enemyAttack = rnd.Next(2, 4);
                    Player.Instance.Life -= enemyAttack * (playerDefense / 100);
                    Console.WriteLine($"The enemy has dealt {enemyAttack} damage to you");
                }
                else
                {
                    enemyDefense = rnd.Next(10, 30);
                    Player.Instance.Life -= playerAttack * (enemyDefense / 100);
                    Console.WriteLine($"You have dealt {playerAttack} damage to the enemy");
                }
                isPlayerTurn = 1;
            }

            Move(new Battle(false));
        }
    }
}
