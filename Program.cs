using System;

namespace GenericProblem
{
    public class Uc2_Generic
    {
        public static float MaxFloatNo(float First_Value, float Second_Value, float Third_Value)
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
            float result = Uc2_Generic.MaxFloatNo(13.6F, 90.432F, 160.4F);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
