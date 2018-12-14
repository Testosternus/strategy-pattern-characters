using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Character.Csl.Classes;
using Strategy.Character.Csl.Services;

namespace Strategy.Character.Csl
{
    public class CharacterSimulator
    {
        static void Main(string[] args)
        {
            Actor potema = new Queen();
            potema.display();
            potema.fight();

            Console.WriteLine("==============");

            Actor tsun = new Knight();
            tsun.display();
            tsun.fight();

            Console.WriteLine("==============");

            Actor torygg = new King();
            torygg.display();
            torygg.fight();
            torygg.setWeapon(new BowAndArrowBehaviour()); //change weapon at runtime
            torygg.fight();

            Console.ReadKey();
        }
    }
}
