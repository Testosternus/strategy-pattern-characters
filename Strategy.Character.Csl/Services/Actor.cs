using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Character.Csl.Services
{
    public abstract class Actor
    {
        protected WeaponBehaviour weapon;
        
        public void setWeapon(WeaponBehaviour w)
        {
            this.weapon = w;
        }

        public abstract void display();

        public void fight()
        {
            weapon.useWeapon();
        }
    }
}
