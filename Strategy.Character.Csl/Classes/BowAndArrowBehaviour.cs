using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Character.Csl.Services;


namespace Strategy.Character.Csl.Classes
{
    public class BowAndArrowBehaviour : WeaponBehaviour
    {
        public void useWeapon()
        {
            Console.WriteLine("Pew Pew");
        }
    }
}
