using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leaf file1 = new Leaf(5);
            Composite folder1 = new Composite();
            Composite folder2= new Composite();
            Composite folder3=new Composite();
            Leaf file2 = new Leaf(5);
            Leaf file3 = new Leaf(5);
            Leaf file4 = new Leaf(5);
            Leaf file5 = new Leaf(5);
            Leaf file6 = new Leaf(5);
            Leaf file7 = new Leaf(5);
            folder1.add(file1);
            folder1.add(file2);
            folder1.add(file3);
            folder2.add(file4);
            folder2.add(file5);
            folder2.add(file6);
            folder2.remove(file4);
            folder1.add(folder2);
            folder1.remove(folder2);
            Console.WriteLine("folder2 size:" + folder2.GetSize());
            Console.WriteLine(folder1.GetSize());
            

            Console.ReadLine();


        }
    }
}
