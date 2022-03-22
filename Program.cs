using System;

namespace Generic_Uc4
{
    internal class Uc4_Generic
    {
        static void Main(string[] args)
        {
            double[] doubleArr = new double[4];
            Console.WriteLine("Enter Array Element");
            for(int i=0;i<doubleArr.Length;i++)
            {
                doubleArr[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(doubleArr);
            int a = doubleArr.Length - 1;
            Console.WriteLine("Max No is : "+doubleArr[a]);
            Console.WriteLine("Sorted List Is:");
            foreach(double i in doubleArr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
