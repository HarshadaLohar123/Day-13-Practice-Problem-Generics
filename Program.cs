using System;

namespace GenericProblem
{
    public class Uc3_Generic
    {
        public static string MaxStringValue(string Str1, string Str2, string Str3)
        {
            if (Str1.CompareTo(Str2) > 0)
            {
                if (Str1.CompareTo(Str3) > 0)
                {
                    return Str1;
                }
                else
                {
                    return Str3;
                }
            }
            else
            {
                if (Str2.CompareTo(Str3) > 0)
                {
                    return Str2;
                }
                else
                {
                    return Str3;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum String Value Is: ");
            string result = Uc3_Generic.MaxStringValue("Apple", "Peach", "Banana");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
