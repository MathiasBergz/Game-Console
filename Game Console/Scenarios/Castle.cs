using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Console.Base;

namespace Game_Console.Scenarios
{
    internal class Castle : Scene
    {
        public Castle()
        {
            Add("You are inside the castle");
        }

        public override void ProcessOption(string playerOption)
        {
            
        }
    }
}
