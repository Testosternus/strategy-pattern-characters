using Strategy.Character.Csl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Character.Csl.Classes
{
    public class Queen : Actor
    {
        public Queen()
        {
            weapon = new BowAndArrowBehaviour();
        }

        public override void display() => Console.WriteLine("I am the Queen of Solitude, daughter of the Emperor! Summon the daedra!\r\n I'll trade the soul of every last subject of mine for a little comfort!");
    }
}
