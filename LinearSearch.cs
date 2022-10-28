using System;

namespace Threehaha
{
    public static class LinearSearch
    {
        public static int Find<T>(this T[] array, T value) where T : IEquatable<T>
        {
            Array.Check(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                    return i;
            }
            return -1;
        }

        public static int MinIndex<T>(this T[] array) where T : IComparable<T>
        {
            Array.Check(array);

            var index = 0;
            var value = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i].CompareTo(value) < 0)
                {
                    value = array[i];
                    index = i;
                }
            }
            return index;
        }
    
        public static int MaxIndex<T>(this T[] array) where T : IComparable<T>
        {
            Array.Check(array);

            var indexMax = 0;
            var value = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i].CompareTo(value) > 0)
                {
                    value = array[i];
                    indexMax = i;
                }
            }

            return indexMax;
        }

        public static T MinValue<T>(this T[] array) where T : IComparable<T>
        {
            Array.Check(array);

            var value = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i].CompareTo(value) < 0)
                    value = array[i];
            }

            return value;
        }
    
        public static T MaxValue<T>(this T[] array) where T : IComparable<T>
        {
            Array.Check(array);

            var value = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i].CompareTo(value) > 0)
                    value = array[i];
            }

            return value;
        }
    }
}