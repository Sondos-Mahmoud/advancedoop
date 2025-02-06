using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedoop
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }
        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                Console.WriteLine("Minimum value cannot be greater than maximum value.");

            Min = min;
            Max = max;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public dynamic Length()
        {
            return (dynamic)Max - (dynamic)Min;
        }
    }
}
