using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight2
{
    internal class Program
    {
        public static char[] char_list = { 'a', 'e', 'i', 'o', 'u' };
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            for(int i=0;i<5;i++)
            { 
            int n=rnd.Next(char_list.Length);
                 
            Character ch = CharacterFactory.GetCharacter(Convert.ToString(char_list[n]));
                ch.setCoordinates(1, 2);
                ch.showCharacter();

            }
            Console.ReadLine();
        }
    }
}
