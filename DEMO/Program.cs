// using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using DEMO;

namespace Demo
{
    internal class Program
    {
        static object getMax(ref int num1, ref int num2)
        {
            num1 = 18;
            num2 = 78;
            return num1 + " " + num2;
        }
        private static void Main(string[] args)
        {
            Personne.SayHello();
            int num1 = 12;
            int num2 = 16;
            Console.WriteLine(getMax(ref num1, ref num2));
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
