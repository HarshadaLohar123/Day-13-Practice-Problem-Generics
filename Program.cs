using System;

namespace RefactorGeneric
{
    public class Refactor_2
    {
        static void Main(string[] args)
        {
            GenericMaximum<int> obj=new GenericMaximum<int>(23, 45, 10);
            int result = obj.MaxMethod();
            Console.WriteLine("Maximum value of integer is= " + result);

            GenericMaximum<double> obj1 = new GenericMaximum<double>(45.9, 45.76, 96.99);
            double result1 = obj1.MaxMethod();
            Console.WriteLine("Maximum value of double is= " + result1);

            GenericMaximum<string> obj2 = new GenericMaximum<string>("454", "687", "963");
            string result2 = obj2.MaxMethod();
            Console.WriteLine("Maximum value of string is= " + result2);

        }
    }
}
