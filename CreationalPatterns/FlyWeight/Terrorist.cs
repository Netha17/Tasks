using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class Terrorist: Player
    {
            //intrinsic attribute becoz every terrorist player must do the same task
        private  string task="set the bomb";
       //extrinsic attribute becz each player can have desired weapon
       private string weapon;
        public void assignWeapon(string weaponName)
        {
            this.weapon = weaponName;
        }

        public void mission()
        {
            Console.WriteLine("doing task" + task);
        }
    }
}
