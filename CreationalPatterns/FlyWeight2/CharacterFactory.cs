using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight2
{
    internal class CharacterFactory
    {
        public static Dictionary<string,Character> d= new Dictionary<string,Character>();
        public static Character GetCharacter(string name)
        {
            Character ch;
            if(d.ContainsKey(name))
                return d[name];
            else
            {
                if (name == "a" || name == "A")
                    ch= new Character('A');
                else if (name == "e" || name == "E")
                    ch= new Character('E');
                else if (name == "i" || name == "I")
                    ch= new Character('I');
                else if (name == "o" || name == "O")
                    ch= new Character('O');
                else if (name == "u" || name == "U")
                    ch= new Character('U');
                else
                    ch= null;



            }
            d.Add(name, ch);
            return ch;
        }
    }
}
