using System;
using System.Text;

namespace StringBuilderroject
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_str = "C#";

            user_str += " String";
            user_str += " builder";

            user_str += " Lesson";
            user_str += " Beginners";
            Console.WriteLine(user_str);
            Console.ReadLine();

            StringBuilder stb = new StringBuilder();
            stb.Append("String Builder");
            stb.Append(" for Study ");
            stb.Append("It add singale memeory");
            stb.Append(" refer the difference");
            Console.WriteLine(stb);
            Console.ReadLine();








        }
    }
}
