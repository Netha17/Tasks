using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class Program
    {
        public static string[] playerType = { "terrorist", "Counter-terrorist" };
        public static string[] weaponType = { "AK-47", "Maverick", "Gut Knife", "Desert Eagle" };
 
        static void Main(string[] args)
        {
            Random random= new Random();
            for(int i=0;i<5;i++)
            {
                int random_num_for_player=random.Next(playerType.Length);
                int randomw_num_for_weapon=random.Next(weaponType.Length);
                Player p = PlayerFactory.getPlayer(getPlayerFromList(random_num_for_player));
                p.assignWeapon(getWeapon(randomw_num_for_weapon));
                p.mission();
                
            }
            Console.ReadLine();
        }
        public static string getPlayerFromList(int id)
        {
            return playerType[id];
        }
        public static string getWeapon(int id) 
        {
            return weaponType[id];
        }
    }
    class PlayerFactory
    {
        static Dictionary<string,Player> d= new Dictionary<string,Player>();
        public static Player getPlayer(string type)
        {
            Player p=null;
            if(d.ContainsKey(type))
            {
                p = d[type];
            }
            else
            {
                switch(type)
                {
                    case "terrorist":
                        p = new Terrorist();
                        Console.WriteLine("Terrorist object has been created");
                        break;
                    case "Counter-terrorist":
                        p = new CounterTerrorist();
                        Console.WriteLine("COunter Terrorist object has been created");
                        break;
                     default :
                        Console.WriteLine("No player found");
                        break;

                }
                d.Add(type, p);
            }
          
            return p;
        }


    }
}
