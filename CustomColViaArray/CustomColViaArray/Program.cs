using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomColViaArray
{
    class Nithin : IEnumerable
    {

        public int capacity, length;
        object[] oldArray;

        public Nithin()
        {
            oldArray = new object[4];
            capacity = 4;
            length = 0;

         }
        public Nithin(int capacity)
        {
            this.capacity = capacity;
            oldArray = new object[capacity];
            length = 0;
        }
        private object[] increaseCapacity()
        {
            capacity = 2 * capacity;
            object[] obj = new object[capacity];

            return obj;
        }
        public void Add(object value)
        {

            if (capacity > length)
            {
                oldArray[length] = value;
                length++;
            }
            else
            {
                object[] newArray = increaseCapacity();
                for (int i = 0; i < length; i++)
                {
                    newArray[i] = oldArray[i];
                }
                oldArray = newArray;
                oldArray[length] = value;
                length++;
            }
        }
        public void reverse()
        {
            int left = 0, right = length - 1;
            Object temp;
            while (left < right)
            {

                temp = oldArray[right];
                oldArray[right] = oldArray[left];
                oldArray[left] = temp;

                left++;
                right--;

            }
        }
        public void Traverse()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(oldArray[i]);
            }
        }
        public bool Contains(object value)
        {
            for (int i = 0; i < length; i++)
            {
                if (oldArray[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        public void removeAt(int index)
        {
            if (index < 0 || index >= length)
            {
                Console.WriteLine("index out of bounds error");
            }
            else
            {
                if (index >= 0 && index < length)
                {
                    for (int i = index; i < length-1; i++)
                    {
                        oldArray[i] = oldArray[i + 1];
                    }
                    oldArray[length-1] = null;
                    length = length - 1;
                }
            }
        }
        public void remove(object value)
        {
            for (int i = 0; i < length; i++)
            {

                if (oldArray[i] == value)
                {
                    removeAt(i);
                    return;
                }
            }
            Console.WriteLine("Element not found");
        }

        public IEnumerator GetEnumerator()
        {
            return oldArray.GetEnumerator();
        }
    }

    //add
    //remove
    //removeAt
    //contains
    //foreach
    internal class Program
    {
        static void Main(string[] args)
        {
            Nithin n = new Nithin();
            Console.WriteLine(n.capacity);
            n.Add("nithin");
            n.Add("kamal");
            n.Add("niraj");
            n.Add("naveen");
            foreach(object o in n)
            {
                Console.WriteLine(o);
            }
            n.remove("kamal");
            n.remove("nithin");
            n.remove("niraj");
            foreach(object o in n)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();







        }
    }
}

