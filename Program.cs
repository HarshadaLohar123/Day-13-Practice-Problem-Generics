using System;

namespace Generic_Uc5
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Length of Array");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Enter elements of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Uc5_Generic<int> gen = new Uc5_Generic<int>(arr);
            gen.PrintMaxValue();
        }
    }
}
