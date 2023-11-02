using MechaFightingSimulator.Mechs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechaFightingSimulator.Weapons
{
    internal class BaseWeapon
    {
        protected int accuracy = 100; // in percent
        protected int damagePerShot = 1;
        protected int shotsPerAttack = 1;
        protected int attackCooldown = 1000; // in milli
        protected int magazineSize = 1;
        protected int reloadSpeed = 1000; // in milliseconds

        public int magazineLeft = 1;
       // public float attacksCooldown = 1f;
        
        public bool weaponReady = true;
        public bool weaponEmpty = false;

        protected async void reloadWeapon()
        {
            if (magazineLeft != magazineSize || weaponEmpty){
                Thread.Sleep(reloadSpeed); 
                magazineLeft = magazineSize;
                weaponEmpty = false; 
                weaponReady = true; 
            }
        }

        protected async void attack(BaseMech mech)
        {
            if ((!weaponEmpty || magazineSize == -1) && weaponReady)
            {
                int totalDmg = damagePerShot * shotsPerAttack;
            }

        }

        protected async void cooldown()
        {
            weaponReady = false;
            Thread.Sleep(attackCooldown);
            weaponReady = true;

        }
            
    }
}
