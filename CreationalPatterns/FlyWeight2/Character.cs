using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight2
{
    internal class Character
    {
        //intrinsic attributes
        public int size=16;
        public string color="black";
        public string font="Times New Roman";
        public char character;
        //extrinsic attributes
        public int row, col;
        public Character(char ch)
        {
            this.character = ch;
            Console.WriteLine("character " + ch + " object has been created");
        }
        public void setCoordinates(int x, int y)
        {
            this.row = x;
            this.col = y;
                
        }
        public void showCharacter()
        {
            Console.WriteLine("This" + character + "is present at" + row + " row" + "column" + col);
        }
    }
}
