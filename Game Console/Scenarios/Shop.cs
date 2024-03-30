using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Console.Base;

namespace Game_Console.Scenarios
{
    internal class Shop : Scene
    {
        public List<Items> Items;

        public Shop()
        {
            Items = new List<Items>();
            Items.Add(new Items{
                Name = "Health potion",
                Price = 10
            });
            Items.Add(new Items
            {
                Name = "Strength potion",
                Price = 15
            });
            Items.Add(new Items
            {
                Name = "Clone potion",
                Price = 20
            });
            Items.Add(new Items
            {
                Name = "Revive potion",
                Price = 50
            });

            int num = 1;

            foreach(var item in Items)
            {
                Add($"Item {num}) {item.Name} | Price: {item.Price}");
                num++;
            }
            Add("5) Check bagpack");
            Add("6) Exit");
        }
        public override void ProcessOption(string playerOption)
        {
            if(playerOption == "1")
            {
                if(Player.Instance.Coins >= Items[0].Price)
                {
                    Player.Instance.Coins -= Items[0].Price;
                    Player.Instance.Backpack.Itens.Add(new Items
                    {
                        Name = Items[0].Name,
                        Price = Items[0].Price
                    });
                    Console.WriteLine("Thank you stranger");
                } else
                {
                    Console.WriteLine("Not enough cash stranger");
                }

                Move(new Shop());
            } else if(playerOption == "2")
            {
                if (Player.Instance.Coins >= Items[1].Price)
                {
                    Player.Instance.Coins -= Items[1].Price;
                    Player.Instance.Backpack.Itens.Add(new Items
                    {
                        Name = Items[1].Name,
                        Price = Items[1].Price
                    });
                    Console.WriteLine("Thank you stranger");
                }
                else
                {
                    Console.WriteLine("Not enough cash stranger");
                }

                Move(new Shop());
            } else if(playerOption == "3")
            {
                if (Player.Instance.Coins >= Items[2].Price)
                {
                    Player.Instance.Coins -= Items[2].Price;
                    Player.Instance.Backpack.Itens.Add(new Items
                    {
                        Name = Items[2].Name,
                        Price = Items[2].Price
                    });
                    Console.WriteLine("Thank you stranger");
                }
                else
                {
                    Console.WriteLine("Not enough cash stranger");
                }

                Move(new Shop());
            } else if(playerOption == "4")
            {
                if (Player.Instance.Coins >= Items[3].Price)
                {
                    Player.Instance.Coins -= Items[3].Price;
                    Player.Instance.Backpack.Itens.Add(new Items
                    {
                        Name = Items[3].Name,
                        Price = Items[3].Price
                    });
                    Console.WriteLine("Thank you stranger");
                }
                else
                {
                    Console.WriteLine("Not enough cash stranger");
                }

                Move(new Shop());
            } else if(playerOption == "5")
            {
                Console.WriteLine("You have the following itens:");
                foreach (var item in Player.Instance.Backpack.Itens)
                {
                    Console.WriteLine($"Item: {item.Name}");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                Move(new Shop());
            } else if(playerOption == "6")
            {
                Move(new City());
            } else
            {
                Console.Clear();
                Show();
            }
        }
    }
}
