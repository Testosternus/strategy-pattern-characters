using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Character.Csl.Services;

namespace Strategy.Character.Csl.Classes
{
    public class King : Actor
    {
        public King()
        {
            weapon = new SwordBehaviour();
        }

        public override void display() => Console.WriteLine("I faced him fearlessly - my fate inescapable, yet my honor is unstained\r\n - can Ulfric say the same?");
    }
}
