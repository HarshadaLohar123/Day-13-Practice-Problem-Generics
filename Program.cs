using System;

namespace GenericProblem
{
    public class Uc1_Generic
    {
        public static int MaxIntegerNo(int First_Value, int Second_Value, int Third_Value)
        {
            if (First_Value.CompareTo(Second_Value) > 0)
            {
                if (First_Value.CompareTo(Third_Value) > 0)
                {
                    return First_Value;
                }
                else
                {
                    return Third_Value;
                }
            }
            else
            {
                if (Second_Value.CompareTo(Third_Value) > 0)
                {
                    return Second_Value;
                }
                else
                {
                    return Third_Value;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Number");
            int result = Uc1_Generic.MaxIntegerNo(104, 90, 160);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
