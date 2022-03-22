using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_1
{
    public class Generic<T> where T : IComparable
    {
        public T MaxValue(T First_Value, T Second_Value, T Third_Value)
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

    }
}
