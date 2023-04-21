using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class CounterTerrorist : Player
    {
        //intrinsic attribute
        public string task = "Diffuse the bomb";
        //extrinsic attribute
        public string weapon;
        public void assignWeapon(string weapon)
        {
            this.weapon= weapon;
        }

        public void mission()
        {
            Console.WriteLine("Doing task" + task);
        }
    }
}
