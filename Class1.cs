using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generic_Uc5
{
    internal class Uc5_Generic<T> where T : IComparable
    {
        public T[] value;

        public Uc5_Generic(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(T[] values)
        {
            T[] SortedValues = Sort(values);
            return SortedValues[SortedValues.Length-1];
        }

        public T MaxValue()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("The maximum is: " + max);
        }
    }
}



