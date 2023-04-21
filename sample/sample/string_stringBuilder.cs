using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class string_stringBuilder
    {
        public static void Main()
        {
            string s = "nithin";
            s += "netha";
            Console.WriteLine(s);
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);
        }

    }
}
