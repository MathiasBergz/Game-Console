using Game_Console.Scenarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console.Base
{
    internal abstract class Scene
    {
        private World World;
        private int Top = 1;
        protected bool ShowInfo { get; set; } = true;

        public Scene(bool showInfo = true)
        {
            World = new World(20, 80);
            World.Fill();

            if(!string.IsNullOrWhiteSpace(Player.Instance.Name) && showInfo)
            {
                Add($"Player: {Player.Instance.Name} | Life: {Player.Instance.Life} | Coins: {Player.Instance.Coins}");
            }
        }

        public void Add(string text)
        {
            Top += World.Draw(Top, 1, text);
        }

        public string TextInput = "What is your option?";

        public string RequestUserOption()
        {
            Console.WriteLine(TextInput);
            string option = Console.ReadLine();
            return option;
        }

        public void Show()
        {
            World.Print();

            string playerOption = RequestUserOption();

            ProcessOption(playerOption);
        }

        public abstract void ProcessOption(string playerOption);

        public void Move(Scene scene)
        {
            scene.Show();
        }
    }
}
