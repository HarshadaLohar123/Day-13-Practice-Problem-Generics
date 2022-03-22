using System;

namespace Refactor_1
{
    public class Generic
    {
        static void Main(string[] args)
        {
            Generic<int> obj = new Generic<int>();
            int result =obj.MaxValue(104, 90, 160);
            Console.WriteLine("Max Value Of Integer Is : "+result);

            Generic<double> obj1 = new Generic<double>();
            double result1 = obj1.MaxValue(23.3,34.6,556.5);
            Console.WriteLine("max value of double is : " + result1);

            Generic<string> obj2 = new Generic<string>();
            string result2 = obj2.MaxValue("Apple","Peach","Banana");
            Console.WriteLine("Max Value Of String Is : " + result2);

        }
    }
}
